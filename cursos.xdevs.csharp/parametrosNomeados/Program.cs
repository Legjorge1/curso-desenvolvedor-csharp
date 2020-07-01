using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parametrosNomeados
{
    class Program
    {
        static void Main(string[] args)
        {
            double area = acharArea(comprimento: 35.0, largura: 25.5);
            double area1 = acharArea(largura: 25.5, comprimento: 35.0);
            Console.WriteLine(area);

            //chamar o opcional ao vivo
        }

        //parametro nomeado
        public static double acharArea(double comprimento, double largura)
        {
            return comprimento * largura;
        }

        //parametro opcional
        public void mostrarNome(string primeiro, string inicial = "", string final = "")
        {
            Console.WriteLine(primeiro + " " + inicial + " " + final);
        }
    }
}
