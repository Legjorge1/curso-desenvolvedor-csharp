using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 163;
            Console.WriteLine(string.Format("{0} = {1} ou 0x{2:X} {3:C}", (char)a, a, a, a));

            int Valor = 803;
            string Formato1 = String.Format("{0:C}", Valor); //Moeda
            Console.WriteLine(Formato1);

            string Formato2 = String.Format("{0:C8}", Valor); //Moeda com 8 casas decimais
            Console.WriteLine(Formato2);
            
            string Formato3 = String.Format("{0:D}", Valor); //Decimal
            Console.WriteLine(Formato3);
            
            string Formato4 = String.Format("{0:D15}", Valor); //Decimal com 15 posições (vai zeros a frente p/ completar as posições)
            Console.WriteLine(Formato4);

            string Formato5 = String.Format("{0:E}", Valor); //Exponencial XXX.XXXe+xxx
            Console.WriteLine(Formato5);

            string Formato6 = String.Format("{0:F}", Valor); //Ponto Fixo
            Console.WriteLine(Formato6);

            string Formato7 = String.Format("{0:G}", Valor); //Formato Geral ou Científico
            Console.WriteLine(Formato7);

            string Formato8 = String.Format("{0:N}", Valor); //Numérico
            Console.WriteLine(Formato8);

            string Formato9 = String.Format("{0:N7}", Valor); //Numérico com 7 casas decimais
            Console.WriteLine(Formato9);

            string Formato10 = String.Format("{0:X}", Valor); //Representação Hexadecimal
            Console.WriteLine(Formato10);

            string Formato11 = String.Format("{0:x}", Valor); //Representação Hexadecimal também
            Console.WriteLine(Formato11);

            long CNPJ = 05662546000135;
            string CNPJFormatado = String.Format(@"{0:00\.000\.000\/0000\-00}", CNPJ); //Formatar de Long para CNPJ
            Console.WriteLine(CNPJFormatado);

            long RG = 305617853;
            string RGFormatado = String.Format(@"{0:00\.000\.000\-0}", RG);
            Console.WriteLine(RGFormatado);

        }
    }
}
