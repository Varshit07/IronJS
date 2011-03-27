// <auto-generated />
namespace IronJS.Tests.UnitTests.Sputnik.Conformance.LexicalConventions
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class IdentifiersTests : SputnikTestFixture
    {
        public IdentifiersTests()
            : base(@"Conformance\07_Lexical_Conventions\7.6_Identifiers")
        {
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 7.6")]
        [Description("IdentifierStart :: $")]
        public void S7_6_A1_2_T1()
        {
            RunFile(@"S7.6_A1.2_T1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 7.6")]
        [Description("IdentifierStart :: $")]
        public void S7_6_A1_2_T2()
        {
            RunFile(@"S7.6_A1.2_T2.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 7.6")]
        [Description("IdentifierStart :: $")]
        public void S7_6_A1_2_T3()
        {
            RunFile(@"S7.6_A1.2_T3.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 7.6")]
        [Description("IdentifierStart :: _")]
        public void S7_6_A1_3_T1()
        {
            RunFile(@"S7.6_A1.3_T1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 7.6")]
        [Description("IdentifierStart :: _")]
        public void S7_6_A1_3_T2()
        {
            RunFile(@"S7.6_A1.3_T2.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 7.6")]
        [Description("IdentifierStart :: _")]
        public void S7_6_A1_3_T3()
        {
            RunFile(@"S7.6_A1.3_T3.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 7.6")]
        [Description("IdentifierPart :: IdentifierStart")]
        public void S7_6_A2_1_T1()
        {
            RunFile(@"S7.6_A2.1_T1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 7.6")]
        [Description("IdentifierPart :: IdentifierStart")]
        public void S7_6_A2_1_T2()
        {
            RunFile(@"S7.6_A2.1_T2.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 7.6")]
        [Description("IdentifierPart :: IdentifierStart")]
        public void S7_6_A2_1_T3()
        {
            RunFile(@"S7.6_A2.1_T3.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 7.6")]
        [Description("IdentifierPart :: IdentifierStart")]
        public void S7_6_A2_1_T4()
        {
            RunFile(@"S7.6_A2.1_T4.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 7.6")]
        [Description("Correct interpretation of ENGLISH ALPHABET")]
        public void S7_6_A4_1_T1()
        {
            RunFile(@"S7.6_A4.1_T1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 7.6")]
        [Description("Correct interpretation of ENGLISH ALPHABET")]
        public void S7_6_A4_1_T2()
        {
            RunFile(@"S7.6_A4.1_T2.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 7.6")]
        [Description("Correct interpretation of RUSSIAN ALPHABET")]
        public void S7_6_A4_2_T1()
        {
            RunFile(@"S7.6_A4.2_T1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 7.6")]
        [Description("Correct interpretation of RUSSIAN ALPHABET")]
        public void S7_6_A4_2_T2()
        {
            RunFile(@"S7.6_A4.2_T2.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 7.6")]
        [Description("Correct interpretation of DIGITS")]
        public void S7_6_A4_3_T1()
        {
            RunFile(@"S7.6_A4.3_T1.js");
        }
    }
}