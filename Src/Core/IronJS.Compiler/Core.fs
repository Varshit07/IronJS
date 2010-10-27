﻿namespace IronJS.Compiler

open System
open IronJS
open IronJS.Aliases
open IronJS.Utils
open IronJS.Compiler

type Compiler = Ctx -> Ast.Tree -> Dlr.Expr
type OptionCompiler = Ctx -> Ast.Tree option -> Dlr.Expr option

module Core =

  //----------------------------------------------------------------------------
  // Compiler functions
  let rec private compileAst (ctx:Context) ast =
    match ast with
    //Constants
    | Ast.Null -> Dlr.null'
    | Ast.Pass -> Dlr.void'
    | Ast.This -> ctx.This
    | Ast.Undefined -> Expr.BoxedConstants.undefined
    | Ast.String s -> Dlr.constant s
    | Ast.Number n -> Dlr.constant n
    | Ast.Boolean b -> Dlr.constant b

    //Others
    | Ast.Convert(tag, ast) -> Unary.convert ctx tag ast
    | Ast.Identifier name -> Identifier.getValue ctx name
    | Ast.Block trees -> Dlr.blockSimple [for t in trees -> compileAst ctx t]
    | Ast.Assign(ltree, rtree) -> Binary.assign ctx ltree rtree
    | Ast.Eval tree -> compileEval ctx tree
    | Ast.Unary(op, tree) -> compileUnary ctx op tree
    | Ast.Binary(op, left, right) -> Binary.compile ctx op left right

    //Scopes
    | Ast.LocalScope(scope, tree) -> Scope.localScope ctx scope tree
    | Ast.With(init, tree) -> Scope.with' ctx init tree

    //Objects
    | Ast.Object properties -> Object.literalObject ctx properties
    | Ast.Array indexes -> Object.literalArray ctx indexes
    | Ast.Index(tree, index) -> Object.getIndex ctx tree index
    | Ast.Property(tree, name) -> Object.getProperty ctx tree name
    
    //Functions
    | Ast.Invoke(func, args)  -> Function.invoke ctx func args
    | Ast.New(func, args) -> Function.new' ctx func args
    | Ast.Return tree -> Function.return' ctx tree
    | Ast.Function(levels, id, body) -> 
      Function.create ctx compile levels id body


    //Control Flow
    | Ast.Switch(value, cases) -> ControlFlow.switch ctx value cases
    | Ast.While(label, test, body) -> ControlFlow.while' ctx label test body
    | Ast.DoWhile(label, body, test) -> ControlFlow.doWhile' ctx label body test
    | Ast.Break label -> ControlFlow.break' ctx label
    | Ast.Continue label -> ControlFlow.continue' ctx label
    | Ast.Label(label, ast) -> ControlFlow.label ctx label ast
    | Ast.IfElse(test, true', false') -> ControlFlow.if' ctx test true' false'
    | Ast.Ternary(test, true', false') -> 
      ControlFlow.ternary ctx test true' false'

    | Ast.For(label, init, test, incr, body) -> 
      ControlFlow.for' ctx label init test incr body

    //Exceptions
    | Ast.Try(body, catch, finally') -> Exception.try' ctx body catch finally'
    | Ast.Throw tree -> Exception.throw ctx tree
      
    | _ -> failwithf "Failed to compile %A" ast
      
  //----------------------------------------------------------------------------
  and private compileUnary ctx op ast =
    match op with
    | Ast.UnaryOp.Delete -> Unary.delete ctx ast
    | Ast.UnaryOp.TypeOf -> Unary.typeOf (compileAst ctx ast)
    | Ast.UnaryOp.Void -> Unary.void' ctx ast
    | Ast.UnaryOp.Inc -> Unary.increment ctx ast
    | Ast.UnaryOp.Dec -> Unary.decrement ctx ast
    | Ast.UnaryOp.PostInc -> Unary.postIncrement ctx ast
    | Ast.UnaryOp.PostDec -> Unary.postDecrement ctx ast
    | Ast.UnaryOp.BitCmpl -> Unary.complement ctx ast
    | Ast.UnaryOp.Not -> Unary.not ctx ast
    | Ast.UnaryOp.Plus -> Unary.plus ctx ast
    | Ast.UnaryOp.Minus -> Unary.minus ctx ast
      
  //----------------------------------------------------------------------------
  // Compiles a call to eval, e.g: eval('foo = 1');
  and compileEval (ctx:Context) evalTree =
    let eval = Dlr.paramT<IjsBox> "eval"
    let target = Dlr.paramT<EvalTarget> "target"
    
    Dlr.block [eval; target] [
      (Dlr.assign eval (Object.Property.get ctx.Globals ("eval" |> Dlr.const')))
      (Dlr.assign target Dlr.newT<EvalTarget>)

      (Expr.assignValue
        (Dlr.field target "GlobalLevel") (Dlr.const' ctx.Scope.GlobalLevel))
      (Expr.assignValue
        (Dlr.field target "ClosureLevel") (Dlr.const' ctx.Scope.ClosureLevel))
      (Expr.assignValue
        (Dlr.field target "LocalLevel") (Dlr.const' ctx.Scope.LocalLevel))
      (Expr.assignValue
        (Dlr.field target "Closures") (Dlr.const' ctx.Scope.Closures))
        
      (Expr.assignValue (Dlr.field target "Target") (compileAst ctx evalTree))
      (Expr.assignValue (Dlr.field target "Function") ctx.Function)
      (Expr.assignValue (Dlr.field target "This") ctx.This)
      (Expr.assignValue (Dlr.field target "Local") ctx.LocalScope)
      (Expr.assignValue (Dlr.field target "ScopeChain") ctx.ClosureScope)
      (Expr.assignValue (Dlr.field target "DynamicScope") ctx.DynamicScope)

      (Expr.testIsFunction
        (eval)
        (fun x -> Function.invokeAsFunction x ctx.This [target])
        (fun x -> Expr.BoxedConstants.undefined))]

  //----------------------------------------------------------------------------
  // Main compiler function that setups compilation and invokes compileAst
  and compile (target:Target) =

    //Parameter variables
    let parameterExprs =
      target.ParamTypes
        |> Seq.mapi (fun i type' -> Dlr.param (sprintf "param%i" i) type')
        |> Seq.toArray
          
    //--------------------------------------------------------------------------
    // Main Context
    let ctx = {
      Compiler = compileAst
      Target = target
      InsideWith = false
      ScopeChain = List.empty
      ReturnLabel = Dlr.labelVoid "~return"

      Break = None
      Continue = None
      BreakLabels = Map.empty
      ContinueLabels = Map.empty

      Function = Dlr.paramT<IjsFunc> "~function"
      This = Dlr.paramT<IjsObj> "~this"
      LocalScope = Dlr.paramT<Scope> "~localScope"
      ClosureScope = Dlr.paramT<Scope> "~closureScope"
      DynamicScope = Dlr.paramT<DynamicScope> "~dynamicScope"
      Parameters = parameterExprs
    }

    let returnExpr = [
      (Dlr.labelExprVoid ctx.ReturnLabel)
      (ctx.Env_Return)
    ]

    let locals = 
      if ctx.Target.IsEval then [] |> Seq.ofList
      else
        [ ctx.LocalScope; ctx.ClosureScope; ctx.DynamicScope; 
        ] |> Seq.cast<Dlr.ExprParam> 

    //Main function body
    let functionBody = 
      (if ctx.Target.IsFunction then returnExpr else [])
        |> Seq.append [ctx.Compile target.Ast]
        |> Dlr.block locals

    let allParameters =
      (
        if ctx.Target.IsEval then 
          [ ctx.Function; ctx.This; ctx.LocalScope; 
            ctx.ClosureScope; ctx.DynamicScope
          ] |> Seq.cast<Dlr.ExprParam>
        else 
          ctx.Parameters
            |> Seq.cast<Dlr.ExprParam>
            |> Seq.append (Seq.cast<Dlr.ExprParam> [ctx.Function; ctx.This])

      ) |> Array.ofSeq


    let lambda = 
      match target.Delegate with 
      | Some d -> Dlr.lambda d allParameters functionBody
      | _ -> Dlr.lambdaAuto allParameters functionBody
      
    Debug.printExpr lambda
    lambda.Compile()
      
  let compileAsGlobal env tree =
    compile {
      TargetMode = TargetMode.Global
      Ast = tree
      Delegate = None
      Environment = env
    }

