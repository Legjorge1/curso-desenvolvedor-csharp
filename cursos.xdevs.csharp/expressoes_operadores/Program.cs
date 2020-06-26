using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace expressoes_operadores
{
    class Program
    {
        static void Main(string[] args)
        {
            // bool 
            bool resultado = true; // sempre é uma boa prática inicializar sua variável
                               
            resultado = 2 < 3; // resultado irá conter o valor true/verdadeiro
            resultado = 2 > 3; // resultado irá conter o valor false/falso
            resultado = !resultado; // resultado terá o valor inverso
        }

    }
}
