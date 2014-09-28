using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asm8080Sharp.Instructions
{
    public class CallInstruction : AbstractInstruction
    {
         public CallInstruction(List<String> words)
        {
            this.m_words = words;
        }

        public override string[] getMnemonics()
        {
            return new String[] { "call", "cc", "cnc", "cz", "cnz", "cm", "cp", "cpe", "cpo" };
        }

        public override string getBinaryCode()
        {
            String binaryString = "";
            String mnemonic = m_words[0];
            if ("call" == mnemonic)
            {
                binaryString += "11001101";
                binaryString += m_words[1];
                binaryString += m_words[2];
            }
            else if ("cc" == mnemonic)
            {
                binaryString += "11011100";
                binaryString += m_words[1];
                binaryString += m_words[2];
            }
            else if ("cnc" == mnemonic)
            {
                binaryString += "11010100";
                binaryString += m_words[1];
                binaryString += m_words[2];
            }
            else if ("cz" == mnemonic)
            {
                binaryString += "11001100";
                binaryString += m_words[1];
                binaryString += m_words[2];
            }
            else if ("cnz" == mnemonic)
            {
                binaryString += "11000100";
                binaryString += m_words[1];
                binaryString += m_words[2];
            }
            else if ("cm" == mnemonic)
            {
                binaryString += "11111100";
                binaryString += m_words[1];
                binaryString += m_words[2];
            }
            else if ("cp" == mnemonic)
            {
                binaryString += "11110100";
                binaryString += m_words[1];
                binaryString += m_words[2];
            }
            else if ("cpe" == mnemonic)
            {
                binaryString += "11101100";
                binaryString += m_words[1];
                binaryString += m_words[2];
            }
            else if ("cpo" == mnemonic)
            {
                binaryString += "11100100";
                binaryString += m_words[1];
                binaryString += m_words[2];
            }
            else
            {
                throw new NotSupportedException("Unsupported Instruction");
            }

            return binaryString;
        }
    }
}
