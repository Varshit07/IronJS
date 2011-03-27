// <auto-generated />
namespace IronJS.Tests.UnitTests.Sputnik.Conformance.Statement
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class VariableStatementTests : SputnikTestFixture
    {
        public VariableStatementTests()
            : base(@"Conformance\12_Statement\12.2_Variable_Statement")
        {
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 12.2")]
        [Description("Variables are created when the program is entered. Variables are initialised to \"undefined\" when created. A variable with an Initialiser is assigned the value of its AssignmentExpression when the VariableStatement is executed, not when the variable is created")]
        public void S12_2_A1()
        {
            RunFile(@"S12.2_A1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 12.2")]
        [Description("\"var\" statement within \"for\" statement is allowed")]
        public void S12_2_A10()
        {
            RunFile(@"S12.2_A10.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 12.2")]
        [Description("When using property attributes, {ReadOnly} is not used")]
        public void S12_2_A11()
        {
            RunFile(@"S12.2_A11.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 12.2")]
        [Description("VariableDeclaration within \"do-while\" loop is allowed")]
        public void S12_2_A12()
        {
            RunFile(@"S12.2_A12.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 12.2")]
        [Description("Variables are defined with global scope (that is, they are created as members of the global object, as described in 10.1.3) using property attributes { DontDelete}")]
        public void S12_2_A2()
        {
            RunFile(@"S12.2_A2.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 12.2")]
        [Description("FunctionDeclaration produces a new scope")]
        public void S12_2_A3()
        {
            RunFile(@"S12.2_A3.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 12.2")]
        [Description("Unicode characters in variable Identifier are allowed")]
        public void S12_2_A4()
        {
            RunFile(@"S12.2_A4.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 12.2")]
        [Description("VariableDeclaration within Eval statement is initialized as the program reaches the eval statement")]
        public void S12_2_A5()
        {
            RunFile(@"S12.2_A5.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 12.2")]
        [Description("VariableDeclaration within \"try-catch\" statement is allowed")]
        public void S12_2_A6_T1()
        {
            RunFile(@"S12.2_A6_T1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 12.2")]
        [Description("VariableDeclaration within \"try-catch\" statement is allowed")]
        public void S12_2_A6_T2()
        {
            RunFile(@"S12.2_A6_T2.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 12.2")]
        [Description("VariableDeclaration within \"for\" statement is allowed")]
        public void S12_2_A7()
        {
            RunFile(@"S12.2_A7.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 12.2")]
        [Description("Only AssignmentExpression is admitted when variable is initialized")]
        public void S12_2_A8_T1()
        {
            RunFile_ExpectException(@"S12.2_A8_T1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 12.2")]
        [Description("Only AssignmentExpression is admitted when variable is initialized")]
        public void S12_2_A8_T2()
        {
            RunFile_ExpectException(@"S12.2_A8_T2.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 12.2")]
        [Description("Only AssignmentExpression is admitted when variable is initialized")]
        public void S12_2_A8_T3()
        {
            RunFile_ExpectException(@"S12.2_A8_T3.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 12.2")]
        [Description("Only AssignmentExpression is admitted when variable is initialized")]
        public void S12_2_A8_T4()
        {
            RunFile_ExpectException(@"S12.2_A8_T4.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 12.2")]
        [Description("Only AssignmentExpression is admitted when variable is initialized")]
        public void S12_2_A8_T5()
        {
            RunFile_ExpectException(@"S12.2_A8_T5.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 12.2")]
        [Description("Only AssignmentExpression is admitted when variable is initialized")]
        public void S12_2_A8_T6()
        {
            RunFile_ExpectException(@"S12.2_A8_T6.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 12.2")]
        [Description("Only AssignmentExpression is admitted when variable is initialized")]
        public void S12_2_A8_T7()
        {
            RunFile_ExpectException(@"S12.2_A8_T7.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 12.2")]
        [Description("Only AssignmentExpression is admitted when variable is initialized")]
        public void S12_2_A8_T8()
        {
            RunFile_ExpectException(@"S12.2_A8_T8.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 12.2")]
        [Description("When using property attributes, {DontEnum} is not used")]
        public void S12_2_A9()
        {
            RunFile(@"S12.2_A9.js");
        }
    }
}