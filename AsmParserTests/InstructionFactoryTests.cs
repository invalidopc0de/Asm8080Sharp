using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Asm8080Sharp.Instructions;
using Asm8080Sharp;

namespace AsmParserTests
{
    [TestClass]
    public class InstructionFactoryTests
    {
        [TestMethod]
        public void testCreateInstruction()
        {
            List<String> testWords = new List<String>();
            testWords.Add("nop");

            AbstractInstruction instructionResult = InstructionFactory.createInstruction(testWords);
            Assert.IsInstanceOfType(instructionResult, typeof(CommandInstruction));
            Assert.AreEqual("00000000", instructionResult.getBinaryCode());
        }
    }
}
