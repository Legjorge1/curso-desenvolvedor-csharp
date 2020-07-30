using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExemploDictionary
{
    public partial class Form1 : Form
    {
        Dictionary<string, string> dicionario = new Dictionary<string, string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dicionario.Add("Wemerson", "Wemerson");
            dicionario.Add("Akira", "Akira");
            dicionario.Add("Josue", "Josue");
            dicionario.Add("jordan", "jordan");

            apresentarLista();
        }

        private void mostraMensagemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string selecionado = listBox1.SelectedValue.ToString();
            MessageBox.Show(selecionado);
        }

        private void removerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string selecionado = listBox1.SelectedValue.ToString();
            dicionario.Remove(selecionado);
            apresentarLista();
        }

        void apresentarLista() {
            listBox1.DataSource = dicionario.Values.ToList();
        }
    }
}
