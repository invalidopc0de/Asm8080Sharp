using Asm8080Sharp.Instructions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asm8080Sharp
{
    public static class InstructionFactory
    {
        public static AbstractInstruction createInstruction(List<String> words)
        {
            Dictionary<Mnemonics.InstructionType, string[]> mnemonics = Mnemonics.getMnemonics();
            bool createdInstruction = true;
            AbstractInstruction newInstruction = null;

            foreach (Mnemonics.InstructionType key in mnemonics.Keys)
            {
                if (mnemonics[key].Contains(words[0]))
                {
                    if (Mnemonics.InstructionType.Command == key)
                    {
                        newInstruction = new CommandInstruction(words);
                    }
                    else if (Mnemonics.InstructionType.SingleRegisters == key)
                    {
                        newInstruction = new SingleRegisterInstruction(words);
                    }
                    else if (Mnemonics.InstructionType.RegisterPair == key)
                    {
                        newInstruction = new RegisterPairInstruction(words);
                    }
                    else if (Mnemonics.InstructionType.RotateAccumulator == key)
                    {
                        newInstruction = new RotateAccumulatorInstruction(words);
                    }
                    else if (Mnemonics.InstructionType.DataTransfer == key)
                    {
                        newInstruction = new DataTransferInstruction(words);
                    }
                    else if (Mnemonics.InstructionType.Immediate == key)
                    {
                        newInstruction = new ImmediateInstruction(words);
                    }
                    else if (Mnemonics.InstructionType.Jump == key)
                    {
                        newInstruction = new JumpInstruction(words);
                    }
                    else if (Mnemonics.InstructionType.Call == key)
                    {
                        newInstruction = new CallInstruction(words);
                    }
                    else if (Mnemonics.InstructionType.Return == key)
                    {
                        newInstruction = new ReturnInstruction(words);
                    }
                    break;
                }
            }

            if (createdInstruction == false)
            {
                throw new NotSupportedException("Unknown mnemonic");
            }

            return newInstruction;
        }
    }
}
