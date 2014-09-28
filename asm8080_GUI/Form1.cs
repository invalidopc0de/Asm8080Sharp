using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Asm8080Sharp;
using Asm8080Sharp.Instructions;

namespace asm8080_GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void assembleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AsmParser parser = new AsmParser();
            List<AbstractInstruction> machineCode = new List<AbstractInstruction>();
            machineCode = parser.parseAsm(textBox1.Text);
            textBox2.Text = "";
            foreach (AbstractInstruction instruction in machineCode)
            {
                textBox2.Text += instruction.getBinaryCode() + Environment.NewLine;
            }
        }

        
    }
}
