// <auto-generated />
namespace IronJS.Tests.UnitTests.Sputnik.Conformance.TypeConversion.ToNumber
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class ToNumberFromStringTests : SputnikTestFixture
    {
        public ToNumberFromStringTests()
            : base(@"Conformance\09_Type_Conversion\9.3_ToNumber\9.3.1_ToNumber_from_String")
        {
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 9.3.1")]
        [TestCategory("ECMA 15.7.1")]
        [Description("The MV of StringNumericLiteral ::: [empty] is 0")]
        public void S9_3_1_A1()
        {
            RunFile(@"S9.3.1_A1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 9.3.1")]
        [TestCategory("ECMA 15.7.1")]
        [Description("The MV of StrUnsignedDecimalLiteral:::. DecimalDigits is the MV of DecimalDigits times 10<sup><small>-n</small></sup>, where n is the number of characters in DecimalDigits")]
        public void S9_3_1_A10()
        {
            RunFile(@"S9.3.1_A10.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 9.3.1")]
        [TestCategory("ECMA 15.7.1")]
        [Description("The MV of StrUnsignedDecimalLiteral:::. DecimalDigits ExponentPart is the MV of DecimalDigits times 10<sup><small>e-n</small></sup>, where n is the number of characters in DecimalDigits and e is the MV of ExponentPart")]
        public void S9_3_1_A11()
        {
            RunFile(@"S9.3.1_A11.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 9.3.1")]
        [TestCategory("ECMA 15.7.1")]
        [Description("The MV of StrUnsignedDecimalLiteral::: DecimalDigits ExponentPart is the MV of DecimalDigits times 10<sup><small>e</small></sup>, where e is the MV of ExponentPart")]
        public void S9_3_1_A12()
        {
            RunFile(@"S9.3.1_A12.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 9.3.1")]
        [TestCategory("ECMA 15.7.1")]
        [Description("The MV of DecimalDigits ::: DecimalDigits DecimalDigit is (the MV of DecimalDigits times 10) plus the MV of DecimalDigit")]
        public void S9_3_1_A13()
        {
            RunFile(@"S9.3.1_A13.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 9.3.1")]
        [TestCategory("ECMA 15.7.1")]
        [Description("The MV of SignedInteger ::: + DecimalDigits is the MV of DecimalDigits")]
        public void S9_3_1_A14()
        {
            RunFile(@"S9.3.1_A14.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 9.3.1")]
        [TestCategory("ECMA 15.7.1")]
        [Description("The MV of SignedInteger ::: - DecimalDigits is the negative of the MV of DecimalDigits")]
        public void S9_3_1_A15()
        {
            RunFile(@"S9.3.1_A15.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 9.3.1")]
        [TestCategory("ECMA 15.7.1")]
        [Description("The MV of DecimalDigit ::: 0 or of HexDigit ::: 0 is 0")]
        public void S9_3_1_A16()
        {
            RunFile(@"S9.3.1_A16.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 9.3.1")]
        [TestCategory("ECMA 15.7.1")]
        [Description("The MV of DecimalDigit ::: 1 or of HexDigit ::: 1 is 1")]
        public void S9_3_1_A17()
        {
            RunFile(@"S9.3.1_A17.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 9.3.1")]
        [TestCategory("ECMA 15.7.1")]
        [Description("The MV of DecimalDigit ::: 2 or of HexDigit ::: 2 is 2")]
        public void S9_3_1_A18()
        {
            RunFile(@"S9.3.1_A18.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 9.3.1")]
        [TestCategory("ECMA 15.7.1")]
        [Description("The MV of DecimalDigit ::: 3 or of HexDigit ::: 3 is 3")]
        public void S9_3_1_A19()
        {
            RunFile(@"S9.3.1_A19.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 9.3.1")]
        [TestCategory("ECMA 15.7.1")]
        [Description("The MV of StringNumericLiteral ::: StrWhiteSpace is 0")]
        public void S9_3_1_A2()
        {
            RunFile(@"S9.3.1_A2.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 9.3.1")]
        [TestCategory("ECMA 15.7.1")]
        [Description("The MV of DecimalDigit ::: 4 or of HexDigit ::: 4 is 4")]
        public void S9_3_1_A20()
        {
            RunFile(@"S9.3.1_A20.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 9.3.1")]
        [TestCategory("ECMA 15.7.1")]
        [Description("The MV of DecimalDigit ::: 5 or of HexDigit ::: 5 is 5")]
        public void S9_3_1_A21()
        {
            RunFile(@"S9.3.1_A21.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 9.3.1")]
        [TestCategory("ECMA 15.7.1")]
        [Description("The MV of DecimalDigit ::: 6 or of HexDigit ::: 6 is 6")]
        public void S9_3_1_A22()
        {
            RunFile(@"S9.3.1_A22.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 9.3.1")]
        [TestCategory("ECMA 15.7.1")]
        [Description("The MV of DecimalDigit ::: 7 or of HexDigit ::: 7 is 7")]
        public void S9_3_1_A23()
        {
            RunFile(@"S9.3.1_A23.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 9.3.1")]
        [TestCategory("ECMA 15.7.1")]
        [Description("The MV of DecimalDigit ::: 8 or of HexDigit ::: 8 is 8")]
        public void S9_3_1_A24()
        {
            RunFile(@"S9.3.1_A24.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 9.3.1")]
        [TestCategory("ECMA 15.7.1")]
        [Description("The MV of DecimalDigit ::: 9 or of HexDigit ::: 9 is 9")]
        public void S9_3_1_A25()
        {
            RunFile(@"S9.3.1_A25.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 9.3.1")]
        [TestCategory("ECMA 15.7.1")]
        [Description("The MV of HexDigit ::: a or of HexDigit ::: A is 10")]
        public void S9_3_1_A26()
        {
            RunFile(@"S9.3.1_A26.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 9.3.1")]
        [TestCategory("ECMA 15.7.1")]
        [Description("The MV of HexDigit ::: b or of HexDigit ::: B is 11")]
        public void S9_3_1_A27()
        {
            RunFile(@"S9.3.1_A27.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 9.3.1")]
        [TestCategory("ECMA 15.7.1")]
        [Description("The MV of HexDigit ::: c or of HexDigit ::: C is 12")]
        public void S9_3_1_A28()
        {
            RunFile(@"S9.3.1_A28.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 9.3.1")]
        [TestCategory("ECMA 15.7.1")]
        [Description("The MV of HexDigit ::: d or of HexDigit ::: D is 13")]
        public void S9_3_1_A29()
        {
            RunFile(@"S9.3.1_A29.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 9.3.1")]
        [TestCategory("ECMA 15.7.1")]
        [Description("The MV of StringNumericLiteral ::: StrWhiteSpaceopt StrNumericLiteral StrWhiteSpaceopt is the MV of StrNumericLiteral, no matter whether white space is present or not")]
        public void S9_3_1_A3_T1()
        {
            RunFile(@"S9.3.1_A3_T1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 9.3.1")]
        [TestCategory("ECMA 15.7.1")]
        [Description("The MV of StringNumericLiteral ::: StrWhiteSpaceopt StrNumericLiteral StrWhiteSpaceopt is the MV of StrNumericLiteral, no matter whether white space is present or not")]
        public void S9_3_1_A3_T2()
        {
            RunFile(@"S9.3.1_A3_T2.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 9.3.1")]
        [TestCategory("ECMA 15.7.1")]
        [Description("The MV of HexDigit ::: e or of HexDigit ::: E is 14")]
        public void S9_3_1_A30()
        {
            RunFile(@"S9.3.1_A30.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 9.3.1")]
        [TestCategory("ECMA 15.7.1")]
        [Description("The MV of HexDigit ::: f or of HexDigit ::: F is 15")]
        public void S9_3_1_A31()
        {
            RunFile(@"S9.3.1_A31.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 9.3.1")]
        [Description("Once the exact MV for a string numeric literal has been determined, it is then rounded to a value of the Number type with 20 significant digits by replacing each significant digit after the 20th with a 0 digit or the number value")]
        public void S9_3_1_A32()
        {
            RunFile(@"S9.3.1_A32.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 9.3.1")]
        [TestCategory("ECMA 15.7.1")]
        [Description("The MV of StrDecimalLiteral::: + StrUnsignedDecimalLiteral is the MV of StrUnsignedDecimalLiteral")]
        public void S9_3_1_A4_T1()
        {
            RunFile(@"S9.3.1_A4_T1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 9.3.1")]
        [TestCategory("ECMA 15.7.1")]
        [Description("The MV of StrDecimalLiteral::: + StrUnsignedDecimalLiteral is the MV of StrUnsignedDecimalLiteral")]
        public void S9_3_1_A4_T2()
        {
            RunFile(@"S9.3.1_A4_T2.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 9.3.1")]
        [TestCategory("ECMA 15.7.1")]
        [Description("The MV of StrDecimalLiteral::: - StrUnsignedDecimalLiteral is the negative of the MV of StrUnsignedDecimalLiteral. (the negative of this 0 is also 0)")]
        public void S9_3_1_A5_T1()
        {
            RunFile(@"S9.3.1_A5_T1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 9.3.1")]
        [TestCategory("ECMA 15.7.1")]
        [Description("The MV of StrDecimalLiteral::: - StrUnsignedDecimalLiteral is the negative of the MV of StrUnsignedDecimalLiteral. (the negative of this 0 is also 0)")]
        public void S9_3_1_A5_T2()
        {
            RunFile(@"S9.3.1_A5_T2.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 9.3.1")]
        [TestCategory("ECMA 15.7.1")]
        [Description("The MV of StrDecimalLiteral::: - StrUnsignedDecimalLiteral is the negative of the MV of StrUnsignedDecimalLiteral. (the negative of this 0 is also 0)")]
        public void S9_3_1_A5_T3()
        {
            RunFile(@"S9.3.1_A5_T3.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 9.3.1")]
        [TestCategory("ECMA 15.7.1")]
        [Description("The MV of StrUnsignedDecimalLiteral::: Infinity is 10<sup><small>10000</small></sup> (a value so large that it will round to <b><tt>+&infin")]
        public void S9_3_1_A6_T1()
        {
            RunFile(@"S9.3.1_A6_T1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 9.3.1")]
        [TestCategory("ECMA 15.7.1")]
        [Description("The MV of StrUnsignedDecimalLiteral::: Infinity is 10<sup><small>10000</small></sup> (a value so large that it will round to <b><tt>+&infin")]
        public void S9_3_1_A6_T2()
        {
            RunFile(@"S9.3.1_A6_T2.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 9.3.1")]
        [TestCategory("ECMA 15.7.1")]
        [Description("The MV of StrUnsignedDecimalLiteral::: DecimalDigits. DecimalDigits is the MV of the first DecimalDigits plus the MV of the second DecimalDigits times 10<sup><small>-n</small></sup>, where n is the number of characters in the second DecimalDigits")]
        public void S9_3_1_A7()
        {
            RunFile(@"S9.3.1_A7.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 9.3.1")]
        [TestCategory("ECMA 15.7.1")]
        [Description("The MV of StrUnsignedDecimalLiteral::: DecimalDigits. ExponentPart is the MV of DecimalDigits times 10<sup><small>e</small></sup> , where e is the MV of ExponentPart")]
        public void S9_3_1_A8()
        {
            RunFile(@"S9.3.1_A8.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 9.3.1")]
        [TestCategory("ECMA 15.7.1")]
        [Description("The MV of StrUnsignedDecimalLiteral::: DecimalDigits. DecimalDigits ExponentPart is (the MV of the first DecimalDigits plus (the MV of the second DecimalDigits times 10<sup><small>-n</small></sup>)) times 10<sup><small>e</small></sup>, where n is the number of characters in the second DecimalDigits and e is the MV of ExponentPart")]
        public void S9_3_1_A9()
        {
            RunFile(@"S9.3.1_A9.js");
        }
    }
}