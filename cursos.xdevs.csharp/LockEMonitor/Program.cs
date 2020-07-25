using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LockEMonitor
{
    class Program
    {
        static readonly object _object = new object();

        static void Main(string[] args)
        {
            //não dá para garantir que está pegando o valor correto
            for (int i = 0; i < 10; i++)
            {
                new Thread(RecursoLidoPelasThreads).Start();
            }

            Console.ReadKey();
        }

        //static void RecursoLidoPelasThreads() {
        //    //veja o resultado
        //    Thread.Sleep(100);
        //    Console.WriteLine(Environment.TickCount);
        //}

        //static void RecursoLidoPelasThreads() {
        //    //veja o resultado
        //    lock (_object)
        //    {
        //        Thread.Sleep(100);
        //        Console.WriteLine(Environment.TickCount);
        //    }
        //}
        static void RecursoLidoPelasThreads() {
            //veja o resultado
            Monitor.Enter(_object);
            try
            {
                Thread.Sleep(100);
                Console.WriteLine(Environment.TickCount);
            }
            finally  
            {  
                Monitor.Exit(_object);  
            }
}


    }
}
