using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FuncDelegate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Func<string> funcDelegate = metodoExecutadopelaFunc;
            string resultado = funcDelegate();
            MessageBox.Show(resultado);
        }

        //Funct tem de retornar um valor
        private string metodoExecutadopelaFunc()
        {
            return "Olá, tudo bem?";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Func<double, double, double> Calcular = Adicionar;
            double resultadoCalculo = Calcular(9.7, 12.6);
            MessageBox.Show(resultadoCalculo.ToString());
        }

        private double Adicionar(double n1, double n2)
        {
            return n1 + n2;
        }
    }
}
