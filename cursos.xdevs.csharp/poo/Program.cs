using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace poo
{
    class Program
    {
        static void Main(string[] args)
        {
            Estudante teste1 = new FaculdadeEstudante();
            Estudante teste2 = new FaculdadeEstudante();

            teste1.listarDetalhes();
            teste2.listarDetalhes();
        }
    }


    //classe abstrata e overriden
    public abstract class Estudante
    {
        public abstract void listarDetalhes();
        public abstract int valorSalario();

        //não pode ter métodos em classes abstratas, a nao ser métodos abstratos
    }

    public class FaculdadeEstudante : Estudante
    {
        string nome;
        string faculdade;
        public override void listarDetalhes()
        {
            Console.WriteLine(nome + " " + faculdade);
        }

        public override int valorSalario()
        {
            return 10000;
        }
    }

    public class EscolaEstudante : Estudante
    {
        public override void listarDetalhes()
        {
            Console.WriteLine("estudante da escola");
        }

        public override int valorSalario()
        {
            return 100;
        }
    }

}
