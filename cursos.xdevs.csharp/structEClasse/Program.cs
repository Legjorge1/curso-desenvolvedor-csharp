using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace structEClasse
{
    class Program
    {
        static void Main(string[] args)
        {
            //strutura
            DadosStructure dados1 = new DadosStructure(0);
            DadosStructure dados2 = dados1;

            dados1.valor += 1;
            dados2.valor += 2;

            Console.WriteLine(dados1.valor);
            Console.WriteLine(dados2.valor);

            //classe
            DadosClasse dados3 = new DadosClasse(0);
            DadosClasse dados4 = dados3;

            dados3.valor += 1;
            dados4.valor += 2;

            Console.WriteLine(dados3.valor);
            Console.WriteLine(dados4.valor);

            Console.ReadKey();
        }

        
    }

    //==> Value Types ==> Tipos Por Valor
    struct DadosStructure
    {
        public int valor;
        public DadosStructure(int _valor)
        {
            valor = _valor;
        }
        public override string ToString()
        {
            return valor.ToString();
        }
    }

    //==> Reference Types ==> Tipos Por Referencia
    class DadosClasse
    {
        public int valor;
        public DadosClasse(int _valor)
        {
            valor = _valor;
        }
        public override string ToString()
        {
            return valor.ToString();
        }
    }
}
