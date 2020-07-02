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
            acharArea(35.5, 25.3);

            double area = acharArea(comprimento: 35.0, largura: 25.5);
            double area1 = acharArea(largura: 25.5, comprimento: 35.0);
            Console.WriteLine(area);

            mostrarNome("Diogo");
            mostrarNome("Diogo", "X");
            mostrarNome("Diogo", "X","Ultimo nome");

        }

        //parametro nomeado
        public static double acharArea(double comprimento, double largura)
        {
            return comprimento * largura;
        }

        //parametro opcional
        public static void mostrarNome(string primeiro, string inicial = "D", string final = "")
        {
            Console.WriteLine(primeiro + " " + inicial + " " + final);
        }
    }
}
