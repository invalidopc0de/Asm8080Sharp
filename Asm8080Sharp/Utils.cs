using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asm8080Sharp
{
    public static class Utils
    {
        public static String getRegisterString(string register)
        {
            Dictionary<String, String> registers = new Dictionary<String, String>();
            registers.Add("b", "000");
            registers.Add("c", "001");
            registers.Add("d", "010");
            registers.Add("e", "011");
            registers.Add("h", "100");
            registers.Add("l", "101");
            registers.Add("mem", "110");
            registers.Add("acc", "111");

            return registers[register];
        }

        public static String getRegisterPairString(string register)
        {
            Dictionary<String, String> registerPairs = new Dictionary<String, String>();
            registerPairs.Add("bc", "00");
            registerPairs.Add("de", "01");
            registerPairs.Add("hl", "10");
            registerPairs.Add("sp", "11");

            return registerPairs[register];
        }
    }
}
