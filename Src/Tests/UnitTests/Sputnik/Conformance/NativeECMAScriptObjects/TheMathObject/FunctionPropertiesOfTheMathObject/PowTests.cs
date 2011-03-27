// <auto-generated />
namespace IronJS.Tests.UnitTests.Sputnik.Conformance.NativeECMAScriptObjects.TheMathObject.FunctionPropertiesOfTheMathObject
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class PowTests : SputnikTestFixture
    {
        public PowTests()
            : base(@"Conformance\15_Native_ECMA_Script_Objects\15.8_The_Math_Object\15.8.2_Function_Properties_of_the_Math_Object\15.8.2.13_pow")
        {
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.8.2.13")]
        [Description("If y is NaN, Math.pow(x,y) is NaN")]
        public void S15_8_2_13_A1()
        {
            RunFile(@"S15.8.2.13_A1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.8.2.13")]
        [Description("If abs(x)<1 and y is -Infinity, Math.pow(x,y) is +Infinity")]
        public void S15_8_2_13_A10()
        {
            RunFile(@"S15.8.2.13_A10.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.8.2.13")]
        [Description("If x is +Infinity and y>0, Math.pow(x,y) is +Infinity")]
        public void S15_8_2_13_A11()
        {
            RunFile(@"S15.8.2.13_A11.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.8.2.13")]
        [Description("If x is +Infinity and y<0, Math.pow(x,y) is +0")]
        public void S15_8_2_13_A12()
        {
            RunFile(@"S15.8.2.13_A12.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.8.2.13")]
        [Description("If x is -Infinity and y>0 and y is an odd integer, Math.pow(x,y) is -Infinity")]
        public void S15_8_2_13_A13()
        {
            RunFile(@"S15.8.2.13_A13.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.8.2.13")]
        [Description("If x is -Infinity and y>0 and y is NOT an odd integer, Math.pow(x,y) is +Infinity")]
        public void S15_8_2_13_A14()
        {
            RunFile(@"S15.8.2.13_A14.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.8.2.13")]
        [Description("If x is -Infinity and y<0 and y is an odd integer, Math.pow(x,y) is -0")]
        public void S15_8_2_13_A15()
        {
            RunFile(@"S15.8.2.13_A15.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.8.2.13")]
        [Description("If x is -Infinity and y<0 and y is NOT an odd integer, Math.pow(x,y) is +0")]
        public void S15_8_2_13_A16()
        {
            RunFile(@"S15.8.2.13_A16.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.8.2.13")]
        [Description("If x is +0 and y>0, Math.pow(x,y) is +0")]
        public void S15_8_2_13_A17()
        {
            RunFile(@"S15.8.2.13_A17.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.8.2.13")]
        [Description("If x is +0 and y<0, Math.pow(x,y) is +Infinity")]
        public void S15_8_2_13_A18()
        {
            RunFile(@"S15.8.2.13_A18.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.8.2.13")]
        [Description("If x is -0 and y>0 and y is an odd integer, Math.pow(x,y) is -0")]
        public void S15_8_2_13_A19()
        {
            RunFile(@"S15.8.2.13_A19.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.8.2.13")]
        [Description("If y is +0, Math.pow(x,y) is 1, even if x is NaN")]
        public void S15_8_2_13_A2()
        {
            RunFile(@"S15.8.2.13_A2.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.8.2.13")]
        [Description("If x is -0 and y>0 and y is NOT an odd integer, Math.pow(x,y) is +0")]
        public void S15_8_2_13_A20()
        {
            RunFile(@"S15.8.2.13_A20.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.8.2.13")]
        [Description("If x is -0 and y<0 and y is an odd integer, Math.pow(x,y) is -Infinity")]
        public void S15_8_2_13_A21()
        {
            RunFile(@"S15.8.2.13_A21.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.8.2.13")]
        [Description("If x is -0 and y<0 and y is NOT an odd integer, Math.pow(x,y) is +Infinity")]
        public void S15_8_2_13_A22()
        {
            RunFile(@"S15.8.2.13_A22.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.8.2.13")]
        [Description("If x<0 and x is finite and y is finite and y is not an integer, Math.pow(x,y) is NaN")]
        public void S15_8_2_13_A23()
        {
            RunFile(@"S15.8.2.13_A23.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.8.2.13")]
        [Description("Math.pow, recommended that implementations use the approximation algorithms for IEEE 754 arithmetic contained in fdlibm")]
        public void S15_8_2_13_A24()
        {
            RunFile(@"S15.8.2.13_A24.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.8.2.13")]
        [Description("If y is -0, Math.pow(x,y) is 1, even if x is NaN")]
        public void S15_8_2_13_A3()
        {
            RunFile(@"S15.8.2.13_A3.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.8.2.13")]
        [Description("If x is NaN and y is nonzero, Math.pow(x,y) is NaN")]
        public void S15_8_2_13_A4()
        {
            RunFile(@"S15.8.2.13_A4.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.8.2.13")]
        [Description("If abs(x)>1 and y is +Infinity, Math.pow(x,y) is +Infinity")]
        public void S15_8_2_13_A5()
        {
            RunFile(@"S15.8.2.13_A5.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.8.2.13")]
        [Description("If abs(x)>1 and y is -Infinity, Math.pow(x,y) is +0")]
        public void S15_8_2_13_A6()
        {
            RunFile(@"S15.8.2.13_A6.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.8.2.13")]
        [Description("If abs(x)==1 and y is +Infinity, Math.pow(x,y) is NaN")]
        public void S15_8_2_13_A7()
        {
            RunFile(@"S15.8.2.13_A7.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.8.2.13")]
        [Description("If abs(x)==1 and y is -Infinity, Math.pow(x,y) is NaN")]
        public void S15_8_2_13_A8()
        {
            RunFile(@"S15.8.2.13_A8.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.8.2.13")]
        [Description("If abs(x)<1 and y is +Infinity, Math.pow(x,y) is +0")]
        public void S15_8_2_13_A9()
        {
            RunFile(@"S15.8.2.13_A9.js");
        }
    }
}