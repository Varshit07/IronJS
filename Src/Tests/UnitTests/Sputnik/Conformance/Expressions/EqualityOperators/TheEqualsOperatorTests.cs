// <auto-generated />
namespace IronJS.Tests.UnitTests.Sputnik.Conformance.Expressions.EqualityOperators
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class TheEqualsOperatorTests : SputnikTestFixture
    {
        public TheEqualsOperatorTests()
            : base(@"Conformance\11_Expressions\11.9_Equality_Operators\11.9.1_The_Equals_Operator")
        {
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 11.9.1")]
        [TestCategory("ECMA 7.2")]
        [TestCategory("ECMA 7.3")]
        [Description("White Space and Line Terminator between EqualityExpression and \"==\" or between \"==\" and RelationalExpression are allowed")]
        public void S11_9_1_A1()
        {
            RunFile(@"S11.9.1_A1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 11.9.1")]
        [Description("Operator x == y uses GetValue")]
        public void S11_9_1_A2_1_T1()
        {
            RunFile(@"S11.9.1_A2.1_T1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 11.9.1")]
        [Description("Operator x == y uses GetValue")]
        public void S11_9_1_A2_1_T2()
        {
            RunFile(@"S11.9.1_A2.1_T2.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 11.9.1")]
        [Description("Operator x == y uses GetValue")]
        public void S11_9_1_A2_1_T3()
        {
            RunFile(@"S11.9.1_A2.1_T3.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 11.9.1")]
        [Description("First expression is evaluated first, and then second expression")]
        public void S11_9_1_A2_4_T1()
        {
            RunFile(@"S11.9.1_A2.4_T1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 11.9.1")]
        [Description("First expression is evaluated first, and then second expression")]
        public void S11_9_1_A2_4_T2()
        {
            RunFile(@"S11.9.1_A2.4_T2.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 11.9.1")]
        [Description("First expression is evaluated first, and then second expression")]
        public void S11_9_1_A2_4_T3()
        {
            RunFile(@"S11.9.1_A2.4_T3.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 11.9.1")]
        [TestCategory("ECMA 11.9.3")]
        [Description("Return true, if x and y are both true or both false")]
        public void S11_9_1_A3_1()
        {
            RunFile(@"S11.9.1_A3.1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 11.9.1")]
        [TestCategory("ECMA 11.9.3")]
        [Description("If Type(x) is Boolean and Type(y) is Number, return the result of comparison ToNumber(x) == y")]
        public void S11_9_1_A3_2()
        {
            RunFile(@"S11.9.1_A3.2.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 11.9.1")]
        [TestCategory("ECMA 11.9.3")]
        [Description("If Type(y) is Number and Type(y) is Boolean, return the result of comparison x == ToNumber(y)")]
        public void S11_9_1_A3_3()
        {
            RunFile(@"S11.9.1_A3.3.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 11.9.1")]
        [TestCategory("ECMA 11.9.3")]
        [Description("If x or y is NaN, return false")]
        public void S11_9_1_A4_1_T1()
        {
            RunFile(@"S11.9.1_A4.1_T1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 11.9.1")]
        [TestCategory("ECMA 11.9.3")]
        [Description("If x or y is NaN, return false")]
        public void S11_9_1_A4_1_T2()
        {
            RunFile(@"S11.9.1_A4.1_T2.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 11.9.1")]
        [TestCategory("ECMA 11.9.3")]
        [Description("If x is +0(-0) and y is -0(+0), return true")]
        public void S11_9_1_A4_2()
        {
            RunFile(@"S11.9.1_A4.2.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 11.9.1")]
        [TestCategory("ECMA 11.9.3")]
        [Description("Type(x) and Type(y) are Number-s minus NaN, +0, -0. Return true, if x is the same number value as y")]
        public void S11_9_1_A4_3()
        {
            RunFile(@"S11.9.1_A4.3.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 11.9.1")]
        [TestCategory("ECMA 11.9.3")]
        [Description("Type(x) and Type(y) are String-s. Return true, if x and y are exactly the same sequence of characters")]
        public void S11_9_1_A5_1()
        {
            RunFile(@"S11.9.1_A5.1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 11.9.1")]
        [TestCategory("ECMA 11.9.3")]
        [Description("If Type(x) is Number and Type(y) is String, return the result of comparison x == ToNumber(y)")]
        public void S11_9_1_A5_2()
        {
            RunFile(@"S11.9.1_A5.2.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 11.9.1")]
        [TestCategory("ECMA 11.9.3")]
        [Description("If Type(x) is String and Type(y) is Number, return the result of comparison ToNumber(x) == y")]
        public void S11_9_1_A5_3()
        {
            RunFile(@"S11.9.1_A5.3.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 11.9.1")]
        [TestCategory("ECMA 11.9.3")]
        [Description("If Type(x) as well as Type(y) is undefined or null, return true")]
        public void S11_9_1_A6_1()
        {
            RunFile(@"S11.9.1_A6.1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 11.9.1")]
        [TestCategory("ECMA 11.9.3")]
        [Description("If one expression is undefined or null and another is not, return false")]
        public void S11_9_1_A6_2_T1()
        {
            RunFile(@"S11.9.1_A6.2_T1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 11.9.1")]
        [TestCategory("ECMA 11.9.3")]
        [Description("If one expression is undefined or null and another is not, return false")]
        public void S11_9_1_A6_2_T2()
        {
            RunFile(@"S11.9.1_A6.2_T2.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 11.9.1")]
        [TestCategory("ECMA 11.9.3")]
        [Description("Type(x) and Type(y) are Object-s. Return true, if x and y are references to the same Object")]
        public void S11_9_1_A7_1()
        {
            RunFile(@"S11.9.1_A7.1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 11.9.1")]
        [TestCategory("ECMA 11.9.3")]
        [Description("If Type(x) is Object and Type(y) is Boolean, return ToPrimitive(x) == y")]
        public void S11_9_1_A7_2()
        {
            RunFile(@"S11.9.1_A7.2.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 11.9.1")]
        [TestCategory("ECMA 11.9.3")]
        [Description("If Type(x) is Boolean and Type(y) is Object, return x == ToPrimitive(y)")]
        public void S11_9_1_A7_3()
        {
            RunFile(@"S11.9.1_A7.3.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 11.9.1")]
        [TestCategory("ECMA 11.9.3")]
        [Description("If Type(x) is Object and Type(y) is Number, return ToPrimitive(x) == y")]
        public void S11_9_1_A7_4()
        {
            RunFile(@"S11.9.1_A7.4.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 11.9.1")]
        [TestCategory("ECMA 11.9.3")]
        [Description("If Type(x) is Number and Type(y) is Object, return x == ToPrimitive(y)")]
        public void S11_9_1_A7_5()
        {
            RunFile(@"S11.9.1_A7.5.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 11.9.1")]
        [TestCategory("ECMA 11.9.3")]
        [Description("If Type(x) is Object and Type(y) is String, return ToPrimitive(x) == y")]
        public void S11_9_1_A7_6()
        {
            RunFile(@"S11.9.1_A7.6.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 11.9.1")]
        [TestCategory("ECMA 11.9.3")]
        [Description("If Type(x) is String and Type(y) is Object, return x == ToPrimitive(y)")]
        public void S11_9_1_A7_7()
        {
            RunFile(@"S11.9.1_A7.7.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 11.9.1")]
        [TestCategory("ECMA 11.9.3")]
        [Description("If Type(x) is Object and Type(y) is primitive type, return ToPrimitive(x) == y")]
        public void S11_9_1_A7_8()
        {
            RunFile(@"S11.9.1_A7.8.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 11.9.1")]
        [TestCategory("ECMA 11.9.3")]
        [Description("If Type(x) is primitive type and Type(y) is Object, return x == ToPrimitive(y)")]
        public void S11_9_1_A7_9()
        {
            RunFile(@"S11.9.1_A7.9.js");
        }
    }
}