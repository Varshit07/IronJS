// <auto-generated />
namespace IronJS.Tests.UnitTests.Sputnik.Conformance.NativeECMAScriptObjects.ArrayObjects.PropertiesOfTheArrayPrototypeObject
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class ArrayPrototypeUnshiftTests : SputnikTestFixture
    {
        public ArrayPrototypeUnshiftTests()
            : base(@"Conformance\15_Native_ECMA_Script_Objects\15.4_Array_Objects\15.4.4_Properties_of_the_Array_Prototype_Object\15.4.4.13_Array_prototype_unshift")
        {
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.4.4.13")]
        [Description("The arguments are prepended to the start of the array, such that their order within the array is the same as the order in which they appear in the argument list")]
        public void S15_4_4_13_A1_T1()
        {
            RunFile(@"S15.4.4.13_A1_T1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.4.4.13")]
        [Description("The arguments are prepended to the start of the array, such that their order within the array is the same as the order in which they appear in the argument list")]
        public void S15_4_4_13_A1_T2()
        {
            RunFile(@"S15.4.4.13_A1_T2.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.4.4.13")]
        [Description("The unshift function is intentionally generic. It does not require that its this value be an Array object")]
        public void S15_4_4_13_A2_T1()
        {
            RunFile(@"S15.4.4.13_A2_T1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.4.4.13")]
        [Description("The unshift function is intentionally generic. It does not require that its this value be an Array object")]
        public void S15_4_4_13_A2_T2()
        {
            RunFile(@"S15.4.4.13_A2_T2.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.4.4.13")]
        [Description("The unshift function is intentionally generic. It does not require that its this value be an Array object")]
        public void S15_4_4_13_A2_T3()
        {
            RunFile(@"S15.4.4.13_A2_T3.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.4.4.13")]
        [Description("Check ToUint32(length) for non Array objects")]
        public void S15_4_4_13_A3_T1()
        {
            RunFile(@"S15.4.4.13_A3_T1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.4.4.13")]
        [Description("Check ToUint32(length) for non Array objects")]
        public void S15_4_4_13_A3_T2()
        {
            RunFile(@"S15.4.4.13_A3_T2.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.4.4.13")]
        [Description("Check ToUint32(length) for non Array objects")]
        public void S15_4_4_13_A3_T3()
        {
            RunFile(@"S15.4.4.13_A3_T3.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.4.4.13")]
        [TestCategory("ECMA 8.6.2.1")]
        [TestCategory("ECMA 8.6.2.5")]
        [Description("[[Get]], [[Delete]] from not an inherited property")]
        public void S15_4_4_13_A4_T1()
        {
            RunFile(@"S15.4.4.13_A4_T1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.4.4.13")]
        [TestCategory("ECMA 8.6.2.1")]
        [TestCategory("ECMA 8.6.2.5")]
        [Description("[[Get]], [[Delete]] from not an inherited property")]
        public void S15_4_4_13_A4_T2()
        {
            RunFile(@"S15.4.4.13_A4_T2.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.4.4.13")]
        [TestCategory("ECMA 15.2.4.7")]
        [TestCategory("ECMA 12.6.4")]
        [Description("The length property of unshift has the attribute DontEnum")]
        public void S15_4_4_13_A5_1()
        {
            RunFile(@"S15.4.4.13_A5.1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.4.4.13")]
        [TestCategory("ECMA 15.2.4.5")]
        [TestCategory("ECMA 11.4.1")]
        [Description("The length property of unshift has the attribute DontDelete")]
        public void S15_4_4_13_A5_2()
        {
            RunFile(@"S15.4.4.13_A5.2.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.4.4.13")]
        [Description("The length property of unshift has the attribute ReadOnly")]
        public void S15_4_4_13_A5_3()
        {
            RunFile(@"S15.4.4.13_A5.3.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.4.4.13")]
        [Description("The length property of unshift is 1")]
        public void S15_4_4_13_A5_4()
        {
            RunFile(@"S15.4.4.13_A5.4.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.4.4.13")]
        [TestCategory("ECMA 15.2.4.7")]
        [TestCategory("ECMA 12.6.4")]
        [Description("The unshift property of Array has the attribute DontEnum")]
        public void S15_4_4_13_A5_5()
        {
            RunFile(@"S15.4.4.13_A5.5.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.4.4.13")]
        [Description("The unshift property of Array has not prototype property")]
        public void S15_4_4_13_A5_6()
        {
            RunFile(@"S15.4.4.13_A5.6.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.4.4.13")]
        [TestCategory("ECMA 11.2.2")]
        [Description("The unshift property of Array can\'t be used as constructor")]
        public void S15_4_4_13_A5_7()
        {
            RunFile(@"S15.4.4.13_A5.7.js");
        }
    }
}