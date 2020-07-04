using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conversoes
{
    class Program
    {

        // máximo valor maxIntValor integers.
        static int maxIntValor = 2147483647;

        static void Main(string[] args)
        {
            // conversões explicitas
            double value1 = 10;
            float value2 = (float)value1;

            // conversões implicitas
            int value3 = 10;
            long value4 = value3;

            //checar
            Console.WriteLine("\nCHECKED saida de valor é: {0}",
                  checarConversao());
            Console.WriteLine("UNCHECKED saida de valor é: {0}",
                              naoChecarMetodo());
        }



        // Usando expressão checked.
        static int checarConversao()
        {
            int z = 0;
            try
            {
                // testamos a operação.
                z = checked(maxIntValor + 10);
            }
            catch (System.OverflowException e)
            {
                // mostrar o erro.
                Console.WriteLine("CHECKED e seu ERRO:  " + e.ToString());
            }
            // o valor z ainda é 0.
            return z;
        }

        // Using uma expressão unchecked
        static int naoChecarMetodo()
        {
            int z = 0;
            try
            {
                // O calculo não está sendo checado
                // e o erro não será capturado.
                z = maxIntValor + 10;
            }
            catch (System.OverflowException e)
            {
                // mostrar o erro.
                Console.WriteLine("UNCHECKED e seu ERRO:  " + e.ToString());
            }
            
            // Devido ao OverflowException não ser executado, 
            // a somade 2147483647 + 10 é
            // retornado como -2147483639.
            return z;
        }
    }
}
