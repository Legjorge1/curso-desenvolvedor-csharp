using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasksEContinue
{
    class Program
    {
        static void Main(string[] args)
        {
            //Roda uma após a outra
            Console.WriteLine("-----| Exemplo 1 |------");
            Passo1();
            Passo2();
            Passo3();

            //Não conseguimos ter certeza, qual função será executada primeiro
            Console.WriteLine("-----| Exemplo 2 |------");
            Parallel.Invoke(Passo1, Passo2, Passo3);


            //Controlando o momento que irá continuar ( vai rodar a 1 e a 2 sem eu saber em qual momento
            //mas a task 3 irá executar após a task 1
            Console.WriteLine("-----| Exemplo 3 |------");
            Task passo1Task = Task.Run(() => Passo1());
            Task passo2Task = Task.Run(() => Passo2());
            Task passo3Task = passo1Task.ContinueWith((taskAnterior) => Passo3());
            Task.WaitAll(passo2Task, passo3Task); //Imagine que eu quero esperar as Tasks terminarem,
                                                  //mas eu não preciso esperar a task 1 terminar, pois, a quando a task 3 terminar a um já 
                                                  //havia terminado com certeza.

            Console.WriteLine("-----| Exemplo 4 |------");
            Task _paTask1 = Task.Run(() => Passo1()); 
            Task _paTask2 = Task.Run(() => Passo2());
            Task _paTask3 = Task.Factory.ContinueWhenAll(
            new Task[] { _paTask1, _paTask2 }, //1° arrays de tasks
            (previousTasks) => Passo3()); //2° delegate, que vai executar quando as tasks do primeiro parametro finalizarem 
            _paTask3.Wait(); //aguardar terminar

            //
            Task _ptask1 = Task.Run(() => Passo1());
            Task _ptask2 = Task.Run(() => Passo2());
            Task _ptask3 = Task.Factory.ContinueWhenAny(
            new Task[] { _ptask1, _ptask2 }, //1° 
            (taskAnterior) => Passo3()); //2º se tiver retorno no primeiro parametro, voce poderá acessálo na variável taskAnterior
            _ptask3.Wait();


            Console.ReadKey();
        }
        static void Passo1()
        {
            Console.WriteLine("Passo1");
        }
        static void Passo2()
        {
            Console.WriteLine("Passo2");
        }
        static void Passo3()
        {
            Console.WriteLine("Passo3");
        }
    }
}
