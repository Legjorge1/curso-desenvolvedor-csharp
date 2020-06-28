using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enumeracao
{
    class Program
    {
        //inicia no 0
        //trabalha com inteiro
        enum Meses1 { Jan, Feb, Mar, Apr, Mai, Jun, Jul, Ago, Set, Otu, Nov, Dec };
        enum Meses2 { Jan = 1, Feb, Mar, Apr, Mai, Jun, Jul, Ago, Set, Otu, Nov, Dec };
        enum Meses3 : byte { Jan = 1, Feb, Mar, Apr, Mai, Jun, Jul, Ago, Set, Otu, Nov, Dec };

        static void Main(string[] args)
        {
            string nome = Enum.GetName(typeof(Meses2), 8);
            Console.WriteLine("Oitavo mes nesse enum é: " + nome);
            Console.WriteLine("veja os valores dos meses no enum:");
            foreach (int values in Enum.GetValues(typeof(Meses2)))
            {
                Console.WriteLine(values);
            }
        }
    }
}
