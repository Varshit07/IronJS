// <auto-generated />
namespace IronJS.Tests.UnitTests.Sputnik.Conformance.TypeConversion
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class ToUint32Tests : SputnikTestFixture
    {
        public ToUint32Tests()
            : base(@"Conformance\09_Type_Conversion\9.6_ToUint32")
        {
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 9.6")]
        [TestCategory("ECMA 11.7.3")]
        [Description("If value is NaN, +0, -0, +Infinity, or -Infinity, return +0")]
        public void S9_6_A1()
        {
            RunFile(@"S9.6_A1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 9.6")]
        [TestCategory("ECMA 11.7.3")]
        [Description("ToUint32 returns values between 0 and 2^32-1")]
        public void S9_6_A2_1()
        {
            RunFile(@"S9.6_A2.1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 9.6")]
        [TestCategory("ECMA 11.7.3")]
        [Description("Compute result modulo 2^32")]
        public void S9_6_A2_2()
        {
            RunFile(@"S9.6_A2.2.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 9.6")]
        [Description("Operator uses ToNumber")]
        public void S9_6_A3_1_T1()
        {
            RunFile(@"S9.6_A3.1_T1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 9.6")]
        [Description("Operator uses ToNumber")]
        public void S9_6_A3_1_T2()
        {
            RunFile(@"S9.6_A3.1_T2.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 9.6")]
        [Description("Operator uses ToNumber")]
        public void S9_6_A3_1_T3()
        {
            RunFile(@"S9.6_A3.1_T3.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 9.6")]
        [Description("Operator uses ToNumber")]
        public void S9_6_A3_1_T4()
        {
            RunFile(@"S9.6_A3.1_T4.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 9.6")]
        [Description("Operator uses floor, abs")]
        public void S9_6_A3_2_T1()
        {
            RunFile(@"S9.6_A3.2_T1.js");
        }
    }
}