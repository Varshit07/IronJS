// <auto-generated />
namespace IronJS.Tests.UnitTests.Sputnik.Conformance.NativeECMAScriptObjects.DateObjects.PropertiesOfTheDatePrototypeObject
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class DatePrototypeSetMinutesTests : SputnikTestFixture
    {
        public DatePrototypeSetMinutesTests()
            : base(@"Conformance\15_Native_ECMA_Script_Objects\15.9_Date_Objects\15.9.5_Properties_of_the_Date_Prototype_Object\15.9.5.32_Date.prototype.setMinutes")
        {
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.9.5.32")]
        [TestCase("S15.9.5.32_A1_T1.js", Description = "The Date.prototype property \"setMinutes\" has { DontEnum } attributes")]
        [TestCase("S15.9.5.32_A1_T2.js", Description = "The Date.prototype property \"setMinutes\" has { DontEnum } attributes")]
        [TestCase("S15.9.5.32_A1_T3.js", Description = "The Date.prototype property \"setMinutes\" has { DontEnum } attributes")]
        public void TheDatePrototypePropertySetMinutesHasDontEnumAttributes(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.9.5.32")]
        [TestCase("S15.9.5.32_A2_T1.js", Description = "The \"length\" property of the \"setMinutes\" is 3")]
        public void TheLengthPropertyOfTheSetMinutesIs3(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.9.5.32")]
        [TestCase("S15.9.5.32_A3_T1.js", Description = "The Date.prototype.setMinutes property \"length\" has { ReadOnly, DontDelete, DontEnum } attributes")]
        [TestCase("S15.9.5.32_A3_T2.js", Description = "The Date.prototype.setMinutes property \"length\" has { ReadOnly, DontDelete, DontEnum } attributes")]
        [TestCase("S15.9.5.32_A3_T3.js", Description = "The Date.prototype.setMinutes property \"length\" has { ReadOnly, DontDelete, DontEnum } attributes")]
        public void TheDatePrototypeSetMinutesPropertyLengthHasReadOnlyDontDeleteDontEnumAttributes(string file)
        {
            RunFile(file);
        }
    }
}