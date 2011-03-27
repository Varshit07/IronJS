// <auto-generated />
namespace IronJS.Tests.UnitTests.Sputnik.Conformance.NativeECMAScriptObjects.RegExpObjects.PropertiesOfRegExpInstances
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class GlobalTests : SputnikTestFixture
    {
        public GlobalTests()
            : base(@"Conformance\15_Native_ECMA_Script_Objects\15.10_RegExp_Objects\15.10.7_Properties_of_RegExp_Instances\15.10.7.2_global")
        {
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.10.7.2")]
        [Description("The RegExp instance global property has the attribute ReadOnly")]
        public void S15_10_7_2_A10()
        {
            RunFile(@"S15.10.7.2_A10.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.10.7.2")]
        [Description("The RegExp instance global property has the attribute DontEnum")]
        public void S15_10_7_2_A8()
        {
            RunFile(@"S15.10.7.2_A8.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.10.7.2")]
        [Description("The RegExp instance global property has the attribute DontDelete")]
        public void S15_10_7_2_A9()
        {
            RunFile(@"S15.10.7.2_A9.js");
        }
    }
}