using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinqMaisExemplos
{
    public partial class Form1 : Form
    {
        List<Local> Locais;
        List<Empregado> Empregados;
        public Form1()
        {
            InitializeComponent();

            Preencher();
        }

        void Preencher() {

            Locais = new List<Local>()
             {
             new Local() { Estado = "Bahia", Sigla = "BA", CampoA = "A", CampoB = "B", CampoC = "C" },
             new Local() { Estado = "Rio de Janeiro", Sigla = "RJ", CampoA = "sdfa13A", CampoB = "B3", CampoC = "C1" },
             new Local() { Estado = "Alagoas", Sigla = "AL", CampoA = "xDA", CampoB = "B", CampoC = "C" },
             new Local() { Estado = "São Paulo", Sigla = "SP", CampoA = "xDA", CampoB = "Bd", CampoC = "wwerC" },
             new Local() { Estado = "Minas Gerais", Sigla = "MG", CampoA = "xDA", CampoB = "B2", CampoC = "C2" },
             new Local() { Estado = "Paraná", Sigla = "PR", CampoA = "xDA", CampoB = "B2", CampoC = "C2" },

             };

            Empregados = new List<Empregado>()
            {
                new Empregado(){ Nome = "Renan", Sobrenome = "Martins", Sigla = "SP" },
                new Empregado(){ Nome = "FBI", Sobrenome = "Dev", Sigla = "PR" },
                new Empregado(){ Nome = "Jordan", Sobrenome = "Santos", Sigla = "BA" },
                new Empregado(){ Nome = "Diogo", Sobrenome = "Costa", Sigla = "SP" },

            };
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var LocaisOrdenados = from h in Locais
                                  select h.Estado;

            foreach (var estados in LocaisOrdenados)
            {
                richTextBox1.Text += (estados) + Environment.NewLine;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var LocaisOrdenados = Locais.Select(h => h.Estado);

            foreach (var estados in LocaisOrdenados)
            {
                richTextBox1.Text += (estados) + Environment.NewLine;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var LocaisOrdenados = from h in Locais
                                  select new { h.Estado, h.Sigla };

            foreach (var estados in LocaisOrdenados)
            {
                richTextBox1.Text += (estados.Estado + ", " + estados.Sigla) + Environment.NewLine;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var LocaisOrdenados = Locais.Select(h => new { h.Estado, h.Sigla  });

            foreach (var estados in LocaisOrdenados)
            {
                richTextBox1.Text += (estados.Estado + ", " + estados.Sigla) + Environment.NewLine;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var LocaisOrdenados = from h in Locais
                                  select new { XXX = h.Estado, BLABLA = h.Sigla };

            foreach (var estados in LocaisOrdenados)
            {
                richTextBox1.Text += (estados.XXX + ", " + estados.BLABLA) + Environment.NewLine;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var LocaisOrdenados = Locais.Select(h => new { XXX = h.Estado, BLABLA = h.Sigla });

            foreach (var estados in LocaisOrdenados)
            {
                richTextBox1.Text += (estados.XXX + ", " + estados.BLABLA) + Environment.NewLine;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            var LocaisOrdenados = from h in Empregados
                                  join s in Locais on h.Sigla equals s.Sigla
                                  select new { XXX = h.Nome, BLABLA = s.Estado };

            foreach (var estados in LocaisOrdenados)
            {
                richTextBox1.Text += (estados.XXX + ", " + estados.BLABLA) + Environment.NewLine;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var LocaisOrdenados = Empregados.Join(Locais,
                h => h.Sigla, //=> empregado
                s => s.Sigla, //=> Locais
                (h, s) => new { XXX = h.Nome, BLABLA = s.Estado } //=> objeto anonimo
                );

            foreach (var estados in LocaisOrdenados)
            {
                richTextBox1.Text += (estados.XXX + ", " + estados.BLABLA) + Environment.NewLine;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            var LocaisOrdenados = from h in Empregados
                                  join s in Locais on h.Sigla equals s.Sigla into grupoEmpregados
                                  from item in grupoEmpregados.DefaultIfEmpty(
                                      new Local { Sigla = string.Empty, Estado = "" })
                                  select new {
                                      XXX = h.Sobrenome,
                                      BLABLA = item.Estado
                                  };

            foreach (var estados in LocaisOrdenados)
            {
                richTextBox1.Text += (estados.XXX + ", " + estados.BLABLA) + Environment.NewLine;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            var LocaisOrdenados = Empregados.GroupJoin(Locais,
                h => h.Sigla,
                s => s.Sigla,
                (h, empregadosGrupo) => empregadosGrupo.Select(s => new
                {
                    XXX = h.Sobrenome,
                    BLABLA = s.Estado
                }).DefaultIfEmpty(new
                {
                    XXX = h.Sobrenome,
                    BLABLA = ""
                })).SelectMany(o => o);

            foreach (var estados in LocaisOrdenados)
            {
                richTextBox1.Text += (estados.XXX + ", " + estados.BLABLA) + Environment.NewLine;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            var empregadoPorEstados = from h in Empregados
                                      group h by h.Sigla;

            foreach (var empregadosGrupo in empregadoPorEstados)
            {
                richTextBox1.Text += (empregadosGrupo.Key + ", " + empregadosGrupo.Count()) + Environment.NewLine;

                foreach (var empregado in empregadosGrupo)
                {
                    richTextBox1.Text += empregado.Nome + ", " + empregado.Sobrenome;
                }
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            var empregadoPorEstados = Empregados.GroupBy(o => o.Sigla);

            foreach (var empregadosGrupo in empregadoPorEstados)
            {
                richTextBox1.Text += (empregadosGrupo.Key + ", " + empregadosGrupo.Count()) + Environment.NewLine;

                foreach (var empregado in empregadosGrupo)
                {
                    richTextBox1.Text += empregado.Nome + ", " + empregado.Sobrenome;
                }
            }
        }
    }

    public class Empregado { 
        public string Nome { get; set; }
        public string Sobrenome { get; set; }

        public string Sigla { get; set; }
    }

    public class Local
    {
        public string Sigla { get; set; }
        public string Estado { get; set; }

        public string CampoA { get; set; }

        public string CampoB { get; set; }
        public string CampoC { get; set; }
    }

}
