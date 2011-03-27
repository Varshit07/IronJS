// <auto-generated />
namespace IronJS.Tests.UnitTests.Sputnik.ImplementationDiagnostics
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class ImplementationDiagnosticsTests : SputnikTestFixture
    {
        public ImplementationDiagnosticsTests()
            : base(@"Implementation_Diagnostics")
        {
        }

        [TestMethod]
        [TestCategory("Sputnik Implementation_Diagnostics")]
        [TestCategory("ECMA 11.4.3")]
        [Description("Result of typeof from RegExp is \"function\"")]
        public void S11_4_3_D1_1()
        {
            RunFile(@"S11.4.3_D1.1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Implementation_Diagnostics")]
        [TestCategory("ECMA 11.4.3")]
        [Description("Result of typeof from RegExp is \"object\"")]
        public void S11_4_3_D1_2()
        {
            RunFile(@"S11.4.3_D1.2.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Implementation_Diagnostics")]
        [TestCategory("ECMA 12.6.4")]
        [Description("If new properties are added to the object being enumerated during enumeration, the newly added properties to be visited in the active enumeration")]
        public void S12_6_4_D1()
        {
            RunFile(@"S12.6.4_D1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Implementation_Diagnostics")]
        [TestCategory("ECMA 13.2.2")]
        [Description("function declaration inside of \"with\" statement is a fuction declaration inside of current execution context")]
        public void S13_2_2_D20_T1()
        {
            RunFile(@"S13.2.2_D20_T1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Implementation_Diagnostics")]
        [TestCategory("ECMA 13.2.2")]
        [Description("function declaration inside of \"with\" statement is a fuction declaration inside of current execution context")]
        public void S13_2_2_D20_T2()
        {
            RunFile(@"S13.2.2_D20_T2.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Implementation_Diagnostics")]
        [TestCategory("ECMA 13.2.2")]
        [Description("function declaration inside of \"with\" statement is a fuction declaration inside of current execution context")]
        public void S13_2_2_D20_T3()
        {
            RunFile(@"S13.2.2_D20_T3.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Implementation_Diagnostics")]
        [TestCategory("ECMA 13.2.2")]
        [Description("function declaration inside of \"with\" statement is a fuction declaration inside of current execution context")]
        public void S13_2_2_D20_T4()
        {
            RunFile(@"S13.2.2_D20_T4.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Implementation_Diagnostics")]
        [TestCategory("ECMA 13.2.2")]
        [Description("function declaration inside of \"with\" statement is a fuction declaration inside of current execution context")]
        public void S13_2_2_D20_T5()
        {
            RunFile(@"S13.2.2_D20_T5.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Implementation_Diagnostics")]
        [TestCategory("ECMA 13.2.2")]
        [Description("function declaration inside of \"with\" statement is a fuction declaration inside of current execution context")]
        public void S13_2_2_D20_T6()
        {
            RunFile(@"S13.2.2_D20_T6.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Implementation_Diagnostics")]
        [TestCategory("ECMA 13.2.2")]
        [Description("function declaration inside of \"with\" statement is a fuction declaration inside of current execution context")]
        public void S13_2_2_D20_T7()
        {
            RunFile(@"S13.2.2_D20_T7.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Implementation_Diagnostics")]
        [TestCategory("ECMA 13.2.2")]
        [Description("function declaration inside of \"with\" statement is a fuction declaration inside of current execution context")]
        public void S13_2_2_D20_T8()
        {
            RunFile(@"S13.2.2_D20_T8.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Implementation_Diagnostics")]
        [TestCategory("ECMA 13.2")]
        [Description("Create a new native ECMAScript object, not joined the already exists object that was created by an earlier call to this section\'s algorithm, and if that call to this section\'s algorithm was given a FunctionBody that equated to the FunctionBody given now")]
        public void S13_2_D1_1()
        {
            RunFile(@"S13.2_D1.1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Implementation_Diagnostics")]
        [TestCategory("ECMA 13.2")]
        [Description("Create a new native ECMAScript object, joined the already exists object that was created by an earlier call to this section\'s algorithm, and if that call to this section\'s algorithm was given a FunctionBody that equated to the FunctionBody given now")]
        public void S13_2_D1_2()
        {
            RunFile(@"S13.2_D1.2.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Implementation_Diagnostics")]
        [TestCategory("ECMA 13,12.10")]
        [Description("Function declaration inside of \"with\" statement interprets as function expression")]
        public void S13_D1_T1()
        {
            RunFile(@"S13_D1_T1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Implementation_Diagnostics")]
        [TestCategory("ECMA 14")]
        [Description("Function declaration may be in unreacheable fragment of program")]
        public void S14_D1_T1()
        {
            RunFile(@"S14_D1_T1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Implementation_Diagnostics")]
        [TestCategory("ECMA 14")]
        [Description("Function declaration may be inside of try-catch block ")]
        public void S14_D4_T1()
        {
            RunFile(@"S14_D4_T1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Implementation_Diagnostics")]
        [TestCategory("ECMA 14")]
        [Description("Function declaration may be inside of try-catch block ")]
        public void S14_D4_T2()
        {
            RunFile(@"S14_D4_T2.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Implementation_Diagnostics")]
        [TestCategory("ECMA 14")]
        [Description("Function declaration may be inside of try-catch block ")]
        public void S14_D4_T3()
        {
            RunFile(@"S14_D4_T3.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Implementation_Diagnostics")]
        [TestCategory("ECMA 14")]
        [Description("Function declaration may be inside of while block ")]
        public void S14_D6_T1()
        {
            RunFile(@"S14_D6_T1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Implementation_Diagnostics")]
        [TestCategory("ECMA 14")]
        [Description("Function declaration may be inside of while block ")]
        public void S14_D6_T2()
        {
            RunFile(@"S14_D6_T2.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Implementation_Diagnostics")]
        [TestCategory("ECMA 14")]
        [Description("Function declaration may be inside of \"with\" block ")]
        public void S14_D7()
        {
            RunFile(@"S14_D7.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Implementation_Diagnostics")]
        [TestCategory("ECMA 15.1.2.2")]
        [TestCategory("ECMA 9.8")]
        [Description("If the length of S is at least 1 and the first character of S is 0, then R = 8")]
        public void S15_1_2_2_D1_1()
        {
            RunFile(@"S15.1.2.2_D1.1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Implementation_Diagnostics")]
        [TestCategory("ECMA 15.1.2.2")]
        [TestCategory("ECMA 9.8")]
        [Description("If the length of S is at least 1 and the first character of S is 0, then R = 10")]
        public void S15_1_2_2_D1_2()
        {
            RunFile(@"S15.1.2.2_D1.2.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Implementation_Diagnostics")]
        [TestCategory("ECMA 15.10.6.3")]
        [Description("RegeExp.prototype.test calling does not change lastIndex property")]
        public void S15_10_6_3_D1_T1()
        {
            RunFile(@"S15.10.6.3_D1_T1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Implementation_Diagnostics")]
        [TestCategory("ECMA 15.4.4.12")]
        [Description("If a function is given fewer arguments than the function is specified to require, the function shall behave exactly as if it had been given sufficient additional arguments, each such argument being the undefined value")]
        public void S15_4_4_12_D1_5_T1()
        {
            RunFile(@"S15.4.4.12_D1.5_T1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Implementation_Diagnostics")]
        [TestCategory("ECMA 15.4.4.12")]
        [Description("If a function is given fewer arguments than the function is specified to require, the function shall behave exactly as if it had been given sufficient additional arguments, each such argument being the undefined value")]
        public void S15_4_4_12_D1_5_T2()
        {
            RunFile(@"S15.4.4.12_D1.5_T2.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Implementation_Diagnostics")]
        [TestCategory("ECMA 15.5.2")]
        [Description("String constructor can accept many arguments. But only the first will be accounted ")]
        public void S15_5_2_D1_T1()
        {
            RunFile(@"S15.5.2_D1_T1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Implementation_Diagnostics")]
        [TestCategory("ECMA 15.5.2")]
        [Description("String constructor can accept many arguments. But only the first will be accounted ")]
        public void S15_5_2_D1_T2()
        {
            RunFile(@"S15.5.2_D1_T2.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Implementation_Diagnostics")]
        [TestCategory("ECMA 15.5.2")]
        [Description("String constructor can\'t accept many arguments. When more than one is provided exception throws ")]
        public void S15_5_2_D2()
        {
            RunFile(@"S15.5.2_D2.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Implementation_Diagnostics")]
        [TestCategory("ECMA 15.5.4.11")]
        [Description("String.prototype.replace (searchValue, replaceValue) accepts only two arguments")]
        public void S15_5_4_11_D1_1_T1()
        {
            RunFile_ExpectException(@"S15.5.4.11_D1.1_T1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Implementation_Diagnostics")]
        [TestCategory("ECMA 15.5.4.11")]
        [Description("String.prototype.replace (searchValue, replaceValue) accepts only two arguments")]
        public void S15_5_4_11_D1_1_T2()
        {
            RunFile_ExpectException(@"S15.5.4.11_D1.1_T2.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Implementation_Diagnostics")]
        [TestCategory("ECMA 15.5.4.11")]
        [Description("String.prototype.replace (searchValue, replaceValue) accepts only two arguments")]
        public void S15_5_4_11_D1_1_T3()
        {
            RunFile_ExpectException(@"S15.5.4.11_D1.1_T3.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Implementation_Diagnostics")]
        [TestCategory("ECMA 15.5.4.11")]
        [Description("String.prototype.replace (searchValue, replaceValue) accepts only two arguments")]
        public void S15_5_4_11_D1_1_T4()
        {
            RunFile_ExpectException(@"S15.5.4.11_D1.1_T4.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Implementation_Diagnostics")]
        [TestCategory("ECMA 15.7.4.5")]
        [Description("If f < 0 or f > 20, throw a RangeError exception")]
        public void S15_7_4_5_A1_2_D02()
        {
            RunFile(@"S15.7.4.5_A1.2_D02.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Implementation_Diagnostics")]
        [TestCategory("ECMA 15.7.4.5")]
        [Description("If f < 0 or f > 20, throw a RangeError exception")]
        public void S15_7_4_5_D1_2_T01()
        {
            RunFile(@"S15.7.4.5_D1.2_T01.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Implementation_Diagnostics")]
        [TestCategory("ECMA 15.9.1.14")]
        [Description("Return an implementation-dependent choice of either ToInteger(Result(2)) or ToInteger(Result(2)) + (+0)")]
        public void S15_9_1_14_D1()
        {
            RunFile(@"S15.9.1.14_D1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Implementation_Diagnostics")]
        [TestCategory("ECMA 8.4")]
        [TestCategory("ECMA 15.5")]
        [TestCategory("ECMA 7.8.4")]
        [Description("Engines implements array like access to string elemenths, when we call squre brackets operator char at position specified returns\r\n*/\r\n\r\nvar __str = \'hail to robots!!!\'")]
        public void S8_4_D1_1()
        {
            RunFile(@"S8.4_D1.1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Implementation_Diagnostics")]
        [TestCategory("ECMA 8.4")]
        [TestCategory("ECMA 7.8.4")]
        [Description("Some engines can implement array like access to string elemenths: Positions are indexed with nonnegative integers")]
        public void S8_4_D1_2()
        {
            RunFile(@"S8.4_D1.2.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Implementation_Diagnostics")]
        [TestCategory("ECMA 8.4")]
        [TestCategory("ECMA 15.5")]
        [TestCategory("ECMA 7.8.4")]
        [Description("Engines implements array like access to string elemenths, Index of element must be nonnegative")]
        public void S8_4_D2_1()
        {
            RunFile_ExpectException(@"S8.4_D2.1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Implementation_Diagnostics")]
        [TestCategory("ECMA 8.4")]
        [TestCategory("ECMA 15.5")]
        [TestCategory("ECMA 7.8.4")]
        [Description("Engines implements array like access to string elemenths, Index of elementh must be less than string length")]
        public void S8_4_D2_2()
        {
            RunFile_ExpectException(@"S8.4_D2.2.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Implementation_Diagnostics")]
        [TestCategory("ECMA 8.4")]
        [TestCategory("ECMA 15.5")]
        [TestCategory("ECMA 7.8.4")]
        [Description("Engines implements array like access to string elemenths, If index of elementh is greater or equals than string length an empty string returns")]
        public void S8_4_D2_3()
        {
            RunFile(@"S8.4_D2.3.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Implementation_Diagnostics")]
        [TestCategory("ECMA 8.4")]
        [TestCategory("ECMA 15.5")]
        [TestCategory("ECMA 7.8.4")]
        [Description("Engines implements array like access to string elemenths, If index of elementh is less than 0 an empty string returns")]
        public void S8_4_D2_4()
        {
            RunFile(@"S8.4_D2.4.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Implementation_Diagnostics")]
        [TestCategory("ECMA 8.4")]
        [TestCategory("ECMA 15.5")]
        [TestCategory("ECMA 7.8.4")]
        [Description("Engines implements array like access to string elemenths, If index of elementh is less than 0 an undefined returns")]
        public void S8_4_D2_5()
        {
            RunFile(@"S8.4_D2.5.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Implementation_Diagnostics")]
        [TestCategory("ECMA 8.4")]
        [TestCategory("ECMA 15.5")]
        [TestCategory("ECMA 7.8.4")]
        [Description("Engines implements array like access to string elemenths, If index of elementh is greater or equals than string length an undefined returns")]
        public void S8_4_D2_6()
        {
            RunFile(@"S8.4_D2.6.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Implementation_Diagnostics")]
        [TestCategory("ECMA 8.4")]
        [TestCategory("ECMA 15.5")]
        [TestCategory("ECMA 7.8.4")]
        [Description("Engines implements array like access to string elemenths, If index of element must is equal to -1 an length of string returns")]
        public void S8_4_D2_7()
        {
            RunFile(@"S8.4_D2.7.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Implementation_Diagnostics")]
        [TestCategory("ECMA 8.6")]
        [Description("An Object may have up to 4096 properties")]
        public void S8_6_D1_1()
        {
            RunFile(@"S8.6_D1.1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Implementation_Diagnostics")]
        [TestCategory("ECMA 8.6")]
        [Description("An Object may have up to 16384 properties ")]
        public void S8_6_D1_2()
        {
            RunFile(@"S8.6_D1.2.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Implementation_Diagnostics")]
        [TestCategory("ECMA 8.6")]
        [Description("An Object may have up to 65536 properties ")]
        public void S8_6_D1_3()
        {
            RunFile(@"S8.6_D1.3.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Implementation_Diagnostics")]
        [TestCategory("ECMA 8.6")]
        [Description("An Object may have up to 262144 properties ")]
        public void S8_6_D1_4()
        {
            RunFile(@"S8.6_D1.4.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Implementation_Diagnostics")]
        [TestCategory("ECMA 8.8")]
        [Description("Arguments list may have up to 512 elements")]
        public void S8_8_D1_1()
        {
            RunFile(@"S8.8_D1.1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Implementation_Diagnostics")]
        [TestCategory("ECMA 8.8")]
        [Description("Arguments list may have up to 2048 elements")]
        public void S8_8_D1_2()
        {
            RunFile(@"S8.8_D1.2.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Implementation_Diagnostics")]
        [TestCategory("ECMA 8.8")]
        [Description("Arguments list may have up to 8192 elements")]
        public void S8_8_D1_3()
        {
            RunFile(@"S8.8_D1.3.js");
        }
    }
}