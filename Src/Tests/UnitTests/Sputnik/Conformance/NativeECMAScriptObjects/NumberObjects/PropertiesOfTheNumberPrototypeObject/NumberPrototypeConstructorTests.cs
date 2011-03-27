// <auto-generated />
namespace IronJS.Tests.UnitTests.Sputnik.Conformance.NativeECMAScriptObjects.NumberObjects.PropertiesOfTheNumberPrototypeObject
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class NumberPrototypeConstructorTests : SputnikTestFixture
    {
        public NumberPrototypeConstructorTests()
            : base(@"Conformance\15_Native_ECMA_Script_Objects\15.7_Number_Objects\15.7.4_Properties_of_the_Number_Prototype_Object\15.7.4.1_Number.prototype.constructor")
        {
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.7.4.1")]
        [Description("The initial value of Number.prototype.constructor is the built-in Number constructor")]
        public void S15_7_4_1_A1()
        {
            RunFile(@"S15.7.4.1_A1.js");
        }
    }
}