using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exemploStack
{
    public partial class Form1 : Form
    {
        Stack<string> stackList = new Stack<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            stackList.Push(txtEntrada.Text);
            txtEntrada.Text = string.Empty;
            mostrarfila();
        }

        void mostrarfila()
        {
            lstStack.DataSource = stackList.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string texto = stackList.Pop();
            txtSaida.Text = texto;
            mostrarfila();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string texto = stackList.Peek();
            txtSaida.Text = texto;
            mostrarfila();
        }
    }
}
