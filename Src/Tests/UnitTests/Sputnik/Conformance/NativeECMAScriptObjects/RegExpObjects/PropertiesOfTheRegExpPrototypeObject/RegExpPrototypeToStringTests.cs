// <auto-generated />
namespace IronJS.Tests.UnitTests.Sputnik.Conformance.NativeECMAScriptObjects.RegExpObjects.PropertiesOfTheRegExpPrototypeObject
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class RegExpPrototypeToStringTests : SputnikTestFixture
    {
        public RegExpPrototypeToStringTests()
            : base(@"Conformance\15_Native_ECMA_Script_Objects\15.10_RegExp_Objects\15.10.6_Properties_of_the_RegExp_Prototype_Object\15.10.6.4_RegExp.prototype.toString")
        {
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.10.6.4")]
        [Description("The RegExp.prototype.toString.length property has the attribute ReadOnly")]
        public void S15_10_6_4_A10()
        {
            RunFile(@"S15.10.6.4_A10.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.10.6.4")]
        [Description("The length property of the toString method is 1")]
        public void S15_10_6_4_A11()
        {
            RunFile(@"S15.10.6.4_A11.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.10.6.4")]
        [TestCategory("ECMA 13.2")]
        [Description("RegExp.prototype.toString has not prototype property")]
        public void S15_10_6_4_A6()
        {
            RunFile(@"S15.10.6.4_A6.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.10.6.4")]
        [TestCategory("ECMA 13.2")]
        [Description("RegExp.prototype.toString can\'t be used as constructor")]
        public void S15_10_6_4_A7()
        {
            RunFile(@"S15.10.6.4_A7.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.10.6.4")]
        [Description("The RegExp.prototype.toString.length property has the attribute DontEnum")]
        public void S15_10_6_4_A8()
        {
            RunFile(@"S15.10.6.4_A8.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.10.6.4")]
        [Description("The RegExp.prototype.toString.length property has the attribute DontDelete")]
        public void S15_10_6_4_A9()
        {
            RunFile(@"S15.10.6.4_A9.js");
        }
    }
}