// <auto-generated />
namespace IronJS.Tests.UnitTests.Sputnik.Conformance.NativeECMAScriptObjects.TheGlobalObject.FunctionPropertiesOfTheGlobalObject
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class IsNaNTests : SputnikTestFixture
    {
        public IsNaNTests()
            : base(@"Conformance\15_Native_ECMA_Script_Objects\15.1_The_Global_Object\15.1.2_Function_Properties_of_the_Global_Object\15.1.2.4_isNaN")
        {
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.1.2.4")]
        [Description("isNaN applies ToNumber to its argument, then return true if the result is NaN, and otherwise return false")]
        public void S15_1_2_4_A1_T1()
        {
            RunFile(@"S15.1.2.4_A1_T1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.1.2.4")]
        [Description("isNaN applies ToNumber to its argument, then return true if the result is NaN, and otherwise return false")]
        public void S15_1_2_4_A1_T2()
        {
            RunFile(@"S15.1.2.4_A1_T2.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.1.2.4")]
        [TestCategory("ECMA 15.2.4.7")]
        [TestCategory("ECMA 12.6.4")]
        [Description("The length property of isNaN has the attribute DontEnum")]
        public void S15_1_2_4_A2_1()
        {
            RunFile(@"S15.1.2.4_A2.1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.1.2.4")]
        [TestCategory("ECMA 15.2.4.5")]
        [TestCategory("ECMA 11.4.1")]
        [Description("The length property of isNaN has the attribute DontDelete")]
        public void S15_1_2_4_A2_2()
        {
            RunFile(@"S15.1.2.4_A2.2.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.1.2.4")]
        [Description("The length property of isNaN has the attribute ReadOnly")]
        public void S15_1_2_4_A2_3()
        {
            RunFile(@"S15.1.2.4_A2.3.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.1.2.4")]
        [Description("The length property of isNaN is 1")]
        public void S15_1_2_4_A2_4()
        {
            RunFile(@"S15.1.2.4_A2.4.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.1.2.4")]
        [TestCategory("ECMA 15.2.4.7")]
        [TestCategory("ECMA 12.6.4")]
        [Description("The isNaN property has the attribute DontEnum")]
        public void S15_1_2_4_A2_5()
        {
            RunFile(@"S15.1.2.4_A2.5.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.1.2.4")]
        [Description("The isNaN property has not prototype property")]
        public void S15_1_2_4_A2_6()
        {
            RunFile(@"S15.1.2.4_A2.6.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.1.2.4")]
        [TestCategory("ECMA 11.2.2")]
        [Description("The isNaN property can\'t be used as constructor")]
        public void S15_1_2_4_A2_7()
        {
            RunFile(@"S15.1.2.4_A2.7.js");
        }
    }
}