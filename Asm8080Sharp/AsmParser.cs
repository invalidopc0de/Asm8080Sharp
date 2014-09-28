using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Asm8080Sharp.Instructions;

namespace Asm8080Sharp
{
    public class AsmParser
    {
        private AbstractInstruction parseLine(string asmLine)
        {
            AbstractInstruction instruction;
            List<String> words = new List<string>();
            string[] majorWords = asmLine.Split(' ');
            words.Add(majorWords[0]);
            if (majorWords.Length > 1){
                foreach(string word in majorWords[1].Split(','))
                {
                    words.Add(word.ToLower());
                }
            }

            instruction = InstructionFactory.createInstruction(words);
            return instruction;
        }

        public List<AbstractInstruction> parseAsm(string asmCode)
        {
            List<AbstractInstruction> instructionList = new List<AbstractInstruction>();

            string[] lines = asmCode.Split('\n');
            foreach (string line in lines)
            {
                if (line.Trim().Length > 0)
                {
                    instructionList.Add(parseLine(line.Trim()));
                }
            }

            return instructionList;
        }
    }
}
