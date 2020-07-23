using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RodarThreadPool
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = Stopwatch.StartNew();
            // Vamos chamar diferentes métodos

            RodarComThread(); //15099ms

            Console.WriteLine("Nós realizamos o processo em {0}ms!", sw.ElapsedMilliseconds);
            if (Debugger.IsAttached)
            {
                Console.Write("Pressione qualquer botão para terminar . . .");
                Console.ReadKey(true);
            }
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
            // Criar um work item para ler do I/O
            ThreadPool.QueueUserWorkItem((x) => result += LerDadosIO());
            // Salvar o resultado do calculo em outra variável
            double result2 = FazerCalculosIntensos();
            // Esprar até a thread terminar
            // TODO: Nós precisaremos de uma maneira de indicar
            // quando a thread no ThreadPool estiver finalizado

            // Calcule o resultado final
            result += result2;
            // Imprimir o resultado
            Console.WriteLine("O resultado é {0}", result);
        }
    }
}
