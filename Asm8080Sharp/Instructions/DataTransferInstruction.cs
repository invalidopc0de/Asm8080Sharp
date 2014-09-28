using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asm8080Sharp.Instructions
{
    public class DataTransferInstruction : AbstractInstruction
    {
        public DataTransferInstruction(List<String> words)
        {
            this.m_words = words;
        }
        public override String[] getMnemonics()
        {
            return new String[] {"mov", "stax", "ldax", "add", "adc", 
                "sub", "sbb", "ana", "xra", "ora", "cmp", "sta", "lda", "shld", "lhld" };
        }

        public override String getBinaryCode()
        {
            String binaryString = "";
            String mnemonic = m_words[0];
            if ("mov" == mnemonic)
            {
                binaryString += "01" + Utils.getRegisterString(m_words[1]) + Utils.getRegisterString(m_words[2]);
            }
            else if ("stax" == mnemonic || "ldax" == mnemonic)
            {
                if (m_words[1] == "bc")
                {
                    binaryString += "00000010";
                }
                else
                {
                    binaryString += "00010010";
                }
            }
            else if ("add" == mnemonic)
            {
                binaryString += "10000" + Utils.getRegisterString(m_words[1]);
            }
            else if ("adc" == mnemonic)
            {
                binaryString += "10001" + Utils.getRegisterString(m_words[1]);
            }
            else if ("sub" == mnemonic)
            {
                binaryString += "10010" + Utils.getRegisterString(m_words[1]);
            }
            else if ("sbb" == mnemonic)
            {
                binaryString += "10011" + Utils.getRegisterString(m_words[1]);
            }
            else if ("ana" == mnemonic)
            {
                binaryString += "10100" + Utils.getRegisterString(m_words[1]);
            }
            else if ("xra" == mnemonic)
            {
                binaryString += "10101" + Utils.getRegisterString(m_words[1]);
            }
            else if ("ora" == mnemonic)
            {
                binaryString += "10110" + Utils.getRegisterString(m_words[1]);
            }
            else if ("cmp" == mnemonic)
            {
                binaryString += "10111" + Utils.getRegisterString(m_words[1]);
            }
            else if ("sta" == mnemonic)
            {
                binaryString += "00110010";
                binaryString += m_words[1];
                binaryString += m_words[2];
            } 
            else if ("lda" == mnemonic)
            {
                binaryString += "00111010";
                binaryString += m_words[1];
                binaryString += m_words[2];
            }
            else if ("shld" == mnemonic)
            {
                binaryString += "00100010";
                binaryString += m_words[1];
                binaryString += m_words[2];
            }
            else if ("lhld" == mnemonic)
            {
                binaryString += "00101010";
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
