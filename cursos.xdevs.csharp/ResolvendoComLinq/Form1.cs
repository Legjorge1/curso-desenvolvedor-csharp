using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResolvendoComLinq
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[] meuArray = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] numerosPares = new int[5];
            int index = 0;
            foreach (int i in meuArray)
            {
                if (i % 2 == 0)
                {
                    numerosPares[index] = i;
                    index++;
                }
            }
            foreach (int i in numerosPares)
            {
                richTextBox1.Text += i.ToString()  + Environment.NewLine;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] meuArray = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var numerosPares = from i in meuArray
                              where i % 2 == 0
                              select i;
            foreach (int i in numerosPares)
            {
                richTextBox1.Text += i.ToString() + Environment.NewLine;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int[] meuArray = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var numerosPares = from i in meuArray
                               where i % 2 == 0 && i > 5
                               select i;
            foreach (int i in numerosPares)
            {
                richTextBox1.Text += i.ToString() + Environment.NewLine;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int[] meuArray = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var numerosPares = from i in meuArray
                               where i % 2 == 0 
                               where i > 5
                               select i;
            foreach (int i in numerosPares)
            {
                richTextBox1.Text += i.ToString() + Environment.NewLine;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int[] meuArray = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var numerosPares = from i in meuArray
                               where funcaoWhere(i)
                               select i;
            foreach (int i in numerosPares)
            {
                richTextBox1.Text += i.ToString() + Environment.NewLine;
            }
        }

        bool funcaoWhere(int i) {
            return i % 2 == 0 && i > 5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int[] meuArray = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var numerosPares = from i in meuArray
                               where i % 2 == 0
                               orderby i descending
                               select i;
            foreach (int i in numerosPares)
            {
                richTextBox1.Text += i.ToString() + Environment.NewLine;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            List<Local> Locais = new List<Local>()
             {
             new Local() { Estado = "Bahia", Sigla = "BA" },
             new Local() { Estado = "Rio de Janeiro", Sigla = "RJ" },
             new Local() { Estado = "Alagoas", Sigla = "AL" },
             new Local() { Estado = "São Paulo", Sigla = "SP" },
             new Local() { Estado = "Minas Gerais", Sigla = "MG" },

             };

            var LocaisOrdenados = from h in Locais
                                  orderby h.Estado ascending, h.Sigla ascending
                                   select h;
            foreach (Local estados in LocaisOrdenados)
            {
                richTextBox1.Text += (estados.Estado + ", " + estados.Sigla) + Environment.NewLine;
            }
        }



        public class Local
        {
            public string Sigla { get; set; }
            public string Estado { get; set; }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int[] meuArray = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var numerosPares = meuArray.Where(i => i % 2 == 0 );

            foreach (int i in numerosPares)
            {
                richTextBox1.Text += i.ToString() + Environment.NewLine;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            int[] meuArray = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var numerosPares = meuArray.Where(i => i % 2 == 0 && i > 5);

            foreach (int i in numerosPares)
            {
                richTextBox1.Text += i.ToString() + Environment.NewLine;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            int[] meuArray = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            
            var numerosPares = meuArray
                .Where(i => i % 2 == 0)
                .Where(i => i > 5) ;

            foreach (int i in numerosPares)
            {
                richTextBox1.Text += i.ToString() + Environment.NewLine;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int[] meuArray = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var numerosPares = meuArray
                .Where(i => funcaoWhere(i));

            foreach (int i in numerosPares)
            {
                richTextBox1.Text += i.ToString() + Environment.NewLine;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int[] meuArray = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var numerosPares = meuArray.OrderBy(i => i);
            foreach (int i in numerosPares)
            {
                richTextBox1.Text += i.ToString() + Environment.NewLine;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            List<Local> Locais = new List<Local>()
             {
             new Local() { Estado = "Bahia", Sigla = "BA" },
             new Local() { Estado = "Rio de Janeiro", Sigla = "RJ" },
             new Local() { Estado = "Alagoas", Sigla = "AL" },
             new Local() { Estado = "São Paulo", Sigla = "SP" },
             new Local() { Estado = "Minas Gerais", Sigla = "MG" },

             };

            var LocaisOrdenados = Locais.OrderBy(o => o.Estado).ThenBy(o => o.Sigla);
            foreach (Local estados in LocaisOrdenados)
            {
                richTextBox1.Text += (estados.Estado + ", " + estados.Sigla) + Environment.NewLine;
            }
        }
    }
}
