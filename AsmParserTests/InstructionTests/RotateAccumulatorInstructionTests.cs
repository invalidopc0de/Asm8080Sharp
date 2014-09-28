using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Asm8080Sharp.Instructions;

namespace AsmParserTests
{
    [TestClass]
    public class RotateAccumulatorInstructionTests
    {
        [TestMethod]
        public void testRLC()
        {
            List<String> testWords = new List<string>();
            testWords.Add("rlc");
            RotateAccumulatorInstruction testCommand = new RotateAccumulatorInstruction(testWords);
            Assert.AreEqual("00000111", testCommand.getBinaryCode());
        }

        [TestMethod]
        public void testRRC()
        {
            List<String> testWords = new List<string>();
            testWords.Add("rrc");
            RotateAccumulatorInstruction testCommand = new RotateAccumulatorInstruction(testWords);
            Assert.AreEqual("00001111", testCommand.getBinaryCode());
        }

        [TestMethod]
        public void testRAL()
        {
            List<String> testWords = new List<string>();
            testWords.Add("ral");
            RotateAccumulatorInstruction testCommand = new RotateAccumulatorInstruction(testWords);
            Assert.AreEqual("00010111", testCommand.getBinaryCode());
        }

        [TestMethod]
        public void testRAR()
        {
            List<String> testWords = new List<string>();
            testWords.Add("rar");
            RotateAccumulatorInstruction testCommand = new RotateAccumulatorInstruction(testWords);
            Assert.AreEqual("00011111", testCommand.getBinaryCode());
        }
    }
}
