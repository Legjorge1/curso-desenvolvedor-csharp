using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DelegateMetodoStaticEInstanciado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Criar algumas pessoas.
            Pessoa alice = new Pessoa() { Nome = "Alice" };
            Pessoa bob = new Pessoa() { Nome = "Bob" };
            
            //registrando os delegates
            alice.metodoInstanciado = alice.retornaNome;
            alice.metodoStatic = Pessoa.StaticNome;
            
            bob.metodoInstanciado = alice.retornaNome;
            bob.metodoStatic = Pessoa.StaticNome;
            
            //resultados
            string result = "";
            result += "Alice =>  métodoInstanciado retornou: " + alice.metodoInstanciado() +
            Environment.NewLine;
            result += "Bob =>  métodoInstanciado retornou: " + bob.metodoInstanciado() +
            Environment.NewLine;
            result += "Alice => métodoStatic retornou: " + alice.metodoStatic() +
            Environment.NewLine;
            result += "Bob => métodoStatic retornou: " + bob.metodoStatic();
            resultsTextBox.Text = result;
            resultsTextBox.Select(0, 0);
        }
    }



    class Pessoa
    {
        public string Nome;
        // Um método que retorna uma string
        public delegate string retornaStringDelegate();
        // um método statico.
        public static string StaticNome()
        {
            return "método estático";
        }
        // retorna o nome mas somente instanciado.
        public string retornaNome()
        {
            return Nome;
        }
        // Variáveis do tipo retornaStringDelegate.
        public retornaStringDelegate metodoStatic;
        public retornaStringDelegate metodoInstanciado;
    }
}
