using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace IniciandoAsThreads
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = Stopwatch.StartNew();
            // Vamos chamar diferentes métodos
            
            execucaoSequencial(); //18075ms!

            //RodarComThread(); //13301ms

            Console.WriteLine("Nós realizamos o processo em {0}ms!", sw.ElapsedMilliseconds);
            if (Debugger.IsAttached)
            {
                Console.Write("Pressione qualquer botão para terminar . . .");
                Console.ReadKey(true);
            }
        }

        static void execucaoSequencial()
        {
            double result = 0d;
            // Chamar uma função e adicionar o resultado
            result += LerDadosIO();
            // Chamar outra função e adicionar o resultdo
            result += FazerCalculosIntensos();
            // Imprimir o resultado 
            Console.WriteLine("O resultado é {0}", result);
        }

        static double LerDadosIO()
        {
            // Nós estamos simulando I/O colocando nossa thread para dormir.
            Thread.Sleep(5000);
            return 10d;
        }

        static double FazerCalculosIntensos()
        {
            // Nós estamos fazendo calculos intensos
            // com divisões sem sentido
            double result = 100000000d;
            var maxValue = Int32.MaxValue;
            for (int i = 1; i < maxValue; i++)
            {
                result /= i;
            }
            return result + 10d;
        }

        static void RodarComThread()
        {
            double result = 0d;
            // Criar a Thread para ler do I/O
            var thread = new Thread(() => result = LerDadosIO());
            
            //Iniciar a Thread
            thread.Start();

            // Salvar o resultado do calculo em outra variavel
            double result2 = FazerCalculosIntensos();

            // Esperar a Thread terminar
            thread.Join();

            // Calcular o final do resultado
            result += result2;
            Console.WriteLine("O resultado é {0}", result);
        }
    }
}
