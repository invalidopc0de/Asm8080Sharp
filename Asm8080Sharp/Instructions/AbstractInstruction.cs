using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asm8080Sharp.Instructions
{
    public abstract class AbstractInstruction
    {
        
        protected List<String> m_words;
        public abstract string getBinaryCode();
        public abstract String[] getMnemonics();
    }
}
