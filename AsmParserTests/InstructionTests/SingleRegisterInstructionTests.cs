using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Asm8080Sharp.Instructions;

namespace AsmParserTests
{
    [TestClass]
    public class SingleRegisterInstructionTests
    {
        [TestMethod]
        public void testINR()
        {
            List<String> testWords = new List<string>();
            testWords.Add("inr");
            testWords.Add("e");
            SingleRegisterInstruction testCommand = new SingleRegisterInstruction(testWords);
            Assert.AreEqual("00011100", testCommand.getBinaryCode());
        }

        [TestMethod]
        public void testDCR()
        {
            List<String> testWords = new List<string>();
            testWords.Add("dcr");
            testWords.Add("e");
            SingleRegisterInstruction testCommand = new SingleRegisterInstruction(testWords);
            Assert.AreEqual("00011101", testCommand.getBinaryCode());
        }

        [TestMethod]
        public void testCMA()
        {
            List<String> testWords = new List<string>();
            testWords.Add("cma");
            SingleRegisterInstruction testCommand = new SingleRegisterInstruction(testWords);
            Assert.AreEqual("00101111", testCommand.getBinaryCode());
        }

        [TestMethod]
        public void testDAA()
        {
            List<String> testWords = new List<string>();
            testWords.Add("daa");
            SingleRegisterInstruction testCommand = new SingleRegisterInstruction(testWords);
            Assert.AreEqual("00100111", testCommand.getBinaryCode());
        }
    }
}
