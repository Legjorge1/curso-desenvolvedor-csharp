using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace manipulandocomstringbuilder2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Criando um StringBuilder e atribuindo o valor ABC ......
            StringBuilder letras = new StringBuilder("ABCDEFGHIJKLMNOPQRSTUVWXYZ");

            // Criar o Stringuilder Linhas.
            StringBuilder linhas = new StringBuilder();

            // Criar o StringBuilder resultado.
            StringBuilder resultado = new StringBuilder();

            // loop nas letras.
            for (int i = 0; i < 26; i++)
            {
                // adicionar a próxima letra no StringBuilderLinha.
                linhas.Append(letras[i]);

                // adiciona linha para o resultado.
                resultado.AppendLine(linhas.ToString());
            }
            // mostra o resultado
            
            //stringBuilderTextBox.Text = resultado.ToString();
            stringBuilderTextBox.Text = linhas.ToString();
            stringBuilderTextBox.Select(0, 0);

            StringBuilder sb = new StringBuilder();
            txtFormat.Text = sb.AppendFormat("Di{0}o", "og").ToString();





        }
    }
}
