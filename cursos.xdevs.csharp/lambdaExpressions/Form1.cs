using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lambdaExpressions
{
    public partial class Form1 : Form
    {

        private int Trials = 0;

        public Form1()
        {
            InitializeComponent();

            button4.Click += async (button, buttonArgs) =>
            {
                int trial = ++Trials;
                statusLabel.Text = "Executando o teste " + trial.ToString() + "...";
                await DoSomethingAsync();
                statusLabel.Text = "Teste realizado " + trial.ToString();
            };

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Action mensagem;
            mensagem = () => MessageBox.Show("Oi");
            mensagem();

            //Action mensagem = () => MessageBox.Show("Oi");
            //mensagem();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Action<string> m = (mensagem) => MessageBox.Show(mensagem);
            
            m("mensagem que vai ser chamada");

            //tudo na mesma linha
            Action<string, string, MessageBoxButtons, MessageBoxIcon> n = 
                (message, caption, buttons, icon) => 
                MessageBox.Show(message, caption, buttons, icon);


            n("Mensgem de dados inválidos", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Func<float, float> quadrado = (float x) => x * x;
            float y = quadrado(13);

            MessageBox.Show(quadrado.ToString());

        }

        async Task DoSomethingAsync()
        {
            // só para gastar o tempo 
            await Task.Delay(3000);
        }

  
    }
}
