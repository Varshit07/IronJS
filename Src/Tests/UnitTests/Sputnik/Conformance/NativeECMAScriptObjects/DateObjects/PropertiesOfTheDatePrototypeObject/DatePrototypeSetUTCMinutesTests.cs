// <auto-generated />
namespace IronJS.Tests.UnitTests.Sputnik.Conformance.NativeECMAScriptObjects.DateObjects.PropertiesOfTheDatePrototypeObject
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class DatePrototypeSetUTCMinutesTests : SputnikTestFixture
    {
        public DatePrototypeSetUTCMinutesTests()
            : base(@"Conformance\15_Native_ECMA_Script_Objects\15.9_Date_Objects\15.9.5_Properties_of_the_Date_Prototype_Object\15.9.5.33_Date.prototype.setUTCMinutes")
        {
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.9.5.33")]
        [Description("The Date.prototype property \"setUTCMinutes\" has { DontEnum } attributes")]
        public void S15_9_5_33_A1_T1()
        {
            RunFile(@"S15.9.5.33_A1_T1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.9.5.33")]
        [Description("The Date.prototype property \"setUTCMinutes\" has { DontEnum } attributes")]
        public void S15_9_5_33_A1_T2()
        {
            RunFile(@"S15.9.5.33_A1_T2.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.9.5.33")]
        [Description("The Date.prototype property \"setUTCMinutes\" has { DontEnum } attributes")]
        public void S15_9_5_33_A1_T3()
        {
            RunFile(@"S15.9.5.33_A1_T3.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.9.5.33")]
        [Description("The \"length\" property of the \"setUTCMinutes\" is 3")]
        public void S15_9_5_33_A2_T1()
        {
            RunFile(@"S15.9.5.33_A2_T1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.9.5.33")]
        [Description("The Date.prototype.setUTCMinutes property \"length\" has { ReadOnly, DontDelete, DontEnum } attributes")]
        public void S15_9_5_33_A3_T1()
        {
            RunFile(@"S15.9.5.33_A3_T1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.9.5.33")]
        [Description("The Date.prototype.setUTCMinutes property \"length\" has { ReadOnly, DontDelete, DontEnum } attributes")]
        public void S15_9_5_33_A3_T2()
        {
            RunFile(@"S15.9.5.33_A3_T2.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.9.5.33")]
        [Description("The Date.prototype.setUTCMinutes property \"length\" has { ReadOnly, DontDelete, DontEnum } attributes")]
        public void S15_9_5_33_A3_T3()
        {
            RunFile(@"S15.9.5.33_A3_T3.js");
        }
    }
}