using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modificadores
{
    class Program
    {
        static void Main(string[] args)
        {
            classePublica c = new classePublica();
            var bb = c.campo;
            //var cc = c.campo2 //=> não é acessível

            //Privado
            var e = new Empregado();
            //string n = e.nome; //erro de inacessibilidade
            string n = e.GetNome(); // ==> Método
            double s = e.Salario; // ==> Salário
            
            //Protegido
            A a = new A();
            //a.????
            B b = new B();
            Console.WriteLine( b.c );

            //internal
            //cade a ClasseInterna ?
            classes.AcessandoClass1 classeOutrAssembly = new classes.AcessandoClass1();
            classeOutrAssembly.propriedadeExposta = 10; // ==> acesso ok
            //classeOutrAssembly.meuValor // não é acessível

            classes.DerivandoClasse1 classeDerivada = new classes.DerivandoClasse1();
            //classeDerivada.MeuValor //acessivel ok

        }
    }

    public class classePublica
    {
        public string campo { get; set; }
        private string campo2 { get; set; }
    }

    class Empregado
    {
        private int i;
        double d;   // private por padrão

        private string nome = "PrimeiroNome, ÚltimoNome";
        private double salario = 100.0;

        public string GetNome()
        {
            //validações verificaçõa logica
            return nome;
        }

        public double Salario
        {
            get { return salario; }
        }
    }

    //protegido
    class A
    {
        protected int x = 123;
        public void Tal() { }
    }

    class B : A
    {
        public int c
        {
            get {
                Tal();
                return this.x; }
        }
    }

}
