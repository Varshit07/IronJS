// <auto-generated />
namespace IronJS.Tests.UnitTests.Sputnik.Conformance.Expressions.LeftHandSideExpressions
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class TheNewOperatorTests : SputnikTestFixture
    {
        public TheNewOperatorTests()
            : base(@"Conformance\11_Expressions\11.2_Left_Hand_Side_Expressions\11.2.2_The_new_Operator")
        {
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 11.2.2")]
        [TestCategory("ECMA 7.2")]
        [TestCategory("ECMA 7.3")]
        [Description("White Space and Line Terminator between \"new\" and NewExpression are allowed")]
        public void S11_2_2_A1_1()
        {
            RunFile(@"S11.2.2_A1.1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 11.2.2")]
        [TestCategory("ECMA 7.2")]
        [TestCategory("ECMA 7.3")]
        [Description("White Space and Line Terminator between \"new\" and MemberExpression are allowed")]
        public void S11_2_2_A1_2()
        {
            RunFile(@"S11.2.2_A1.2.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 11.2.2")]
        [Description("Operator \"new\" uses GetValue")]
        public void S11_2_2_A2()
        {
            RunFile(@"S11.2.2_A2.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 11.2.2")]
        [Description("If Type(NewExpression) or Type(MemberExpression) is not Object, throw TypeError")]
        public void S11_2_2_A3_T1()
        {
            RunFile(@"S11.2.2_A3_T1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 11.2.2")]
        [Description("If Type(NewExpression) or Type(MemberExpression) is not Object, throw TypeError")]
        public void S11_2_2_A3_T2()
        {
            RunFile(@"S11.2.2_A3_T2.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 11.2.2")]
        [Description("If Type(NewExpression) or Type(MemberExpression) is not Object, throw TypeError")]
        public void S11_2_2_A3_T3()
        {
            RunFile(@"S11.2.2_A3_T3.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 11.2.2")]
        [Description("If Type(NewExpression) or Type(MemberExpression) is not Object, throw TypeError")]
        public void S11_2_2_A3_T4()
        {
            RunFile(@"S11.2.2_A3_T4.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 11.2.2")]
        [Description("If Type(NewExpression) or Type(MemberExpression) is not Object, throw TypeError")]
        public void S11_2_2_A3_T5()
        {
            RunFile(@"S11.2.2_A3_T5.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 11.2.2")]
        [Description("If NewExpression or MemberExpression does not implement internal [[Construct]] method, throw TypeError")]
        public void S11_2_2_A4_T1()
        {
            RunFile(@"S11.2.2_A4_T1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 11.2.2")]
        [Description("If NewExpression or MemberExpression does not implement internal [[Construct]] method, throw TypeError")]
        public void S11_2_2_A4_T2()
        {
            RunFile(@"S11.2.2_A4_T2.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 11.2.2")]
        [Description("If NewExpression or MemberExpression does not implement internal [[Construct]] method, throw TypeError")]
        public void S11_2_2_A4_T3()
        {
            RunFile(@"S11.2.2_A4_T3.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 11.2.2")]
        [Description("If NewExpression or MemberExpression does not implement internal [[Construct]] method, throw TypeError")]
        public void S11_2_2_A4_T4()
        {
            RunFile(@"S11.2.2_A4_T4.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 11.2.2")]
        [Description("If NewExpression or MemberExpression does not implement internal [[Construct]] method, throw TypeError")]
        public void S11_2_2_A4_T5()
        {
            RunFile(@"S11.2.2_A4_T5.js");
        }
    }
}