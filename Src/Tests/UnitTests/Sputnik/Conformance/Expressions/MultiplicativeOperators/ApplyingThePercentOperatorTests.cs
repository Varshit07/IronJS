// <auto-generated />
namespace IronJS.Tests.UnitTests.Sputnik.Conformance.Expressions.MultiplicativeOperators
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class ApplyingThePercentOperatorTests : SputnikTestFixture
    {
        public ApplyingThePercentOperatorTests()
            : base(@"Conformance\11_Expressions\11.5_Multiplicative_Operators\11.5.3_Applying_the_percent_Operator")
        {
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 11.5.3")]
        [TestCategory("ECMA 7.2")]
        [TestCategory("ECMA 7.3")]
        [Description("White Space and Line Terminator between MultiplicativeExpression and \"%\" or between \"%\" and UnaryExpression are allowed")]
        public void S11_5_3_A1()
        {
            RunFile(@"S11.5.3_A1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 11.5.3")]
        [Description("Operator x % y uses GetValue")]
        public void S11_5_3_A2_1_T1()
        {
            RunFile(@"S11.5.3_A2.1_T1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 11.5.3")]
        [Description("Operator x % y uses GetValue")]
        public void S11_5_3_A2_1_T2()
        {
            RunFile(@"S11.5.3_A2.1_T2.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 11.5.3")]
        [Description("Operator x % y uses GetValue")]
        public void S11_5_3_A2_1_T3()
        {
            RunFile(@"S11.5.3_A2.1_T3.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 11.5.3")]
        [TestCategory("ECMA 8.6.2.6")]
        [Description("Operator x % y uses [[Default Value]]")]
        public void S11_5_3_A2_2_T1()
        {
            RunFile(@"S11.5.3_A2.2_T1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 11.5.3")]
        [Description("ToNumber(first expression) is called first, and then ToNumber(second expression)")]
        public void S11_5_3_A2_3_T1()
        {
            RunFile(@"S11.5.3_A2.3_T1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 11.5.3")]
        [Description("First expression is evaluated first, and then second expression")]
        public void S11_5_3_A2_4_T1()
        {
            RunFile(@"S11.5.3_A2.4_T1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 11.5.3")]
        [Description("First expression is evaluated first, and then second expression")]
        public void S11_5_3_A2_4_T2()
        {
            RunFile(@"S11.5.3_A2.4_T2.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 11.5.3")]
        [Description("First expression is evaluated first, and then second expression")]
        public void S11_5_3_A2_4_T3()
        {
            RunFile(@"S11.5.3_A2.4_T3.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 11.5.3")]
        [Description("Operator x % y returns ToNumber(x) % ToNumber(y)")]
        public void S11_5_3_A3_T1_1()
        {
            RunFile(@"S11.5.3_A3_T1.1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 11.5.3")]
        [Description("Operator x % y returns ToNumber(x) % ToNumber(y)")]
        public void S11_5_3_A3_T1_2()
        {
            RunFile(@"S11.5.3_A3_T1.2.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 11.5.3")]
        [Description("Operator x % y returns ToNumber(x) % ToNumber(y)")]
        public void S11_5_3_A3_T1_3()
        {
            RunFile(@"S11.5.3_A3_T1.3.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 11.5.3")]
        [Description("Operator x % y returns ToNumber(x) % ToNumber(y)")]
        public void S11_5_3_A3_T1_4()
        {
            RunFile(@"S11.5.3_A3_T1.4.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 11.5.3")]
        [Description("Operator x % y returns ToNumber(x) % ToNumber(y)")]
        public void S11_5_3_A3_T1_5()
        {
            RunFile(@"S11.5.3_A3_T1.5.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 11.5.3")]
        [Description("Operator x % y returns ToNumber(x) % ToNumber(y)")]
        public void S11_5_3_A3_T2_1()
        {
            RunFile(@"S11.5.3_A3_T2.1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 11.5.3")]
        [Description("Operator x % y returns ToNumber(x) % ToNumber(y)")]
        public void S11_5_3_A3_T2_2()
        {
            RunFile(@"S11.5.3_A3_T2.2.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 11.5.3")]
        [Description("Operator x % y returns ToNumber(x) % ToNumber(y)")]
        public void S11_5_3_A3_T2_3()
        {
            RunFile(@"S11.5.3_A3_T2.3.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 11.5.3")]
        [Description("Operator x % y returns ToNumber(x) % ToNumber(y)")]
        public void S11_5_3_A3_T2_4()
        {
            RunFile(@"S11.5.3_A3_T2.4.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 11.5.3")]
        [Description("Operator x % y returns ToNumber(x) % ToNumber(y)")]
        public void S11_5_3_A3_T2_5()
        {
            RunFile(@"S11.5.3_A3_T2.5.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 11.5.3")]
        [Description("Operator x % y returns ToNumber(x) % ToNumber(y)")]
        public void S11_5_3_A3_T2_6()
        {
            RunFile(@"S11.5.3_A3_T2.6.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 11.5.3")]
        [Description("Operator x % y returns ToNumber(x) % ToNumber(y)")]
        public void S11_5_3_A3_T2_7()
        {
            RunFile(@"S11.5.3_A3_T2.7.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 11.5.3")]
        [Description("Operator x % y returns ToNumber(x) % ToNumber(y)")]
        public void S11_5_3_A3_T2_8()
        {
            RunFile(@"S11.5.3_A3_T2.8.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 11.5.3")]
        [Description("Operator x % y returns ToNumber(x) % ToNumber(y)")]
        public void S11_5_3_A3_T2_9()
        {
            RunFile(@"S11.5.3_A3_T2.9.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 11.5.3")]
        [Description("The result of a ECMAScript floating-point remainder operation is determined by the rules of IEEE arithmetics")]
        public void S11_5_3_A4_T1_1()
        {
            RunFile(@"S11.5.3_A4_T1.1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 11.5.3")]
        [Description("The result of a ECMAScript floating-point remainder operation is determined by the rules of IEEE arithmetics")]
        public void S11_5_3_A4_T1_2()
        {
            RunFile(@"S11.5.3_A4_T1.2.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 11.5.3")]
        [Description("The result of a ECMAScript floating-point remainder operation is determined by the rules of IEEE arithmetics")]
        public void S11_5_3_A4_T2()
        {
            RunFile(@"S11.5.3_A4_T2.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 11.5.3")]
        [Description("The result of a ECMAScript floating-point remainder operation is determined by the rules of IEEE arithmetics")]
        public void S11_5_3_A4_T3()
        {
            RunFile(@"S11.5.3_A4_T3.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 11.5.3")]
        [Description("The result of a ECMAScript floating-point remainder operation is determined by the rules of IEEE arithmetics")]
        public void S11_5_3_A4_T4()
        {
            RunFile(@"S11.5.3_A4_T4.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 11.5.3")]
        [Description("The result of a ECMAScript floating-point remainder operation is determined by the rules of IEEE arithmetics")]
        public void S11_5_3_A4_T5()
        {
            RunFile(@"S11.5.3_A4_T5.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 11.5.3")]
        [Description("The result of a ECMAScript floating-point remainder operation is determined by the rules of IEEE arithmetics")]
        public void S11_5_3_A4_T6()
        {
            RunFile(@"S11.5.3_A4_T6.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 11.5.3")]
        [TestCategory("ECMA 15.8.2.9")]
        [Description("The result of a ECMAScript floating-point remainder operation is determined by the rules of IEEE arithmetics")]
        public void S11_5_3_A4_T7()
        {
            RunFile(@"S11.5.3_A4_T7.js");
        }
    }
}