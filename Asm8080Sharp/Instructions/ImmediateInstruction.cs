using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asm8080Sharp.Instructions
{
    public class ImmediateInstruction : AbstractInstruction
    {
        
        public ImmediateInstruction(List<String> words)
        {
            this.m_words = words;
        }

        public override string[] getMnemonics()
        {
            return new String[] { "lxi", "mvi", "adi", "aci", "sui", "sbi", "ani", "xri", "ori", "cpi" };
        }

        public override string getBinaryCode()
        {
            String binaryString = "";
            String mnemonic = m_words[0];
            if ("lxi" == mnemonic)
            {
                binaryString += "00" + Utils.getRegisterPairString(m_words[1]) + "0001";
                binaryString += m_words[1];
                binaryString += m_words[2];
            }
            else if ("mvi" == mnemonic)
            {
                binaryString += "00" + Utils.getRegisterString(m_words[1]) + "110";
                binaryString += m_words[1];
            }
            else if ("adi" == mnemonic)
            {
                binaryString += "11000110";
                binaryString += m_words[1];
            }
            else if ("aci" == mnemonic)
            {
                binaryString += "11001110";
                binaryString += m_words[1];
            }
            else if ("sui" == mnemonic)
            {
                binaryString += "1101010";
                binaryString += m_words[1];
            }
            else if ("sbi" == mnemonic)
            {
                binaryString += "11011110";
                binaryString += m_words[1];
            }
            else if ("ani" == mnemonic)
            {
                binaryString += "11100110";
                binaryString += m_words[1];
            }
            else if ("xri" == mnemonic)
            {
                binaryString += "11101110";
                binaryString += m_words[1];
            }
            else if ("ori" == mnemonic)
            {
                binaryString += "11110110";
                binaryString += m_words[1];
            }
            else if ("cpi" == mnemonic)
            {
                binaryString += "11111110";
                binaryString += m_words[1];
            } 
            else
            {
                throw new NotSupportedException("Unsupported Instruction");
            }

            return binaryString;
        }

    }
}
