using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace convertendoValores
{
    class Program
    {
        static void Main(string[] args)
        {
            //converte de tipos incompativeis

            //Parsing
            bool verdadeiro = bool.Parse("true");

            if ( verdadeiro ) { 
                Console.WriteLine("verdadeiro"); 
            } else { 
                Console.WriteLine("falso"); 
            }

            try
            {
                //o correto é usar a string: false, mas errei e coloquei em PT-br
                bool falso = bool.Parse("falso");
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }

            try
            {
                //o correto é usar a string: false, mas errei e coloquei em PT-br
                bool verdadeiro2;
                bool.TryParse("1", out verdadeiro2);

                if (!verdadeiro2)
                {
                    Console.WriteLine("Não foi verdadeiro");

                    bool.TryParse("true", out verdadeiro2);
                    Console.WriteLine($"e agora é: {verdadeiro2}");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            //varios tipos tem o método Parse para ajudar nas conversões
            int.Parse("8");
            short.Parse("888");
        }
    }
}
