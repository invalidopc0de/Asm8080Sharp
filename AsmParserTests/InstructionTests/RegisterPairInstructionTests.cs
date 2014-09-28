using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Asm8080Sharp.Instructions;

namespace AsmParserTests
{
    [TestClass]
    public class RegisterPairInstructionTests
    {
        [TestMethod]
        public void testPUSH()
        {
            List<String> testWords = new List<string>();
            testWords.Add("push");
            testWords.Add("de");
            RegisterPairInstruction testCommand = new RegisterPairInstruction(testWords);
            Assert.AreEqual("11010101", testCommand.getBinaryCode());
        }

        [TestMethod]
        public void testPOP()
        {
            List<String> testWords = new List<string>();
            testWords.Add("pop");
            testWords.Add("de");
            RegisterPairInstruction testCommand = new RegisterPairInstruction(testWords);
            Assert.AreEqual("11010001", testCommand.getBinaryCode());
        }

        [TestMethod]
        public void testDAD()
        {
            List<String> testWords = new List<string>();
            testWords.Add("dad");
            testWords.Add("de");
            RegisterPairInstruction testCommand = new RegisterPairInstruction(testWords);
            Assert.AreEqual("00011001", testCommand.getBinaryCode());
        }

        [TestMethod]
        public void testINX()
        {
            List<String> testWords = new List<string>();
            testWords.Add("inx");
            testWords.Add("de");
            RegisterPairInstruction testCommand = new RegisterPairInstruction(testWords);
            Assert.AreEqual("00010011", testCommand.getBinaryCode());
        }

        [TestMethod]
        public void testDCX()
        {
            List<String> testWords = new List<string>();
            testWords.Add("dcx");
            testWords.Add("de");
            RegisterPairInstruction testCommand = new RegisterPairInstruction(testWords);
            Assert.AreEqual("00011011", testCommand.getBinaryCode());
        }

        [TestMethod]
        public void testXCHG()
        {
            List<String> testWords = new List<string>();
            testWords.Add("xchg");
            RegisterPairInstruction testCommand = new RegisterPairInstruction(testWords);
            Assert.AreEqual("11101011", testCommand.getBinaryCode());
        }

        [TestMethod]
        public void testXTHL()
        {
            List<String> testWords = new List<string>();
            testWords.Add("xthl");
            RegisterPairInstruction testCommand = new RegisterPairInstruction(testWords);
            Assert.AreEqual("11100011", testCommand.getBinaryCode());
        }

        [TestMethod]
        public void testSPHL()
        {
            List<String> testWords = new List<string>();
            testWords.Add("sphl");
            RegisterPairInstruction testCommand = new RegisterPairInstruction(testWords);
            Assert.AreEqual("11111001", testCommand.getBinaryCode());
        }
    }
}
