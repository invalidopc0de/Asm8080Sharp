using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Asm8080Sharp;

namespace AsmParserTests
{
    [TestClass]
    public class UtilsTests
    {
        [TestMethod]
        public void testRegisterString()
        {
            Assert.AreEqual("000", Utils.getRegisterString("b"));
            Assert.AreEqual("001", Utils.getRegisterString("c"));
            Assert.AreEqual("010", Utils.getRegisterString("d"));
            Assert.AreEqual("011", Utils.getRegisterString("e"));
            Assert.AreEqual("100", Utils.getRegisterString("h"));
            Assert.AreEqual("101", Utils.getRegisterString("l"));
            Assert.AreEqual("110", Utils.getRegisterString("mem"));
            Assert.AreEqual("111", Utils.getRegisterString("acc"));
        }

        [TestMethod]
        public void testRegisterPairString()
        {
            Assert.AreEqual("00", Utils.getRegisterPairString("bc"));
            Assert.AreEqual("01", Utils.getRegisterPairString("de"));
            Assert.AreEqual("10", Utils.getRegisterPairString("hl"));
            Assert.AreEqual("11", Utils.getRegisterPairString("sp"));
        }
    }
}
