// <copyright file="ProgramTest.cs">Copyright ©  2018</copyright>
using System;
using AutomationExam_JSalinas;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AutomationExam_JSalinas.Tests
{
    /// <summary>This class contains parameterized unit tests for Program</summary>
    [PexClass(typeof(Program))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class ProgramTest
    {
        /// <summary>Test stub for .ctor()</summary>
        [PexMethod]
        public Program ConstructorTest()
        {
            Program target = new Program();
            return target;
            // TODO: add assertions to method ProgramTest.ConstructorTest()
        }

        /// <summary>Test stub for ExecuteTest()</summary>
        [PexMethod]
        public void ExecuteTestTest([PexAssumeUnderTest]Program target)
        {
            target.ExecuteTest();
            // TODO: add assertions to method ProgramTest.ExecuteTestTest(Program)
        }

        /// <summary>Test stub for Initialize()</summary>
        [PexMethod]
        public void InitializeTest([PexAssumeUnderTest]Program target)
        {
            target.Initialize();
            // TODO: add assertions to method ProgramTest.InitializeTest(Program)
        }
    }
}
