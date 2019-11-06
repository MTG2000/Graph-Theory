using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graph_Theory_3
{
    public partial class TerminalForm : Form
    {
        private string initialText = " --> Mtg Terminal v0.2\n";
        private string prefix = "  ";


        public TerminalForm()
        {
            InitializeComponent();
            output.Text = initialText;
            panel.Size = new Size(this.Size.Width - 10, this.Size.Height - 50);
        }

        public void Print(string msg) {
            output.AppendText( msg);
        }
        public void PrintLn()
        {
            output.AppendText( '\n' + prefix);
        }
        public void PrintLn(string msg) {
            output.AppendText( '\n' + prefix + msg);
        }

        public void Clear() {
            output.Text = initialText;
        }

        private void TerminalForm_Resize(object sender, EventArgs e)
        {
            panel.Size = new Size(this.Size.Width-10,this.Size.Height-50);
        }

        private void output_TextChanged(object sender, EventArgs e)
        {
            output.SelectionStart = output.Text.Length;
            output.ScrollToCaret();

        }
    }
}
