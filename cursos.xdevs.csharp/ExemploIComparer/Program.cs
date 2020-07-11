using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploIComparer
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> dinossauros = new List<string>();
            dinossauros.Add("São Paulo");
            dinossauros.Add("Santos");
            dinossauros.Add("Corinthians");
            dinossauros.Add("Palmeiras");
            Mostrar(dinossauros);

            DinoComparer dc = new DinoComparer();

            Console.WriteLine("\nSort com comparer:");
            dinossauros.Sort(dc);
            Mostrar(dinossauros);

            ProcurarEAdicionar(dinossauros, "Flamengo", dc);
            Mostrar(dinossauros);

            ProcurarEAdicionar(dinossauros, "Fluminense", dc);
            Mostrar(dinossauros);

            ProcurarEAdicionar(dinossauros, "Vasco", dc);
            Mostrar(dinossauros);

            ProcurarEAdicionar(dinossauros, null, dc);
            Mostrar(dinossauros);
        }

        private static void ProcurarEAdicionar(List<string> list, string insert, DinoComparer dc)
        {
            Console.WriteLine("\nBinarySearch e Inserção \"{0}\":", insert);

            int index = list.BinarySearch(insert, dc);

            if (index < 0)
            {
                list.Insert(~index, insert);
            }
        }

        private static void Mostrar(List<string> list)
        {
            Console.WriteLine();
            foreach (string s in list)
            {
                Console.WriteLine(s);
            }
        }
    }


    //==> Comparar por vários meios

    public class DinoComparer : IComparer<string>
    {
        public int Compare(string x, string y)
        {
            if (x == null)
            {
                if (y == null)
                {
                    // Se x é nulo e y é nulo
                    return 0;
                }
                else
                {
                    // Se x é nulo e y não é nulo e maior
                    return -1;
                }
            }
            else
            {
                // Se x não é nulo
                if (y == null)
                // e y é nulo, x é maior.
                {
                    return 1;
                }
                else
                {
                    // ...e y não é nulo, compare o
                    // tamanho de duas strings.
                    //
                    int retval = x.Length.CompareTo(y.Length);

                    if (retval != 0)
                    {
                        // Se string as strings não são iguais no tamanho,
                        return retval;
                    }
                    else
                    {
                        // Se as strings tem o tamanho igual,
                        // compare.
                        return x.CompareTo(y);
                    }
                }
            }
        }
    }
}
