// <auto-generated />
namespace IronJS.Tests.UnitTests.Sputnik.Conformance.ExecutionContexts.Definitions
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class DefinitionsTests : SputnikTestFixture
    {
        public DefinitionsTests()
            : base(@"Conformance\10_Execution_Contexts\10.1_Definitions")
        {
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 10.1.1")]
        [Description("Program functions are defined in source text by a FunctionDeclaration or created dynamically either  by using a FunctionExpression or by using the built-in Function object as a constructor")]
        public void S10_1_1_A1_T1()
        {
            RunFile(@"S10.1.1_A1_T1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 10.1.1")]
        [Description("Program functions are defined in source text by a FunctionDeclaration or created dynamically either  by using a FunctionExpression or by using the built-in Function object as a constructor")]
        public void S10_1_1_A1_T2()
        {
            RunFile(@"S10.1.1_A1_T2.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 10.1.1")]
        [Description("Program functions are defined in source text by a FunctionDeclaration or created dynamically either  by using a FunctionExpression or by using the built-in Function object as a constructor")]
        public void S10_1_1_A1_T3()
        {
            RunFile(@"S10.1.1_A1_T3.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 10.1.1")]
        [Description("There are two types of Function objects. Internal functions are built-in objects of the language, such as parseInt and Math.exp")]
        public void S10_1_1_A2_T1()
        {
            RunFile(@"S10.1.1_A2_T1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 10.1.6")]
        [Description("The activation object is initialised with a property with name arguments and attributes {DontDelete}")]
        public void S10_1_6_A1_T1()
        {
            RunFile(@"S10.1.6_A1_T1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 10.1.6")]
        [Description("The activation object is initialised with a property with name arguments and attributes {DontDelete}")]
        public void S10_1_6_A1_T2()
        {
            RunFile(@"S10.1.6_A1_T2.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 10.1.6")]
        [Description("The activation object is initialised with a property with name arguments and attributes {DontDelete}")]
        public void S10_1_6_A1_T3()
        {
            RunFile(@"S10.1.6_A1_T3.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 10.1.7")]
        [Description("The this value associated with an executioncontext is immutable")]
        public void S10_1_7_A1_T1()
        {
            RunFile(@"S10.1.7_A1_T1.js");
        }
    }
}