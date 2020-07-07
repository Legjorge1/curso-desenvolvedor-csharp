using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManipulandoComStringBuilder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            string[] nomes = { "Diogo", "Costa", "Santos", "xDidadev", };
            StringBuilder todosNomes = new StringBuilder();
            foreach (string name in nomes)
            {
                todosNomes.Append("[" + name + "]" + Environment.NewLine);
            }
            textBox1.Text = todosNomes.ToString();

        }
    }
}
