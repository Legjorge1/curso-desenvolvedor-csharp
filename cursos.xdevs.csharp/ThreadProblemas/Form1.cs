using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreadProblemas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


         double FazerCalculosIntensos()
        {
            // Nós estamos fazendo calculos intensos
            // com divisões sem sentido
            double result = 100000000d;
            var maxValue = Int32.MaxValue;
            for (int i = 1; i < maxValue; i++)
            {
                result /= i;
            }
            return result + 10d;
        }

        void rodar() {
            //Ocorrerá erro
            txt.Text = FazerCalculosIntensos().ToString();
        }

        void rodarCorretamente() {
            ColocarTexto(FazerCalculosIntensos().ToString());
        }

        //Criar um delegate
        delegate void ColocarTextoDelegate(string text);
        void ColocarTexto(string texto)
        {
            if (txt.InvokeRequired)
            {
                txt.BeginInvoke(new ColocarTextoDelegate(ColocarTexto), texto);
                return;
            }
            txt.Text = texto;
        }
        private void btn_Click(object sender, EventArgs e)
        {
            Thread th = new Thread(rodar);
            th.Start();
        }
    }
}
