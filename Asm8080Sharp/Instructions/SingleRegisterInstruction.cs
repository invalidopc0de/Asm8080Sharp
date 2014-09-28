using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asm8080Sharp.Instructions
{
    public class SingleRegisterInstruction : AbstractInstruction
    {
        public SingleRegisterInstruction(List<String> words)
        {
            this.m_words = words;
        }

        public override string[] getMnemonics()
        {
            return new String[] { "inr", "dcr", "cma", "daa" };
        }

        public override string getBinaryCode()
        {
            String binaryString = "";
            String mnemonic = m_words[0];
            if ("inr" == mnemonic)
            {
                binaryString += "00" + Utils.getRegisterString(m_words[1]) + "100";
            }
            else if ("dcr" == mnemonic)
            {
                binaryString += "00" + Utils.getRegisterString(m_words[1]) + "101";
            }
            else if ("cma" == mnemonic)
            {
                binaryString += "00101111";
            } 
            else if ("daa" == mnemonic)
            {
                binaryString += "00100111";
            }
            else
            {
                throw new NotSupportedException("Unsupported Instruction");
            }

            return binaryString;
        }
    }
}
