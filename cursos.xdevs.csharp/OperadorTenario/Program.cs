using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperadorTenario
{
    class Program
    {
        static void Main(string[] args)
        {
            //OperadorTenario();
            //OperadoresLogicos();
            //OperadoresBoleanos();
        }

        static void OperadorTenario() { 

            // exemplo de utilização de um operador tenário
            Random rnd = new Random();
            int num = 0;
            num = rnd.Next(100); // gera um numero randomico de 1 a 100
                                 // atribui o resultado a variável num
                                 // se o valor do mod (módulo) for igual a zero, 
                                 // ou seja, num % 2 == 0 ( verdadeiro )
                                 // então a atribuição será o primeiro resultado, 
                                 // ao contrário retornará uma string com o valor ímpar (segundo resultado)
            string resultado = num % 2 == 0 ? "par" : "ímpar";    
        }
        static void OperadoresLogicos()
        {
            bool resultado;

            resultado = 1 < 2; //menor
            resultado = 1 > 2; //maior
            resultado = 1 <= 2; //menor ou igual
            resultado = 1 >= 2; //maior ou igual 
            resultado = 1 == 2; //igual 
            resultado = 1 != 2; //Não é igual ( diferente )
        }
        static void OperadoresBoleanos() 
        {
            bool resultado;
            bool a = true;
            bool b = false;
            resultado = a & b; 
            resultado = a | b; 
            resultado = a ^ b; 
            resultado = !a; 
            resultado = a && b; 
            resultado = a || b;
            resultado = a == b;


            //operador bit a bit
            uint aa = 0b_0000_1111_0000_1111_0000_1111_0000_1100;
            uint bb = ~aa;
            Console.WriteLine(Convert.ToString(bb, toBase: 2));

            //Operador de deslocamento a esquerda
            uint x = 0b_1100_1001_0000_0000_0000_0000_0001_0001;
            Console.WriteLine($"Antes: {Convert.ToString(x, toBase: 2)}");

            uint y = x << 4;
            Console.WriteLine($"Depois:  {Convert.ToString(y, toBase: 2)}");
            
            //Operador de deslocamento a direita
            uint xx = 0b_1001;
            Console.WriteLine($"Antes: {Convert.ToString(xx, toBase: 2),4}");

            uint yy = xx >> 2;
            Console.WriteLine($"Depois:  {Convert.ToString(yy, toBase: 2),4}");
        }
    }
}
