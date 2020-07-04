using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cuidadosConversao
{
    class Program
    {
        static void Main(string[] args)
        {
            //double tmb
            float valor1 = 2.5f;
            decimal valor2 = 2.5m;

            //inteiros
            int valor3 = 2;

            //veja o Tipo que o var atribuiu;
            var resultado1 = valor1 + valor3;

            //erro, precisa converter
            //int resultado2 = valor1 + valor3;

            //poderá perder informação
            int resultado2 = Convert.ToInt32(valor1 + valor3);
        }
    }
}
