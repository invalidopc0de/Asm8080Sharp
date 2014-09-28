using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asm8080Sharp.Instructions
{
    public class RegisterPairInstruction : AbstractInstruction
    {
        public RegisterPairInstruction(List<String> words)
        {
            this.m_words = words;
        }

        public override string[] getMnemonics()
        {
            return new String[] { "push", "pop", "dad", "inx", "dcx", "xchg", "xthl", "sphl" };
        }

        public override string getBinaryCode()
        {
            String binaryString = "";
            String mnemonic = m_words[0];
            if ("push" == mnemonic)
            {
                binaryString += "11" + Utils.getRegisterPairString(m_words[1]) + "0101";
            }
            else if ("pop" == mnemonic)
            {
                binaryString += "11" + Utils.getRegisterPairString(m_words[1]) + "0001";
            }
            else if ("dad" == mnemonic)
            {
                binaryString += "00" + Utils.getRegisterPairString(m_words[1]) + "1001";
            }
            else if ("inx" == mnemonic)
            {
                binaryString += "00" + Utils.getRegisterPairString(m_words[1]) + "0011";
            }
            else if ("dcx" == mnemonic)
            {
                binaryString += "00" + Utils.getRegisterPairString(m_words[1]) + "1011";
            }
            else if ("xchg" == mnemonic)
            {
                binaryString += "11101011";
            }
            else if ("xthl" == mnemonic)
            {
                binaryString += "11100011";
            }
            else if ("sphl" == mnemonic)
            {
                binaryString += "11111001";
            }
            else
            {
                throw new NotSupportedException("Unsupported Instruction");
            }

            return binaryString;
        }

        
    }
}
