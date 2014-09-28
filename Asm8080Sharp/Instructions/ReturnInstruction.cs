using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asm8080Sharp.Instructions
{
    public class ReturnInstruction : AbstractInstruction
    {
        public ReturnInstruction(List<String> words)
        {
            this.m_words = words;
        }

        public override string[] getMnemonics()
        {
            return new String[] { "ret", "rc", "rnc", "rz", "rnz", "rm", "rp", "rpe", "rpo"};
        }

        public override string getBinaryCode()
        {
            String binaryString = "";
            String mnemonic = m_words[0];
            if ("ret" == mnemonic)
            {
                binaryString += "11001001";
            }
            else if ("rc" == mnemonic)
            {
                binaryString += "11011000";
            }
            else if ("rnc" == mnemonic)
            {
                binaryString += "11010000";
            }
            else if ("rz" == mnemonic)
            {
                binaryString += "11001000";
            }
            else if ("rnz" == mnemonic)
            {
                binaryString += "11000000";
            }
            else if ("rm" == mnemonic)
            {
                binaryString += "11111000";
            }
            else if ("rp" == mnemonic)
            {
                binaryString += "11110000";
            }
            else if ("rpe" == mnemonic)
            {
                binaryString += "11101000";
            }
            else if ("rpo" == mnemonic)
            {
                binaryString += "11100000";
            }
            else
            {
                throw new NotSupportedException("Unsupported Instruction");
            }

            return binaryString;
        }
    }
}
