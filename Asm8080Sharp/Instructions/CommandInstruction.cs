using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asm8080Sharp.Instructions
{
    public class CommandInstruction : AbstractInstruction
    {
        public CommandInstruction(List<String> words)
        {
            this.m_words = words;
        }
        public override String[] getMnemonics()
        {
            return new String[] {"in", "out", "ei", "di", "hlt", "rst", "cmc", "stc", "nop"};
        }

        public override String getBinaryCode()
        {
            String binaryString = "";
            String mnemonic = m_words[0];
            if (mnemonic == "in")
            {
                binaryString += "11011011";
                binaryString += m_words[1];
            }
            else if (mnemonic == "out")
            {
                binaryString += "11010011";
                binaryString += m_words[1];
            }
            else if (mnemonic == "ei")
            {
                binaryString += "11111011";
            }
            else if (mnemonic == "di")
            {
                binaryString += "11110011";
            }
            else if (mnemonic == "hlt")
            {
                binaryString += "01110110";
            } 
            else if (mnemonic == "rst")
            {
                binaryString += "11" + m_words[1] + "111";
            }
            else if (mnemonic == "cmc")
            {
                binaryString += "00111111";
            } 
            else if (mnemonic == "stc")
            {
                binaryString += "00110111";
            } 
            else if (mnemonic == "nop")
            {
                binaryString += "00000000";
            }
            else
            {
                throw new NotSupportedException("Unsupported Instruction");
            }

            return binaryString;
        }
    }
}
