// <auto-generated />
namespace IronJS.Tests.UnitTests.Sputnik.Conformance.NativeECMAScriptObjects.TheMathObject.ValuePropertiesOfTheMathObject
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class LOG2ETests : SputnikTestFixture
    {
        public LOG2ETests()
            : base(@"Conformance\15_Native_ECMA_Script_Objects\15.8_The_Math_Object\15.8.1_Value_Properties_of_the_Math_Object\15.8.1.4_LOG2E")
        {
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.8.1.4")]
        [TestCase("S15.8.1.4_A1.js", Description = "Math.LOG2E is approximately 1.4426950408889634")]
        public void MathLOG2EIsApproximately14426950408889634(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.8.1.4")]
        [TestCase("S15.8.1.4_A2.js", Description = "Value Property LOG2E of the Math Object has the attribute DontEnum")]
        public void ValuePropertyLOG2EOfTheMathObjectHasTheAttributeDontEnum(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.8.1.4")]
        [TestCase("S15.8.1.4_A3.js", Description = "Value Property LOG2E of the Math Object has the attribute DontDelete")]
        public void ValuePropertyLOG2EOfTheMathObjectHasTheAttributeDontDelete(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.8.1.4")]
        [TestCase("S15.8.1.4_A4.js", Description = "Value Property LOG2E of the Math Object has the attribute ReadOnly")]
        public void ValuePropertyLOG2EOfTheMathObjectHasTheAttributeReadOnly(string file)
        {
            RunFile(file);
        }
    }
}