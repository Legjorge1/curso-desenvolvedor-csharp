using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace intrucaoSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            string condicao = "Boa tarde";
            switch (condicao)
            {
                case "Bom dia":
                    Console.WriteLine("bom dia para você");
                    break;
                case "Olá":
                    Console.WriteLine("Olá! tudo bem?");
                    break;
                case "Boa tarde":
                    Console.WriteLine("boa");
                    Console.WriteLine("tarde");
                    break;
                default:
                    Console.WriteLine("boa noite");
                    break;
            }

            int valor = 1;

            switch (valor)
            {
                case 0:
                case 1:
                case 2:
                    Console.WriteLine("caso 0, 1, 2.");
                    break;
                case -1:
                case -10:
                    Console.WriteLine("caso -1 -10.");
                    break;
                    //podemos omitir o default:
            }

            DateTime dt = DateTime.Now;

            switch (dt.DayOfWeek)
            {
                case DayOfWeek.Saturday:
                    {
                        Console.WriteLine("14 Hrs é seu curso");
                        break;
                    }
                case DayOfWeek.Wednesday:
                    {
                        Console.WriteLine("19 Hrs é seu curso");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("é dia de conversar");
                        break;
                    }
            }
        }
    }
}
