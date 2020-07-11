using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploYeld
{
    class Program
    {
        static List<string> paises = new List<string> { "Brasil", "Argentina", "Colombia", "EUA", "México", "Japão" };
        static void Main(string[] args)
        {
            //sem yield
            IEnumerable<string> resultado = RetornarPaisesComMenosDe5_v1();
            foreach (var nome in resultado)
            {
                Console.WriteLine(nome);
            }

            //com yield
            IEnumerable<string> resultado2 = RetornarPaisesComMenosDe5_v1();
            foreach (var nome in resultado2)
            {
                Console.WriteLine(nome);
            }

            Console.ReadKey();
        }

        static IEnumerable<string> RetornarPaisesComMenosDe5_v1()
        {
            //adicionamos na lista e retornamos
            List<string> temp = new List<string>();
            foreach (var pais in paises)
            {
                if (pais.Length > 5)
                {
                    temp.Add(pais);
                }
            }
            return temp;
        }

        //Sem lista temporária
        static IEnumerable<string> RetornarPaisesComMenosDe5_v2()
        {
            foreach (var pais in paises)
            {
                if ( pais.Length > 5)
                {
                    yield return pais;
                }
            }
        }
    }
}
