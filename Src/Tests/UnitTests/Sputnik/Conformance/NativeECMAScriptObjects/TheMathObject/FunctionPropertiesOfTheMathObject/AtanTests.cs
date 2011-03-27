// <auto-generated />
namespace IronJS.Tests.UnitTests.Sputnik.Conformance.NativeECMAScriptObjects.TheMathObject.FunctionPropertiesOfTheMathObject
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class AtanTests : SputnikTestFixture
    {
        public AtanTests()
            : base(@"Conformance\15_Native_ECMA_Script_Objects\15.8_The_Math_Object\15.8.2_Function_Properties_of_the_Math_Object\15.8.2.4_atan")
        {
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.8.2.4")]
        [Description("If x is NaN, Math.atan(x) is NaN")]
        public void S15_8_2_4_A1()
        {
            RunFile(@"S15.8.2.4_A1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.8.2.4")]
        [Description("If x is +0, Math.atan(x) is +0")]
        public void S15_8_2_4_A2()
        {
            RunFile(@"S15.8.2.4_A2.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.8.2.4")]
        [Description("If x is -0, Math.atan(x) is -0")]
        public void S15_8_2_4_A3()
        {
            RunFile(@"S15.8.2.4_A3.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.8.2.4")]
        [Description("If x is +Infinity, Math.atan(x) is an implementation-dependent approximation to +PI/2")]
        public void S15_8_2_4_A4()
        {
            RunFile(@"S15.8.2.4_A4.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.8.2.4")]
        [Description("If x is -Infinity, Math.atan(x) is an implementation-dependent approximation to -PI/2")]
        public void S15_8_2_4_A5()
        {
            RunFile(@"S15.8.2.4_A5.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.8.2.4")]
        [Description("Math.atan, recommended that implementations use the approximation algorithms for IEEE 754 arithmetic contained in fdlibm")]
        public void S15_8_2_4_A6()
        {
            RunFile(@"S15.8.2.4_A6.js");
        }
    }
}