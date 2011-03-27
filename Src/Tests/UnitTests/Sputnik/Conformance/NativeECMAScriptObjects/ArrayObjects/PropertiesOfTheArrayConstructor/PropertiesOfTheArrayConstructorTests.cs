// <auto-generated />
namespace IronJS.Tests.UnitTests.Sputnik.Conformance.NativeECMAScriptObjects.ArrayObjects.PropertiesOfTheArrayConstructor
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class PropertiesOfTheArrayConstructorTests : SputnikTestFixture
    {
        public PropertiesOfTheArrayConstructorTests()
            : base(@"Conformance\15_Native_ECMA_Script_Objects\15.4_Array_Objects\15.4.3_Properties_of_the_Array_Constructor")
        {
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.4.3")]
        [TestCategory("ECMA 15.2.4.5")]
        [Description("The value of the internal [[Prototype]] property of the Array constructor is the Function prototype object")]
        public void S15_4_3_A1_1_T1()
        {
            RunFile(@"S15.4.3_A1.1_T1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.4.3")]
        [TestCategory("ECMA 15.2.4.2")]
        [Description("The value of the internal [[Prototype]] property of the Array constructor is the Function prototype object")]
        public void S15_4_3_A1_1_T2()
        {
            RunFile(@"S15.4.3_A1.1_T2.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.4.3")]
        [TestCategory("ECMA 15.2.4.6")]
        [Description("The value of the internal [[Prototype]] property of the Array constructor is the Function prototype object")]
        public void S15_4_3_A1_1_T3()
        {
            RunFile(@"S15.4.3_A1.1_T3.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.4.3")]
        [TestCategory("ECMA 15.2.4.7")]
        [TestCategory("ECMA 12.6.4")]
        [Description("The length property of Array has the attribute DontEnum")]
        public void S15_4_3_A2_1()
        {
            RunFile(@"S15.4.3_A2.1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.4.3")]
        [TestCategory("ECMA 15.2.4.5")]
        [TestCategory("ECMA 11.4.1")]
        [Description("The length property of Array has the attribute DontDelete")]
        public void S15_4_3_A2_2()
        {
            RunFile(@"S15.4.3_A2.2.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.4.3")]
        [Description("The length property of Array has the attribute ReadOnly")]
        public void S15_4_3_A2_3()
        {
            RunFile(@"S15.4.3_A2.3.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.4.3")]
        [Description("The length property of Array is 1")]
        public void S15_4_3_A2_4()
        {
            RunFile(@"S15.4.3_A2.4.js");
        }
    }
}