// <auto-generated />
namespace IronJS.Tests.UnitTests.Sputnik.Conformance.Expressions.BinaryLogicalOperators
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class LogicalOROperatorTests : SputnikTestFixture
    {
        public LogicalOROperatorTests()
            : base(@"Conformance\11_Expressions\11.11_Binary_Logical_Operators\11.11.2_Logical_OR_Operator")
        {
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 11.11.2")]
        [Description("White Space and Line Terminator between LogicalORExpression and \"||\" or between \"||\" and LogicalANDExpression are allowed")]
        public void S11_11_2_A1()
        {
            RunFile(@"S11.11.2_A1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 11.11.2")]
        [TestCategory("ECMA 8.7.1")]
        [Description("Operator x || y uses GetValue")]
        public void S11_11_2_A2_1_T1()
        {
            RunFile(@"S11.11.2_A2.1_T1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 11.11.2")]
        [TestCategory("ECMA 8.7.1")]
        [Description("Operator x || y uses GetValue")]
        public void S11_11_2_A2_1_T2()
        {
            RunFile(@"S11.11.2_A2.1_T2.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 11.11.2")]
        [TestCategory("ECMA 8.7.1")]
        [Description("Operator x || y uses GetValue")]
        public void S11_11_2_A2_1_T3()
        {
            RunFile(@"S11.11.2_A2.1_T3.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 11.11.2")]
        [TestCategory("ECMA 8.7.1")]
        [TestCategory("ECMA 16")]
        [Description("Operator x || y uses GetValue")]
        public void S11_11_2_A2_1_T4()
        {
            RunFile(@"S11.11.2_A2.1_T4.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 11.11.2")]
        [Description("First expression is evaluated first, and then second expression")]
        public void S11_11_2_A2_4_T1()
        {
            RunFile(@"S11.11.2_A2.4_T1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 11.11.2")]
        [Description("First expression is evaluated first, and then second expression")]
        public void S11_11_2_A2_4_T2()
        {
            RunFile(@"S11.11.2_A2.4_T2.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 11.11.2")]
        [Description("First expression is evaluated first, and then second expression")]
        public void S11_11_2_A2_4_T3()
        {
            RunFile(@"S11.11.2_A2.4_T3.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 11.11.2")]
        [Description("If ToBoolean(x) is false, return y")]
        public void S11_11_2_A3_T1()
        {
            RunFile(@"S11.11.2_A3_T1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 11.11.2")]
        [Description("If ToBoolean(x) is false, return y")]
        public void S11_11_2_A3_T2()
        {
            RunFile(@"S11.11.2_A3_T2.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 11.11.2")]
        [Description("If ToBoolean(x) is false, return y")]
        public void S11_11_2_A3_T3()
        {
            RunFile(@"S11.11.2_A3_T3.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 11.11.2")]
        [Description("If ToBoolean(x) is false, return y")]
        public void S11_11_2_A3_T4()
        {
            RunFile(@"S11.11.2_A3_T4.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 11.11.2")]
        [Description("If ToBoolean(x) is true, return x")]
        public void S11_11_2_A4_T1()
        {
            RunFile(@"S11.11.2_A4_T1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 11.11.2")]
        [Description("If ToBoolean(x) is true, return x")]
        public void S11_11_2_A4_T2()
        {
            RunFile(@"S11.11.2_A4_T2.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 11.11.2")]
        [Description("If ToBoolean(x) is true, return x")]
        public void S11_11_2_A4_T3()
        {
            RunFile(@"S11.11.2_A4_T3.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 11.11.2")]
        [Description("If ToBoolean(x) is true, return x")]
        public void S11_11_2_A4_T4()
        {
            RunFile(@"S11.11.2_A4_T4.js");
        }
    }
}