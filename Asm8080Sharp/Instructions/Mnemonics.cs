using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asm8080Sharp.Instructions
{
    public static class Mnemonics
    {
        public enum InstructionType
	    {
	        Command,
            SingleRegisters,
            RegisterPair,
            RotateAccumulator,
            DataTransfer,
            Immediate,
            Jump, 
            Call,
            Return
	    }

        public static Dictionary<InstructionType, string[]> getMnemonics()
        {
            Dictionary<InstructionType, string[]> mnemonics = new Dictionary<InstructionType, string[]>();
            mnemonics.Add(InstructionType.Command, new string[] { "in", "out", "ei", "di", "hlt", "rst", "cmc", "stc", "nop" });
            mnemonics.Add(InstructionType.SingleRegisters, new string[] { "inr", "dcr", "cma", "daa" });
            mnemonics.Add(InstructionType.RegisterPair, new string[] { "push", "pop", "dad", "inx", "dcx", "xchg", "xthl", "sphl" });
            mnemonics.Add(InstructionType.RotateAccumulator, new string[] { "rlc", "rrc", "ral", "rar" });
            mnemonics.Add(InstructionType.DataTransfer, new string[]{"mov", "stax", "ldax", "add", "adc", 
                "sub", "sbb", "ana", "xra", "ora", "cmp", "sta", "lda", "shld", "lhld" });
            mnemonics.Add(InstructionType.Immediate, new string[] { "lxi", "mvi", "adi", "aci", "sui", "sbi", "ani", "xri", "ori", "cpi" });
            mnemonics.Add(InstructionType.Jump, new string[] { "pchl", "jmp", "jc", "jnc", "jz", "jm", "jp", "jpe", "jpo" });
            mnemonics.Add(InstructionType.Call, new string[] { "call", "cc", "cnc", "cz", "cnz", "cm", "cp", "cpe", "cpo" });
            mnemonics.Add(InstructionType.Return, new string[] { "ret", "rc", "rnc", "rz", "rnz", "rm", "rp", "rpe", "rpo" });
            return mnemonics;
        } 

        public static string[] getMnemonics(InstructionType type)
        {
            return getMnemonics()[type];
        }
       
    }
}
