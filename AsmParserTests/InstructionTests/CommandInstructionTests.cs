using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Asm8080Sharp.Instructions;
using System.Collections.Generic;

namespace AsmParserTests
{
    [TestClass]
    public class CommandInstructionTests
    {
        [TestMethod]
        public void testIN()
        {
            List<String> testWords = new List<string>();
            testWords.Add("in");
            testWords.Add("00000000");
            CommandInstruction testCommand = new CommandInstruction(testWords);
            Assert.AreEqual("1101101100000000", testCommand.getBinaryCode());
        }

        [TestMethod]
        public void testOUT()
        {
            List<String> testWords = new List<string>();
            testWords.Add("out");
            testWords.Add("00000000");
            CommandInstruction testCommand = new CommandInstruction(testWords);
            Assert.AreEqual("1101001100000000", testCommand.getBinaryCode());
        }

        [TestMethod]
        public void testEI()
        {
            List<String> testWords = new List<string>();
            testWords.Add("ei");
            CommandInstruction testCommand = new CommandInstruction(testWords);
            Assert.AreEqual("11111011", testCommand.getBinaryCode());
        }

        [TestMethod]
        public void testDI()
        {
            List<String> testWords = new List<string>();
            testWords.Add("di");
            CommandInstruction testCommand = new CommandInstruction(testWords);
            Assert.AreEqual("11110011", testCommand.getBinaryCode());
        }

        [TestMethod]
        public void testHLT()
        {
            List<String> testWords = new List<string>();
            testWords.Add("hlt");
            CommandInstruction testCommand = new CommandInstruction(testWords);
            Assert.AreEqual("01110110", testCommand.getBinaryCode());
        }

        [TestMethod]
        public void testRST()
        {
            List<String> testWords = new List<string>();
            testWords.Add("rst");
            testWords.Add("001");
            CommandInstruction testCommand = new CommandInstruction(testWords);
            Assert.AreEqual("11001111", testCommand.getBinaryCode());
        }

        [TestMethod]
        public void testCMC()
        {
            List<String> testWords = new List<string>();
            testWords.Add("cmc");
            CommandInstruction testCommand = new CommandInstruction(testWords);
            Assert.AreEqual("00111111", testCommand.getBinaryCode());
        }

        [TestMethod]
        public void testSTC()
        {
            List<String> testWords = new List<string>();
            testWords.Add("stc");
            CommandInstruction testCommand = new CommandInstruction(testWords);
            Assert.AreEqual("00110111", testCommand.getBinaryCode());
        }

        [TestMethod]
        public void testNOP()
        {
            List<String> testWords = new List<string>();
            testWords.Add("nop");
            CommandInstruction testCommand = new CommandInstruction(testWords);
            Assert.AreEqual("00000000", testCommand.getBinaryCode());
        }
    }
}
