using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecao_Generica_List
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<int>
            System.Collections.Generic.List<int> listInteiros = new List<int>();
            listInteiros.Add(0);
            listInteiros.Add(3);
            listInteiros.Add(0);
            listInteiros.Add(5);

            List<string> listStrings = new List<string>();
            listStrings.Add("José");
            listStrings.Add("Jordan");
            listStrings.Add("JVictor");
            listStrings.Add("Pachi");
            listStrings.Add("id_akira");

            foreach (var item in listStrings)
            {
                Console.WriteLine(item);
            }

            listStrings.RemoveAt(0);
            listStrings.Remove("Pachi");

            foreach (var item in listStrings)
            {
                Console.WriteLine(item);
            }

            //List<Classe>

            foreach (var item in ListarNoBancoDados())
            {
                Console.WriteLine($"Nome do funcionário é {item} ");
            }


        }

        static List<Funcionario> ListarNoBancoDados() {
            
            List<Funcionario> lista = new List<Funcionario>();

            Funcionario f1 = new Funcionario();
            f1.Nome = "Josué";
            f1.Sobrenome = "Jordan";

            Funcionario f2 = new Funcionario()
            {
                 Nome = "Pachi", Sobrenome = "JVictor"
            };

            lista.Add(f1);
            lista.Add(f2);

            return lista;
        }

    }

    class Funcionario
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }

        public override string ToString()
        {
            return Nome + " " + Sobrenome;
        }
    }
}
