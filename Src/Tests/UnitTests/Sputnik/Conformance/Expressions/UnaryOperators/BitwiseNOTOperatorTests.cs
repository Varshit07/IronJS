// <auto-generated />
namespace IronJS.Tests.UnitTests.Sputnik.Conformance.Expressions.UnaryOperators
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class BitwiseNOTOperatorTests : SputnikTestFixture
    {
        public BitwiseNOTOperatorTests()
            : base(@"Conformance\11_Expressions\11.4_Unary_Operators\11.4.8_Bitwise_NOT_Operator")
        {
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 11.4.8")]
        [TestCategory("ECMA 7.2")]
        [TestCategory("ECMA 7.3")]
        [Description("White Space and Line Terminator between \"~\" and UnaryExpression are allowed")]
        public void S11_4_8_A1()
        {
            RunFile(@"S11.4.8_A1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 11.4.8")]
        [Description("Operator ~x uses GetValue")]
        public void S11_4_8_A2_1_T1()
        {
            RunFile(@"S11.4.8_A2.1_T1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 11.4.8")]
        [Description("Operator ~x uses GetValue")]
        public void S11_4_8_A2_1_T2()
        {
            RunFile(@"S11.4.8_A2.1_T2.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 11.4.8")]
        [TestCategory("ECMA 8.6.2.6")]
        [Description("Operator ~x uses [[Default Value]]")]
        public void S11_4_8_A2_2_T1()
        {
            RunFile(@"S11.4.8_A2.2_T1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 11.4.8")]
        [Description("Operator ~x returns ~ToInt32(x)")]
        public void S11_4_8_A3_T1()
        {
            RunFile(@"S11.4.8_A3_T1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 11.4.8")]
        [Description("Operator ~x returns ~ToInt32(x)")]
        public void S11_4_8_A3_T2()
        {
            RunFile(@"S11.4.8_A3_T2.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 11.4.8")]
        [Description("Operator ~x returns ~ToInt32(x)")]
        public void S11_4_8_A3_T3()
        {
            RunFile(@"S11.4.8_A3_T3.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 11.4.8")]
        [Description("Operator ~x returns ~ToInt32(x)")]
        public void S11_4_8_A3_T4()
        {
            RunFile(@"S11.4.8_A3_T4.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 11.4.8")]
        [Description("Operator ~x returns ~ToInt32(x)")]
        public void S11_4_8_A3_T5()
        {
            RunFile(@"S11.4.8_A3_T5.js");
        }
    }
}