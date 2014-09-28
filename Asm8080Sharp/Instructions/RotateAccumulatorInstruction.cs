using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asm8080Sharp.Instructions
{
    public class RotateAccumulatorInstruction : AbstractInstruction
    {
        public RotateAccumulatorInstruction(List<String> words)
        {
            this.m_words = words;
        }

        public override string[] getMnemonics()
        {
            return new String[] { "rlc", "rrc", "ral", "rar" };
        }

        public override string getBinaryCode()
        {
            String binaryString = "";
            String mnemonic = m_words[0];
            if ("rlc" == mnemonic)
            {
                binaryString += "00000111";
            }
            else if ("rrc" == mnemonic)
            {
                binaryString += "00001111";
            }
            else if ("ral" == mnemonic)
            {
                binaryString += "00010111";
            }
            else if ("rar" == mnemonic)
            {
                binaryString += "00011111";
            }
            else
            {
                throw new NotSupportedException("Unsupported Instruction");
            }

            return binaryString;
        }

      
    }
}
