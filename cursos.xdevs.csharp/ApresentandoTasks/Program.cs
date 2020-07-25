using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApresentandoTasks
{
    class Program
    {
        const int NUMERO_DE_INTERACOES = 3;

        static void Main(string[] args)
        {
            Stopwatch sw = Stopwatch.StartNew();

            //RodarSequencias(); //51806ms
            //RodarTasks(); //861ms
            //RodarTasksCorretamente(); //18591ms

            //RodarParallelFor(); //21895ms
            //RodarParallelForCorretamente(); //21448ms

            Console.WriteLine("Terminamos em {0}ms!", sw.ElapsedMilliseconds);
            Console.ReadKey();
        }

        static void RodarSequencias()
        {
            double result = 0d;
            // Aqui vamos chamar o método várias vezes.
            for (int i = 0; i < NUMERO_DE_INTERACOES; i++)
            {
                Console.Write(i.ToString() + ", ");

                result += FazerCalculosIntensos();
            }
            // Printando o resultado
            Console.WriteLine("0) O resultado é {0}", result);
        }

        static double FazerCalculosIntensos()
        {
            // Nós estamos fazendo calculos intensos
            // com divisões sem sentido
            //double result = 100000000d;
            double result = 10d;
            var maxValue = Int32.MaxValue;
            for (int i = 1; i < maxValue; i++)
            {
                result /= i;
            }
            return result + 10d;
        }

        static void RodarTasks()
        {
            double result = 0d;
            Task[] tasks = new Task[NUMERO_DE_INTERACOES];
            // A cada interação criamos uma task 
            for (int i = 0; i < NUMERO_DE_INTERACOES; i++)
            {
                Console.Write(i.ToString() + ", ");

                tasks[i] = Task.Run(() => result += FazerCalculosIntensos());
            }
            // Printar o resultado
            Console.WriteLine("1) O Resultado é {0}", result);
        }

        static void RodarTasksCorretamente()
        {
            double result = 0d;
            Task<double>[] tasks = new Task<double>[NUMERO_DE_INTERACOES];
            // Vamos criar as tasks por cada interação
            for (int i = 0; i < NUMERO_DE_INTERACOES; i++)
            {
                Console.Write(i.ToString() + ", ");

                tasks[i] = Task.Run(() => FazerCalculosIntensos());
            }
            // Vamos esperar as tasks terminarem
            Task.WaitAll(tasks);
            // Nós coletaremos os resultados
            foreach (var task in tasks)
            {
                result += task.Result;
            }
            // Printar o resultado
            Console.WriteLine("2) O resultado é {0}", result);
        }

        static void RodarParallelFor()
        {
            double result = 0d;
            // Aqui fazermos a chamada do método várias vezes em paralelo.
            Parallel.For(0, NUMERO_DE_INTERACOES, i => {
                result += FazerCalculosIntensos();
                Console.Write(i.ToString() + ", ");
            });
            // Printando o resultado
            Console.WriteLine("O Resultado {0}", result);
        }


        //public static ParallelLoopResult For<TLocal>(
        //int fromInclusive,
        //int toExclusive,
        //Func<TLocal> localInit,
        //Func<int, ParallelLoopState, TLocal, TLocal> body,
        //Action<TLocal> localFinally
        //)
        static void RodarParallelForCorretamente()
        {
            double result = 0d;
            // Aqui chamamos o método várias vezes.
            //for (int i = 0; i < NUMERO_DE_INTERACOES; i++)
            Parallel.For(0, NUMERO_DE_INTERACOES,
            // Func<TLocal> localInit,
            () => 0d,
            // Func<int, ParallelLoopState, TLocal, TLocal> corpo,
            (i, state, interimResult) => interimResult + FazerCalculosIntensos(),
            // Passo final depois dos calculos
            // nós adicionaremos o resultado ao outro resultado
            // Action<TLocal> localFinally
            (lastInterimResult) => result += lastInterimResult
            );
            // Printando o resultado
            Console.WriteLine("O resultado é {0}", result);

        }
    }
}
