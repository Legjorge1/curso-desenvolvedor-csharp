using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThisEBase
{


    public partial class Form1 : Form
    {
        public static string Results = "";

        public Form1()
        {
            InitializeComponent();

            Results += "Criando a Pessoa(Bia)" + Environment.NewLine;
            Pessoa bea = new Pessoa("Bia");
            Results += Environment.NewLine;
            Results += "Criando a Pessoa(Ed, Nasc)" + Environment.NewLine;
            Pessoa al = new Pessoa("Ed", "Nasc");
            Results += Environment.NewLine;
            // Criando alguns empregados
            Results += "Criando Empregado(Carlos)" + Environment.NewLine;
            Pessoa carl = new Empregado("Carlos");
            Results += Environment.NewLine;
            Results += "Criando Empregado(Débora, Garcia)" + Environment.NewLine;
            Pessoa deb = new Empregado("Débora", "Garcia");
            Results += Environment.NewLine;
            Results += "Criando Empregado(João, Carlos, RH)" + Environment.NewLine;
            Pessoa ed = new Empregado("João", "Carlos", "RH");
            Results += Environment.NewLine;
            // Mostrar os Resultados
            resultsTextBox.Text = Results;
            resultsTextBox.Select(0, 0);
        }
    }



    class Pessoa
    {
        public string PrimeiroNome { get; set; }
        public string UltimoNome { get; set; }
        // Constructor com priemiro nome.
        public Pessoa(string primeiroNome)
        {
            Form1.Results += " Pessoa(" + primeiroNome + ")" + Environment.NewLine;
            PrimeiroNome = primeiroNome;
        }

        // Contrutor com o primeiro e o último nome.

        public Pessoa(string primeiroNome, string ultimoNome) : this(primeiroNome)
        {
            Form1.Results += " Pessoa(" + primeiroNome + ", " + ultimoNome + ")" + Environment.NewLine;
            UltimoNome = ultimoNome;
        }
    }


    class Empregado : Pessoa
    {
        public string DepartamentoNome { get; set; }

        // construtoro como primeiroNome.
        public Empregado(string primeiroNome) : base(primeiroNome)
        {
            Form1.Results += " Empregado(" + primeiroNome + ")" + Environment.NewLine;
        }

        // Contrutor com o primeiro e o último nome.
        public Empregado(string primeiroNome, string ultimoNome) : base(primeiroNome, ultimoNome)
        {
            Form1.Results += " Empregado(" + primeiroNome + ", " + ultimoNome + ")" + Environment.NewLine;
        }

        // Contrutor com o primeiro e o último nome e o nome do departamento
        public Empregado(string primeiroNome, string ultimoNome, string departamentoNome) : this(primeiroNome, ultimoNome)
        {
            Form1.Results += " Empregado(" + primeiroNome + ", " + ultimoNome + ", " + departamentoNome + ")" + Environment.NewLine;
            DepartamentoNome = departamentoNome;
        }
    }

}
