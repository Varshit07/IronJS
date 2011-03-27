// <auto-generated />
namespace IronJS.Tests.UnitTests.Sputnik.Conformance.Expressions.EqualityOperators
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class TheStrictDoesNotEqualsOperatorTests : SputnikTestFixture
    {
        public TheStrictDoesNotEqualsOperatorTests()
            : base(@"Conformance\11_Expressions\11.9_Equality_Operators\11.9.5_The_Strict_Does_not_equals_Operator")
        {
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 11.9.5")]
        [TestCategory("ECMA 7.2")]
        [TestCategory("ECMA 7.3")]
        [Description("White Space and Line Terminator between EqualityExpression and \"!==\" or between \"!==\" and RelationalExpression are allowed")]
        public void S11_9_5_A1()
        {
            RunFile(@"S11.9.5_A1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 11.9.5")]
        [Description("Operator x !== y uses GetValue")]
        public void S11_9_5_A2_1_T1()
        {
            RunFile(@"S11.9.5_A2.1_T1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 11.9.5")]
        [Description("Operator x !== y uses GetValue")]
        public void S11_9_5_A2_1_T2()
        {
            RunFile(@"S11.9.5_A2.1_T2.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 11.9.5")]
        [Description("Operator x !== y uses GetValue")]
        public void S11_9_5_A2_1_T3()
        {
            RunFile(@"S11.9.5_A2.1_T3.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 11.9.5")]
        [Description("First expression is evaluated first, and then second expression")]
        public void S11_9_5_A2_4_T1()
        {
            RunFile(@"S11.9.5_A2.4_T1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 11.9.5")]
        [Description("First expression is evaluated first, and then second expression")]
        public void S11_9_5_A2_4_T2()
        {
            RunFile(@"S11.9.5_A2.4_T2.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 11.9.5")]
        [Description("First expression is evaluated first, and then second expression")]
        public void S11_9_5_A2_4_T3()
        {
            RunFile(@"S11.9.5_A2.4_T3.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 11.9.5")]
        [TestCategory("ECMA 11.9.6")]
        [Description("Type(x) and Type(y) are Boolean-s. Return false, if x and y are both true or both false")]
        public void S11_9_5_A3()
        {
            RunFile(@"S11.9.5_A3.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 11.9.5")]
        [TestCategory("ECMA 11.9.6")]
        [Description("If x or y is NaN, return true")]
        public void S11_9_5_A4_1_T1()
        {
            RunFile(@"S11.9.5_A4.1_T1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 11.9.5")]
        [TestCategory("ECMA 11.9.6")]
        [Description("If x or y is NaN, return true")]
        public void S11_9_5_A4_1_T2()
        {
            RunFile(@"S11.9.5_A4.1_T2.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 11.9.5")]
        [TestCategory("ECMA 11.9.6")]
        [Description("If x is +0(-0) and y is -0(+0), return false")]
        public void S11_9_5_A4_2()
        {
            RunFile(@"S11.9.5_A4.2.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 11.9.5")]
        [TestCategory("ECMA 11.9.6")]
        [Description("Type(x) and Type(y) are Number-s minus NaN, +0, -0. Return false, if x is the same number value as y")]
        public void S11_9_5_A4_3()
        {
            RunFile(@"S11.9.5_A4.3.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 11.9.5")]
        [TestCategory("ECMA 11.9.6")]
        [Description("Type(x) and Type(y) are String-s. Return false, if x and y are exactly the same sequence of characters")]
        public void S11_9_5_A5()
        {
            RunFile(@"S11.9.5_A5.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 11.9.5")]
        [TestCategory("ECMA 11.9.6")]
        [Description("If Type(x) and Type(y) are Undefined-s, return false")]
        public void S11_9_5_A6_1()
        {
            RunFile(@"S11.9.5_A6.1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 11.9.5")]
        [TestCategory("ECMA 11.9.6")]
        [Description("If Type(x) and Type(y) are Null-s, return false")]
        public void S11_9_5_A6_2()
        {
            RunFile(@"S11.9.5_A6.2.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 11.9.5")]
        [TestCategory("ECMA 11.9.6")]
        [Description("Type(x) and Type(y) are Object-s. Return false, if x and y are references to the same Object")]
        public void S11_9_5_A7()
        {
            RunFile(@"S11.9.5_A7.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 11.9.5")]
        [TestCategory("ECMA 11.9.6")]
        [Description("If Type(x) is different from Type(y), return true")]
        public void S11_9_5_A8_T1()
        {
            RunFile(@"S11.9.5_A8_T1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 11.9.5")]
        [TestCategory("ECMA 11.9.6")]
        [Description("If Type(x) is different from Type(y), return true")]
        public void S11_9_5_A8_T2()
        {
            RunFile(@"S11.9.5_A8_T2.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 11.9.5")]
        [TestCategory("ECMA 11.9.6")]
        [Description("If Type(x) is different from Type(y), return true")]
        public void S11_9_5_A8_T3()
        {
            RunFile(@"S11.9.5_A8_T3.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 11.9.5")]
        [TestCategory("ECMA 11.9.6")]
        [Description("If Type(x) is different from Type(y), return true")]
        public void S11_9_5_A8_T4()
        {
            RunFile(@"S11.9.5_A8_T4.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 11.9.5")]
        [TestCategory("ECMA 11.9.6")]
        [Description("If Type(x) is different from Type(y), return true")]
        public void S11_9_5_A8_T5()
        {
            RunFile(@"S11.9.5_A8_T5.js");
        }
    }
}