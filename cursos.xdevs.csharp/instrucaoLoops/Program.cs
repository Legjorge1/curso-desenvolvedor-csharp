using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace instrucaoLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            //loopComfor();
            //numerosLoteria();
            //loopComForeach();
            loopWhile();
            loopDoWhile();
        }

        static void loopComfor() 
        {
            //int x ;
            //for(x = 1; x <= 1000; x++)
            //{
            //    Console.WriteLine($"Enviando NF {x} para Prefeitura");
            //    if (x == 10)
            //    {
            //        //logica
            //        break;
            //    }
            //}

            // contar até 10 e incrementar de 2 em 2
            for (int contador = 0; contador <= 10; contador += 2)
            {
                Console.WriteLine(contador);
            }

            // contar até 10 e incrementar de 1 em 1
            for ( int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

            //Vamos falar de incrementar
            //++, --, +=, *=,
        }
        static void numerosLoteria() 
        {
            // variável que vai conter todos os números possíveis
            int[] numerosLoteria = new int[59];
            // variável utilizado para simular os número da loteria
            int[] seusNumeros = new int[6];
            // instanciamos um objeto para poder randomizar os números
            Random rnd = new Random();
            // populamos um range de 1 até 59 
            for (int i = 0; i < 59; i++)
            {
                numerosLoteria[i] = i + 1;
            }
            // pegar 6 números randomicos
            for (int selecionado = 0; selecionado < 6; selecionado++)
            {
                seusNumeros[selecionado] = numerosLoteria[rnd.Next(59)];
            }

            Console.WriteLine("Seus números da loteria são:");
            for (int j = 0; j < 6; j++)
            {
                Console.Write(" " + seusNumeros[j] + " ");
            }
            Console.ReadLine();
        }
        static void loopComForeach() 
        {
            int[] arrayDeInts = new int[] { 78, 89, 90, 76, 98, 65 };
            
            foreach (int numeros in arrayDeInts)
            {
                Console.WriteLine(numeros);
            }

            string[] arrayDeString = new string[] { "item 1", "item 2", "item 3", "item 4", "item 5" };
            foreach (string texto in arrayDeString)
            {
                Console.WriteLine(texto);
            }

            Console.ReadLine();
        }

        static void loopWhile() 
        {
            int valor = 0;
            while (valor <= 10) //Enquanto a variável for menor que 10, execute esse bloco de código
            {
                Console.WriteLine(valor);
                valor++; //se não incremetarmos a váriavel esse loop será eterno
            }

            Console.ReadLine();
        }

        static void loopDoWhile() 
        {
            int valor = 0;
            do //--o bloco será executado inicialmente
            {
                Console.WriteLine(valor);
                valor++; //--incremento
            } while (valor < 10); //--validar se o bloco continuará a ser executado
        }


    }
}
