// <auto-generated />
namespace IronJS.Tests.UnitTests.Sputnik.Conformance.NativeECMAScriptObjects.ArrayObjects.PropertiesOfTheArrayPrototypeObject
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class ArrayPrototypeJoinTests : SputnikTestFixture
    {
        public ArrayPrototypeJoinTests()
            : base(@"Conformance\15_Native_ECMA_Script_Objects\15.4_Array_Objects\15.4.4_Properties_of_the_Array_Prototype_Object\15.4.4.5_Array_prototype_join")
        {
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.4.4.5")]
        [Description("If length is zero, return the empty string")]
        public void S15_4_4_5_A1_1_T1()
        {
            RunFile(@"S15.4.4.5_A1.1_T1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.4.4.5")]
        [Description("If separator is undefined, a single comma is used as the separator")]
        public void S15_4_4_5_A1_2_T1()
        {
            RunFile(@"S15.4.4.5_A1.2_T1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.4.4.5")]
        [Description("If separator is undefined, a single comma is used as the separator")]
        public void S15_4_4_5_A1_2_T2()
        {
            RunFile(@"S15.4.4.5_A1.2_T2.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.4.4.5")]
        [Description("If array element is undefined or null, use the empty string")]
        public void S15_4_4_5_A1_3_T1()
        {
            RunFile(@"S15.4.4.5_A1.3_T1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.4.4.5")]
        [Description("The join function is intentionally generic. It does not require that its this value be an Array object")]
        public void S15_4_4_5_A2_T1()
        {
            RunFile(@"S15.4.4.5_A2_T1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.4.4.5")]
        [Description("The join function is intentionally generic. It does not require that its this value be an Array object")]
        public void S15_4_4_5_A2_T2()
        {
            RunFile(@"S15.4.4.5_A2_T2.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.4.4.5")]
        [Description("The join function is intentionally generic. It does not require that its this value be an Array object")]
        public void S15_4_4_5_A2_T3()
        {
            RunFile(@"S15.4.4.5_A2_T3.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.4.4.5")]
        [Description("The join function is intentionally generic. It does not require that its this value be an Array object")]
        public void S15_4_4_5_A2_T4()
        {
            RunFile(@"S15.4.4.5_A2_T4.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.4.4.5")]
        [Description("Operator use ToString from separator")]
        public void S15_4_4_5_A3_1_T1()
        {
            RunFile(@"S15.4.4.5_A3.1_T1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.4.4.5")]
        [Description("Operator use ToString from separator")]
        public void S15_4_4_5_A3_1_T2()
        {
            RunFile(@"S15.4.4.5_A3.1_T2.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.4.4.5")]
        [Description("Operator use ToString from array arguments")]
        public void S15_4_4_5_A3_2_T1()
        {
            RunFile(@"S15.4.4.5_A3.2_T1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.4.4.5")]
        [Description("Operator use ToString from array arguments")]
        public void S15_4_4_5_A3_2_T2()
        {
            RunFile(@"S15.4.4.5_A3.2_T2.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.4.4.5")]
        [Description("Check ToUint32(length) for non Array objects")]
        public void S15_4_4_5_A4_T1()
        {
            RunFile(@"S15.4.4.5_A4_T1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.4.4.5")]
        [Description("Check ToUint32(length) for non Array objects")]
        public void S15_4_4_5_A4_T2()
        {
            RunFile(@"S15.4.4.5_A4_T2.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.4.4.5")]
        [Description("Check ToUint32(length) for non Array objects")]
        public void S15_4_4_5_A4_T3()
        {
            RunFile(@"S15.4.4.5_A4_T3.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.4.4.5")]
        [TestCategory("ECMA 8.6.2.1")]
        [Description("[[Get]] from not an inherited property")]
        public void S15_4_4_5_A5_T1()
        {
            RunFile(@"S15.4.4.5_A5_T1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.4.4.5")]
        [TestCategory("ECMA 15.2.4.7")]
        [TestCategory("ECMA 12.6.4")]
        [Description("The length property of join has the attribute DontEnum")]
        public void S15_4_4_5_A6_1()
        {
            RunFile(@"S15.4.4.5_A6.1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.4.4.5")]
        [TestCategory("ECMA 15.2.4.5")]
        [TestCategory("ECMA 11.4.1")]
        [Description("The length property of join has the attribute DontDelete")]
        public void S15_4_4_5_A6_2()
        {
            RunFile(@"S15.4.4.5_A6.2.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.4.4.5")]
        [Description("The length property of join has the attribute ReadOnly")]
        public void S15_4_4_5_A6_3()
        {
            RunFile(@"S15.4.4.5_A6.3.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.4.4.5")]
        [Description("The length property of join is 1")]
        public void S15_4_4_5_A6_4()
        {
            RunFile(@"S15.4.4.5_A6.4.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.4.4.5")]
        [TestCategory("ECMA 15.2.4.7")]
        [TestCategory("ECMA 12.6.4")]
        [Description("The join property of Array has the attribute DontEnum")]
        public void S15_4_4_5_A6_5()
        {
            RunFile(@"S15.4.4.5_A6.5.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.4.4.5")]
        [Description("The join property of Array has not prototype property")]
        public void S15_4_4_5_A6_6()
        {
            RunFile(@"S15.4.4.5_A6.6.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.4.4.5")]
        [TestCategory("ECMA 11.2.2")]
        [Description("The join property of Array can\'t be used as constructor")]
        public void S15_4_4_5_A6_7()
        {
            RunFile(@"S15.4.4.5_A6.7.js");
        }
    }
}