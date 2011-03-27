// <auto-generated />
namespace IronJS.Tests.UnitTests.Sputnik.Unicode
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class Unicode410Tests : SputnikTestFixture
    {
        public Unicode410Tests()
            : base(@"Unicode\Unicode_410")
        {
        }

        [TestMethod]
        [TestCategory("Sputnik Unicode")]
        [TestCategory("ECMA 15.10.2.12")]
        [TestCategory("ECMA 7.2")]
        [TestCategory("ECMA 7.3")]
        [Description("The production CharacterClassEscape :: s evaluates by returning the set of characters containing the characters that are on the right-hand side of the WhiteSpace (7.2) or LineTerminator (7.3) productions")]
        public void S15_10_2_12_A1_T6()
        {
            RunFile(@"S15.10.2.12_A1_T6.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Unicode")]
        [TestCategory("ECMA 15.10.2.12")]
        [TestCategory("ECMA 7.2")]
        [TestCategory("ECMA 7.3")]
        [Description("The production CharacterClassEscape :: S evaluates by returning the set of all characters not included in the set returned by CharacterClassEscape :: s")]
        public void S15_10_2_12_A2_T6()
        {
            RunFile(@"S15.10.2.12_A2_T6.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Unicode")]
        [TestCategory("ECMA 15.5.4.16")]
        [Description("The characters in UnicodeData.txt, but not in SpecialCasings.txt are converted one by one")]
        public void S15_5_4_16_A1()
        {
            RunFile(@"S15.5.4.16_A1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Unicode")]
        [TestCategory("ECMA 15.5.4.16")]
        [Description("The characters in SpecialCasings.txt are converted by multi-character results")]
        public void S15_5_4_16_A2()
        {
            RunFile(@"S15.5.4.16_A2.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Unicode")]
        [TestCategory("ECMA 15.5.4.18")]
        [Description("The characters in UnicodeData.txt, but not in SpecialCasings.txt are converted one by one")]
        public void S15_5_4_18_A1()
        {
            RunFile(@"S15.5.4.18_A1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Unicode")]
        [TestCategory("ECMA 15.5.4.18")]
        [Description("The characters in SpecialCasings.txt are converted by multi-character results")]
        public void S15_5_4_18_A2()
        {
            RunFile(@"S15.5.4.18_A2.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Unicode")]
        [TestCategory("ECMA 7.1")]
        [Description("The format control character (Cf) can occur anywhere in the source text and these characters are removed before applying the lexical grammar")]
        public void S7_1_A1_T1()
        {
            RunFile(@"S7.1_A1_T1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Unicode")]
        [TestCategory("ECMA 7.1")]
        [Description("Since the format control character (Cf) are removed before processing string literals, one must use a Unicode escape sequence to include a Cf inside string literal")]
        public void S7_1_A2_1_T1()
        {
            RunFile(@"S7.1_A2.1_T1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Unicode")]
        [TestCategory("ECMA 7.1")]
        [Description("Since the format control character (Cf) are removed before processing string literals, one must use a Unicode escape sequence to include a Cf inside string literal")]
        public void S7_1_A2_1_T2()
        {
            RunFile(@"S7.1_A2.1_T2.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Unicode")]
        [TestCategory("ECMA 7.1")]
        [Description("Since the format control character (Cf) are removed before processing regular expression literals, one must use a Unicode escape sequence to include a Cf inside regular expression literal")]
        public void S7_1_A2_2_T1()
        {
            RunFile(@"S7.1_A2.2_T1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Unicode")]
        [TestCategory("ECMA 7.1")]
        [Description("Since the format control character (Cf) are removed before processing regular expression literals, one must use a Unicode escape sequence to include a Cf inside regular expression literal")]
        public void S7_1_A2_2_T2()
        {
            RunFile(@"S7.1_A2.2_T2.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Unicode")]
        [TestCategory("ECMA 7.2")]
        [TestCategory("ECMA 7.5")]
        [Description("Any other Unicode \"space separator\" (category \"Zs\") between any two tokens is allowed")]
        public void S7_2_A1_6_T1()
        {
            RunFile(@"S7.2_A1.6_T1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Unicode")]
        [TestCategory("ECMA 7.2")]
        [TestCategory("ECMA 7.8.4")]
        [Description("Any other Unicode \"space separator\" (category \"Zs\") within strings")]
        public void S7_2_A2_6_T1()
        {
            RunFile(@"S7.2_A2.6_T1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Unicode")]
        [TestCategory("ECMA 7.2")]
        [TestCategory("ECMA 7.4")]
        [Description("Single line comment can contain any other Unicode \"space separator\" (category \"Zs\")")]
        public void S7_2_A3_6_T1()
        {
            RunFile(@"S7.2_A3.6_T1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Unicode")]
        [TestCategory("ECMA 7.2")]
        [TestCategory("ECMA 7.4")]
        [Description("Multi line comment can contain any other Unicode \"space separator\" (category \"Zs\")")]
        public void S7_2_A4_6_T1()
        {
            RunFile(@"S7.2_A4.6_T1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Unicode")]
        [TestCategory("ECMA 7.6")]
        [Description("IdentifierStart :: UnicodeLetter (any character in the Unicode categories \"Lu\", \"Ll\", \"Lt\", \"Lm\", \"Lo\", \"Nl\")")]
        public void S7_6_A1_1_T1()
        {
            RunFile(@"S7.6_A1.1_T1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Unicode")]
        [TestCategory("ECMA 7.6")]
        [Description("IdentifierStart :: UnicodeLetter (any character in the Unicode categories \"Lu\", \"Ll\", \"Lt\", \"Lm\", \"Lo\", \"Nl\")")]
        public void S7_6_A1_1_T2()
        {
            RunFile(@"S7.6_A1.1_T2.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Unicode")]
        [TestCategory("ECMA 7.6")]
        [Description("IdentifierStart :: UnicodeLetter (any character in the Unicode categories \"Lu\", \"Ll\", \"Lt\", \"Lm\", \"Lo\", \"Nl\")")]
        public void S7_6_A1_1_T3()
        {
            RunFile(@"S7.6_A1.1_T3.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Unicode")]
        [TestCategory("ECMA 7.6")]
        [Description("IdentifierStart :: UnicodeLetter (any character in the Unicode categories \"Lu\", \"Ll\", \"Lt\", \"Lm\", \"Lo\", \"Nl\")")]
        public void S7_6_A1_1_T4()
        {
            RunFile(@"S7.6_A1.1_T4.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Unicode")]
        [TestCategory("ECMA 7.6")]
        [Description("IdentifierStart :: UnicodeLetter (any character in the Unicode categories \"Lu\", \"Ll\", \"Lt\", \"Lm\", \"Lo\", \"Nl\")")]
        public void S7_6_A1_1_T5()
        {
            RunFile(@"S7.6_A1.1_T5.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Unicode")]
        [TestCategory("ECMA 7.6")]
        [Description("IdentifierStart :: UnicodeLetter (any character in the Unicode categories \"Lu\", \"Ll\", \"Lt\", \"Lm\", \"Lo\", \"Nl\")")]
        public void S7_6_A1_1_T6()
        {
            RunFile(@"S7.6_A1.1_T6.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Unicode")]
        [TestCategory("ECMA 7.6")]
        [Description("IdentifierName must begin at IdentifierStart")]
        public void S7_6_A1_4_T1()
        {
            RunFile(@"S7.6_A1.4_T1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Unicode")]
        [TestCategory("ECMA 7.6")]
        [Description("IdentifierName must begin at IdentifierStart")]
        public void S7_6_A1_4_T2()
        {
            RunFile(@"S7.6_A1.4_T2.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Unicode")]
        [TestCategory("ECMA 7.6")]
        [Description("IdentifierName must begin at IdentifierStart")]
        public void S7_6_A1_4_T3()
        {
            RunFile(@"S7.6_A1.4_T3.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Unicode")]
        [TestCategory("ECMA 7.6")]
        [Description("IdentifierName must begin at IdentifierStart")]
        public void S7_6_A1_4_T4()
        {
            RunFile(@"S7.6_A1.4_T4.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Unicode")]
        [TestCategory("ECMA 7.6")]
        [Description("IdentifierPart :: UnicodeCombiningMark (any character in the Unicode categories \"Mn\", \"Mc\")")]
        public void S7_6_A2_2_T1()
        {
            RunFile(@"S7.6_A2.2_T1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Unicode")]
        [TestCategory("ECMA 7.6")]
        [Description("IdentifierPart :: UnicodeCombiningMark (any character in the Unicode categories \"Mn\", \"Mc\")")]
        public void S7_6_A2_2_T2()
        {
            RunFile(@"S7.6_A2.2_T2.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Unicode")]
        [TestCategory("ECMA 7.6")]
        [Description("IdentifierPart :: UnicodeDigit (any character in the Unicode categories \"Decimal Number (Nd)\". @description: Complex test with eval")]
        public void S7_6_A2_3()
        {
            RunFile(@"S7.6_A2.3.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Unicode")]
        [TestCategory("ECMA 7.6")]
        [Description("IdentifierPart :: UnicodeConnectorPunctuation (any character in the Unicode categories \"Connector Punctuation (Pc)\". @description: Complex test with eval")]
        public void S7_6_A2_4()
        {
            RunFile(@"S7.6_A2.4.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Unicode")]
        [TestCategory("ECMA 7.6")]
        [Description("IdentifierName must contain only IdentifierPart character")]
        public void S7_6_A3_1()
        {
            RunFile(@"S7.6_A3.1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Unicode")]
        [TestCategory("ECMA 7.6")]
        [Description("IdentifierName must begin only IdentifierStart character")]
        public void S7_6_A3_2()
        {
            RunFile(@"S7.6_A3.2.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Unicode")]
        [TestCategory("ECMA 7.6")]
        [TestCategory("ECMA 6")]
        [Description("If a \\UnicodeEscapeSequence sequence were replaced by its UnicodeEscapeSequence\'s CV, the result must still be a valid Identifier that has the exact same sequence of characters as the original Identifier")]
        public void S7_6_A5_2_T1()
        {
            RunFile(@"S7.6_A5.2_T1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Unicode")]
        [TestCategory("ECMA 7.6")]
        [TestCategory("ECMA 6")]
        [Description("If a \\UnicodeEscapeSequence sequence were replaced by its UnicodeEscapeSequence\'s CV, the result must still be a valid Identifier that has the exact same sequence of characters as the original Identifier")]
        public void S7_6_A5_2_T10()
        {
            RunFile(@"S7.6_A5.2_T10.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Unicode")]
        [TestCategory("ECMA 7.6")]
        [TestCategory("ECMA 6")]
        [Description("If a \\UnicodeEscapeSequence sequence were replaced by its UnicodeEscapeSequence\'s CV, the result must still be a valid Identifier that has the exact same sequence of characters as the original Identifier")]
        public void S7_6_A5_2_T2()
        {
            RunFile(@"S7.6_A5.2_T2.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Unicode")]
        [TestCategory("ECMA 7.6")]
        [TestCategory("ECMA 6")]
        [Description("If a \\UnicodeEscapeSequence sequence were replaced by its UnicodeEscapeSequence\'s CV, the result must still be a valid Identifier that has the exact same sequence of characters as the original Identifier")]
        public void S7_6_A5_2_T3()
        {
            RunFile(@"S7.6_A5.2_T3.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Unicode")]
        [TestCategory("ECMA 7.6")]
        [TestCategory("ECMA 6")]
        [Description("If a \\UnicodeEscapeSequence sequence were replaced by its UnicodeEscapeSequence\'s CV, the result must still be a valid Identifier that has the exact same sequence of characters as the original Identifier")]
        public void S7_6_A5_2_T4()
        {
            RunFile(@"S7.6_A5.2_T4.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Unicode")]
        [TestCategory("ECMA 7.6")]
        [TestCategory("ECMA 6")]
        [Description("If a \\UnicodeEscapeSequence sequence were replaced by its UnicodeEscapeSequence\'s CV, the result must still be a valid Identifier that has the exact same sequence of characters as the original Identifier")]
        public void S7_6_A5_2_T5()
        {
            RunFile(@"S7.6_A5.2_T5.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Unicode")]
        [TestCategory("ECMA 7.6")]
        [TestCategory("ECMA 6")]
        [Description("If a \\UnicodeEscapeSequence sequence were replaced by its UnicodeEscapeSequence\'s CV, the result must still be a valid Identifier that has the exact same sequence of characters as the original Identifier")]
        public void S7_6_A5_2_T6()
        {
            RunFile(@"S7.6_A5.2_T6.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Unicode")]
        [TestCategory("ECMA 7.6")]
        [TestCategory("ECMA 6")]
        [Description("If a \\UnicodeEscapeSequence sequence were replaced by its UnicodeEscapeSequence\'s CV, the result must still be a valid Identifier that has the exact same sequence of characters as the original Identifier")]
        public void S7_6_A5_2_T7()
        {
            RunFile(@"S7.6_A5.2_T7.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Unicode")]
        [TestCategory("ECMA 7.6")]
        [TestCategory("ECMA 6")]
        [Description("If a \\UnicodeEscapeSequence sequence were replaced by its UnicodeEscapeSequence\'s CV, the result must still be a valid Identifier that has the exact same sequence of characters as the original Identifier")]
        public void S7_6_A5_2_T8()
        {
            RunFile(@"S7.6_A5.2_T8.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Unicode")]
        [TestCategory("ECMA 7.6")]
        [TestCategory("ECMA 6")]
        [Description("If a \\UnicodeEscapeSequence sequence were replaced by its UnicodeEscapeSequence\'s CV, the result must still be a valid Identifier that has the exact same sequence of characters as the original Identifier")]
        public void S7_6_A5_2_T9()
        {
            RunFile(@"S7.6_A5.2_T9.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Unicode")]
        [TestCategory("ECMA 7.6")]
        [TestCategory("ECMA 6")]
        [Description("If a UnicodeEscapeSequence put a character into an identifier that would otherwise be illegal, throw SyntaxError")]
        public void S7_6_A5_3_T1()
        {
            RunFile(@"S7.6_A5.3_T1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Unicode")]
        [TestCategory("ECMA 7.6")]
        [TestCategory("ECMA 6")]
        [Description("If a UnicodeEscapeSequence put a character into an identifier that would otherwise be illegal, throw SyntaxError")]
        public void S7_6_A5_3_T2()
        {
            RunFile(@"S7.6_A5.3_T2.js");
        }
    }
}