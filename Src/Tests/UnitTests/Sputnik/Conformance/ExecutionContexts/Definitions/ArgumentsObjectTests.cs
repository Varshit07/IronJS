// <auto-generated />
namespace IronJS.Tests.UnitTests.Sputnik.Conformance.ExecutionContexts.Definitions
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class ArgumentsObjectTests : SputnikTestFixture
    {
        public ArgumentsObjectTests()
            : base(@"Conformance\10_Execution_Contexts\10.1_Definitions\10.1.8_Arguments_Object")
        {
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 10.1.8")]
        [Description("When control enters an execution context for function code, an arguments object is created and initialised")]
        public void S10_1_8_A1()
        {
            RunFile(@"S10.1.8_A1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 10.1.8")]
        [Description("The value of the internal [[Prototype]] property of the created arguments object is the original Object prototype object, the one that is the initial value of Object.prototype")]
        public void S10_1_8_A2()
        {
            RunFile(@"S10.1.8_A2.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 10.1.8")]
        [Description("A property is created with name callee with property attributes { DontEnum } and no others")]
        public void S10_1_8_A3_T1()
        {
            RunFile(@"S10.1.8_A3_T1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 10.1.8")]
        [Description("A property is created with name callee with property attributes { DontEnum } and no others")]
        public void S10_1_8_A3_T2()
        {
            RunFile(@"S10.1.8_A3_T2.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 10.1.8")]
        [Description("A property is created with name callee with property attributes { DontEnum } and no others")]
        public void S10_1_8_A3_T3()
        {
            RunFile(@"S10.1.8_A3_T3.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 10.1.8")]
        [Description("A property is created with name callee with property attributes { DontEnum } and no others")]
        public void S10_1_8_A3_T4()
        {
            RunFile(@"S10.1.8_A3_T4.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 10.1.8")]
        [Description("The initial value of the created property callee is the  Function object being executed")]
        public void S10_1_8_A4()
        {
            RunFile(@"S10.1.8_A4.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 10.1.8")]
        [Description("A property is created with name length with property attributes { DontEnum } and no others")]
        public void S10_1_8_A5_T1()
        {
            RunFile(@"S10.1.8_A5_T1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 10.1.8")]
        [Description("A property is created with name length with property attributes { DontEnum } and no others")]
        public void S10_1_8_A5_T2()
        {
            RunFile(@"S10.1.8_A5_T2.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 10.1.8")]
        [Description("A property is created with name length with property attributes { DontEnum } and no others")]
        public void S10_1_8_A5_T3()
        {
            RunFile(@"S10.1.8_A5_T3.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 10.1.8")]
        [Description("A property is created with name length with property attributes { DontEnum } and no others")]
        public void S10_1_8_A5_T4()
        {
            RunFile(@"S10.1.8_A5_T4.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 10.1.8")]
        [Description("The initial value of the created property length is the number of actual parameter values supplied by the caller")]
        public void S10_1_8_A6()
        {
            RunFile(@"S10.1.8_A6.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 10.1.8")]
        [Description("Get arguments of function")]
        public void S10_1_8_A7()
        {
            RunFile(@"S10.1.8_A7.js");
        }
    }
}