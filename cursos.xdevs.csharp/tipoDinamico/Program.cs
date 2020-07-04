using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tipoDinamico
{
    class Program
    {
        static void Main(string[] args)
        {
            string texto = "Valor: {0}, Tipo: {1}";

            dynamic MyDynamicVar = 100;
            Console.WriteLine(texto, MyDynamicVar, MyDynamicVar.GetType());

            MyDynamicVar = "Olá mundo!!";
            Console.WriteLine(texto, MyDynamicVar, MyDynamicVar.GetType());

            MyDynamicVar = true;
            Console.WriteLine(texto, MyDynamicVar, MyDynamicVar.GetType());

            MyDynamicVar = DateTime.Now;
            Console.WriteLine(texto, MyDynamicVar, MyDynamicVar.GetType());
        }
    }
}

