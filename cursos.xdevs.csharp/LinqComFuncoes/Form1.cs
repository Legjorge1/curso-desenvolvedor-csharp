using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinqComFuncoes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] meuArray = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int quantidade = (from i in meuArray
                              where i % 2 == 0
                              select i).Count();

            richTextBox1.Text += ($"Quantidade: {quantidade}") + Environment.NewLine;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[] meuArray = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int quantidade = meuArray.Where(i => i % 2 == 0).Count();

            richTextBox1.Text += ($"Quantidade: {quantidade}") + Environment.NewLine;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int[] meuArray = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            double media = (from i in meuArray
                              where i % 2 == 0
                              select i).Average();

            richTextBox1.Text += ($"Média: {media}") + Environment.NewLine;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int[] meuArray = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            double media = meuArray.Where(i => i % 2 == 0).Average();

            richTextBox1.Text += ($"Média: {media}") + Environment.NewLine;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int[] meuArray = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int min = (from i in meuArray
                            where i % 2 == 0
                            select i).Min();

            richTextBox1.Text += ($"Mínimo: {min}") + Environment.NewLine;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int[] meuArray = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int max = (from i in meuArray
                       where i % 2 == 0
                       select i).Max();

            richTextBox1.Text += ($"Máximo: {max}") + Environment.NewLine;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int[] meuArray = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int min = meuArray.Where(i => i % 2 == 0).Min();

            richTextBox1.Text += ($"Mínimo: {min}") + Environment.NewLine;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int[] meuArray = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int max = meuArray.Where(i => i % 2 == 0).Max();

            richTextBox1.Text += ($"Máximo: {max}") + Environment.NewLine;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int[] meuArray = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int primeiro = (from i in meuArray
                       where i % 2 == 0
                       select i).First();

            richTextBox1.Text += ($"Primeiro: {primeiro}") + Environment.NewLine;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int[] meuArray = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int primeiro = meuArray.Where(i => i % 2 == 0).First();

            richTextBox1.Text += ($"Primeiro: {primeiro}") + Environment.NewLine;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            int[] meuArray = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int ultimo = (from i in meuArray
                            where i % 2 == 0
                            select i).Last();

            richTextBox1.Text += ($"Último: {ultimo}") + Environment.NewLine;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int[] meuArray = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int ultimo = meuArray.Where(i => i % 2 == 0).Last();

            richTextBox1.Text += ($"Primeiro: {ultimo}") + Environment.NewLine;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //skip
            int[] meuArray = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var numeros1 = meuArray.Skip(1);
            richTextBox1.Text += ($"números: {string.Join(",", numeros1)}") + Environment.NewLine;

            //take
            var numeros2 = meuArray.Take(2);
            richTextBox1.Text += ($"números: {string.Join(",", numeros2)}") + Environment.NewLine;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            int[] meuArray = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var numeros1 = meuArray.Skip(1).Take(2);
            richTextBox1.Text += ($"números: {string.Join(",", numeros1)}") + Environment.NewLine;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            int[] meuArray = new int[14] { 1, 5, 6, 7, 8, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var numeros1 = meuArray.Distinct();
            richTextBox1.Text += ($"números: {string.Join(",", numeros1)}") + Environment.NewLine;

        }
    }
}
