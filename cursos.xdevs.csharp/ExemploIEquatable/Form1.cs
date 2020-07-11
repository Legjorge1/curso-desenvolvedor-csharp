using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExemploIEquatable
{
    public partial class Form1 : Form
    {
        private List<Pessoa> listaPessoas = new List<Pessoa>();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pessoa pessoa = new Pessoa()
            {
                PrimeiroNome = textBox1.Text,
                UltimoNome = textBox2.Text
            };
            if (listaPessoas.Contains(pessoa))
            {
                MessageBox.Show("Esta pessoa já consta na lista.");
                textBox1.Focus();
            }
            else
            {
                listaPessoas.Add(pessoa);
                listBox1.Items.Add(pessoa);
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();
            }
        }
    }

    //Objetos iguais
    class Pessoa : IEquatable<Pessoa>
    {
        public string PrimeiroNome { get; set; }
        public string UltimoNome { get; set; }
        public bool Equals(Pessoa outraPessoa)
        {
            return ((PrimeiroNome == outraPessoa.PrimeiroNome) && (UltimoNome == outraPessoa.UltimoNome));
        }
        public override string ToString()
        {
            return string.Format("{0} {1}", this.PrimeiroNome, this.UltimoNome);
        }

    }
}
