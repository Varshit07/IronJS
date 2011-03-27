// <auto-generated />
namespace IronJS.Tests.UnitTests.Sputnik.Conformance.NativeECMAScriptObjects.ArrayObjects.PropertiesOfTheArrayConstructor
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class ArrayPrototypeTests : SputnikTestFixture
    {
        public ArrayPrototypeTests()
            : base(@"Conformance\15_Native_ECMA_Script_Objects\15.4_Array_Objects\15.4.3_Properties_of_the_Array_Constructor\15.4.3.1_Array_prototype")
        {
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.4.3.1")]
        [TestCategory("ECMA 15.2.4.5")]
        [Description("The Array has property prototype")]
        public void S15_4_3_1_A1()
        {
            RunFile(@"S15.4.3.1_A1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.4.3.1")]
        [Description("The Array.prototype property has the attribute DontEnum")]
        public void S15_4_3_1_A2()
        {
            RunFile(@"S15.4.3.1_A2.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.4.3.1")]
        [TestCategory("ECMA 15.2.4.5")]
        [Description("The Array.prototype property has the attribute DontDelete")]
        public void S15_4_3_1_A3()
        {
            RunFile(@"S15.4.3.1_A3.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.4.3.1")]
        [Description("The Array.prototype property has the attribute ReadOnly")]
        public void S15_4_3_1_A4()
        {
            RunFile(@"S15.4.3.1_A4.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.4.3.1")]
        [Description("The length property of Array.prototype is 0")]
        public void S15_4_3_1_A5()
        {
            RunFile(@"S15.4.3.1_A5.js");
        }
    }
}