// <auto-generated />
namespace IronJS.Tests.UnitTests.Sputnik.Conformance.LexicalConventions.Tokens
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class FutureReservedWordsTests : SputnikTestFixture
    {
        public FutureReservedWordsTests()
            : base(@"Conformance\07_Lexical_Conventions\7.5_Tokens\7.5.3_Future_Reserved_Words")
        {
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 7.5.3")]
        [Description("The \"abstract\" token can not be used as identifier")]
        public void S7_5_3_A1_1()
        {
            RunFile_ExpectException(@"S7.5.3_A1.1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 7.5.3")]
        [Description("The \"export\" token can not be used as identifier")]
        public void S7_5_3_A1_10()
        {
            RunFile_ExpectException(@"S7.5.3_A1.10.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 7.5.3")]
        [Description("The \"extends\" token can not be used as identifier")]
        public void S7_5_3_A1_11()
        {
            RunFile_ExpectException(@"S7.5.3_A1.11.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 7.5.3")]
        [Description("The \"final\" token can not be used as identifier")]
        public void S7_5_3_A1_12()
        {
            RunFile_ExpectException(@"S7.5.3_A1.12.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 7.5.3")]
        [Description("The \"float\" token can not be used as identifier")]
        public void S7_5_3_A1_13()
        {
            RunFile_ExpectException(@"S7.5.3_A1.13.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 7.5.3")]
        [Description("The \"goto\" token can not be used as identifier")]
        public void S7_5_3_A1_14()
        {
            RunFile_ExpectException(@"S7.5.3_A1.14.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 7.5.3")]
        [Description("The \"implements\" token can not be used as identifier")]
        public void S7_5_3_A1_15()
        {
            RunFile_ExpectException(@"S7.5.3_A1.15.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 7.5.3")]
        [Description("The \"import\" token can not be used as identifier")]
        public void S7_5_3_A1_16()
        {
            RunFile_ExpectException(@"S7.5.3_A1.16.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 7.5.3")]
        [Description("The \"int\" token can not be used as identifier")]
        public void S7_5_3_A1_17()
        {
            RunFile_ExpectException(@"S7.5.3_A1.17.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 7.5.3")]
        [Description("The \"interface\" token can not be used as identifier")]
        public void S7_5_3_A1_18()
        {
            RunFile_ExpectException(@"S7.5.3_A1.18.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 7.5.3")]
        [Description("The \"long\" token can not be used as identifier")]
        public void S7_5_3_A1_19()
        {
            RunFile_ExpectException(@"S7.5.3_A1.19.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 7.5.3")]
        [Description("The \"boolean\" token can not be used as identifier")]
        public void S7_5_3_A1_2()
        {
            RunFile_ExpectException(@"S7.5.3_A1.2.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 7.5.3")]
        [Description("The \"native\" token can not be used as identifier")]
        public void S7_5_3_A1_20()
        {
            RunFile_ExpectException(@"S7.5.3_A1.20.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 7.5.3")]
        [Description("The \"package\" token can not be used as identifier")]
        public void S7_5_3_A1_21()
        {
            RunFile_ExpectException(@"S7.5.3_A1.21.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 7.5.3")]
        [Description("The \"private\" token can not be used as identifier")]
        public void S7_5_3_A1_22()
        {
            RunFile_ExpectException(@"S7.5.3_A1.22.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 7.5.3")]
        [Description("The \"protected\" token can not be used as identifier")]
        public void S7_5_3_A1_23()
        {
            RunFile_ExpectException(@"S7.5.3_A1.23.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 7.5.3")]
        [Description("The \"public\" token can not be used as identifier")]
        public void S7_5_3_A1_24()
        {
            RunFile_ExpectException(@"S7.5.3_A1.24.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 7.5.3")]
        [Description("The \"short\" token can not be used as identifier")]
        public void S7_5_3_A1_25()
        {
            RunFile_ExpectException(@"S7.5.3_A1.25.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 7.5.3")]
        [Description("The \"static\" token can not be used as identifier")]
        public void S7_5_3_A1_26()
        {
            RunFile_ExpectException(@"S7.5.3_A1.26.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 7.5.3")]
        [Description("The \"super\" token can not be used as identifier")]
        public void S7_5_3_A1_27()
        {
            RunFile_ExpectException(@"S7.5.3_A1.27.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 7.5.3")]
        [Description("The \"synchronized\" token can not be used as identifier")]
        public void S7_5_3_A1_28()
        {
            RunFile_ExpectException(@"S7.5.3_A1.28.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 7.5.3")]
        [Description("The \"throws\" token can not be used as identifier")]
        public void S7_5_3_A1_29()
        {
            RunFile_ExpectException(@"S7.5.3_A1.29.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 7.5.3")]
        [Description("The \"byte\" token can not be used as identifier")]
        public void S7_5_3_A1_3()
        {
            RunFile_ExpectException(@"S7.5.3_A1.3.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 7.5.3")]
        [Description("The \"transient\" token can not be used as identifier")]
        public void S7_5_3_A1_30()
        {
            RunFile_ExpectException(@"S7.5.3_A1.30.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 7.5.3")]
        [Description("The \"volatile\" token can not be used as identifier")]
        public void S7_5_3_A1_31()
        {
            RunFile_ExpectException(@"S7.5.3_A1.31.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 7.5.3")]
        [Description("The \"char\" token can not be used as identifier")]
        public void S7_5_3_A1_4()
        {
            RunFile_ExpectException(@"S7.5.3_A1.4.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 7.5.3")]
        [Description("The \"class\" token can not be used as identifier")]
        public void S7_5_3_A1_5()
        {
            RunFile_ExpectException(@"S7.5.3_A1.5.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 7.5.3")]
        [Description("The \"const\" token can not be used as identifier")]
        public void S7_5_3_A1_6()
        {
            RunFile_ExpectException(@"S7.5.3_A1.6.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 7.5.3")]
        [Description("The \"debugger\" token can not be used as identifier")]
        public void S7_5_3_A1_7()
        {
            RunFile_ExpectException(@"S7.5.3_A1.7.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 7.5.3")]
        [Description("The \"double\" token can not be used as identifier")]
        public void S7_5_3_A1_8()
        {
            RunFile_ExpectException(@"S7.5.3_A1.8.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 7.5.3")]
        [Description("The \"enum\" token can not be used as identifier")]
        public void S7_5_3_A1_9()
        {
            RunFile_ExpectException(@"S7.5.3_A1.9.js");
        }
    }
}