using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ActionDelegate
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //Chamada pela Action
        void metodoDaClasseMultiplicar(double x, double y) 
        {
            txtResultadoAction1.Text = (x * y).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Action<double, double> multiplicarporAction = metodoDaClasseMultiplicar;

            double n1 = 100;
            double n2 = 200;
            
            multiplicarporAction(n1, n2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var lista = new[] { "Santos", "Palmeiras", "Corinthians", "São Paulo", "Vasco", "Bahia" };
            
            Action<string> minhaAction = new Action<string>(ImprimirTime);

            Array.ForEach(lista, minhaAction);
        }

        void ImprimirTime(string nomeTime)
        {
            MessageBox.Show(nomeTime);
        }
    }



}
