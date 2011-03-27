// <auto-generated />
namespace IronJS.Tests.UnitTests.Sputnik.Conformance.NativeECMAScriptObjects.ArrayObjects.PropertiesOfArrayInstances
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class PutTests : SputnikTestFixture
    {
        public PutTests()
            : base(@"Conformance\15_Native_ECMA_Script_Objects\15.4_Array_Objects\15.4.5_Properties_of_Array_Instances\15.4.5.1_Put")
        {
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.4.5.1")]
        [TestCategory("ECMA 15.4")]
        [Description("If ToUint32(length) !== ToNumber(length), throw RangeError")]
        public void S15_4_5_1_A1_1_T1()
        {
            RunFile(@"S15.4.5.1_A1.1_T1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.4.5.1")]
        [TestCategory("ECMA 15.4")]
        [Description("If ToUint32(length) !== ToNumber(length), throw RangeError")]
        public void S15_4_5_1_A1_1_T2()
        {
            RunFile(@"S15.4.5.1_A1.1_T2.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.4.5.1")]
        [TestCategory("ECMA 15.4")]
        [Description("For every integer k that is less than the value of the length property of A but not less than ToUint32(length), if A itself has a property (not an inherited property) named ToString(k), then delete that property")]
        public void S15_4_5_1_A1_2_T1()
        {
            RunFile(@"S15.4.5.1_A1.2_T1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.4.5.1")]
        [TestCategory("ECMA 15.4")]
        [Description("For every integer k that is less than the value of the length property of A but not less than ToUint32(length), if A itself has a property (not an inherited property) named ToString(k), then delete that property")]
        public void S15_4_5_1_A1_2_T2()
        {
            RunFile(@"S15.4.5.1_A1.2_T2.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.4.5.1")]
        [TestCategory("ECMA 15.4")]
        [TestCategory("ECMA 15.2.4.5")]
        [Description("For every integer k that is less than the value of the length property of A but not less than ToUint32(length), if A itself has a property (not an inherited property) named ToString(k), then delete that property")]
        public void S15_4_5_1_A1_2_T3()
        {
            RunFile(@"S15.4.5.1_A1.2_T3.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.4.5.1")]
        [TestCategory("ECMA 15.4")]
        [Description("Set the value of property length of A to Uint32(length)")]
        public void S15_4_5_1_A1_3_T1()
        {
            RunFile(@"S15.4.5.1_A1.3_T1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.4.5.1")]
        [TestCategory("ECMA 15.4")]
        [Description("Set the value of property length of A to Uint32(length)")]
        public void S15_4_5_1_A1_3_T2()
        {
            RunFile(@"S15.4.5.1_A1.3_T2.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.4.5.1")]
        [TestCategory("ECMA 15.4")]
        [Description("If P is not an array index, return (Create a property with name P, set its value to V and give it empty attributes)")]
        public void S15_4_5_1_A2_1_T1()
        {
            RunFile(@"S15.4.5.1_A2.1_T1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.4.5.1")]
        [TestCategory("ECMA 15.4")]
        [Description("If ToUint32(P) is less than the value of the length property of A, then return")]
        public void S15_4_5_1_A2_2_T1()
        {
            RunFile(@"S15.4.5.1_A2.2_T1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.4.5.1")]
        [TestCategory("ECMA 15.4")]
        [Description("If ToUint32(P) is less than the value of the length property of A, change (or set) length to ToUint32(P)+1")]
        public void S15_4_5_1_A2_3_T1()
        {
            RunFile(@"S15.4.5.1_A2.3_T1.js");
        }
    }
}