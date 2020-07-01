using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    //classe abstrata e overriden
    public abstract class Estudante
    {
        public abstract void listarDetalhes();

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
    }

    public class EscolaEstudante : Estudante
    {
        public override void listarDetalhes()
        {
            //definir um retorno ao vivo
            throw new NotImplementedException();
        }
    }

}
