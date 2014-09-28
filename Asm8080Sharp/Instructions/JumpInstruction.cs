using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asm8080Sharp.Instructions
{
    public class JumpInstruction : AbstractInstruction
    {
        public JumpInstruction(List<String> words)
        {
            this.m_words = words;
        }

        public override string[] getMnemonics()
        {
            return new String[] { "pchl", "jmp", "jc", "jnc", "jz", "jm", "jp", "jpe", "jpo"};
        }

        public override string getBinaryCode()
        {
            String binaryString = "";
            String mnemonic = m_words[0];
            if ("pchl" == mnemonic)
            {
                binaryString += "11101001";
            }
            else if ("jmp" == mnemonic)
            {
                binaryString += "11000011";
                binaryString += m_words[1];
                binaryString += m_words[2];
            }
            else if ("jc" == mnemonic)
            {
                binaryString += "11011010";
                binaryString += m_words[1];
                binaryString += m_words[2];
            }
            else if ("jnc" == mnemonic)
            {
                binaryString += "11010010";
                binaryString += m_words[1];
                binaryString += m_words[2];
            }
            else if ("jz" == mnemonic)
            {
                binaryString += "11001010";
                binaryString += m_words[1];
                binaryString += m_words[2];
            }
            else if ("jnz" == mnemonic)
            {
                binaryString += "11000010";
                binaryString += m_words[1];
                binaryString += m_words[2];
            }
            else if ("jm" == mnemonic)
            {
                binaryString += "11111010";
                binaryString += m_words[1];
                binaryString += m_words[2];
            }
            else if ("jp" == mnemonic)
            {
                binaryString += "11110010";
                binaryString += m_words[1];
                binaryString += m_words[2];
            }
            else if ("jpe" == mnemonic)
            {
                binaryString += "11101010";
                binaryString += m_words[1];
                binaryString += m_words[2];
            }
            else if ("jpo" == mnemonic)
            {
                binaryString += "11100010";
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
