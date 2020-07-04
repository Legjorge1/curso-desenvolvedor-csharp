using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conversaoDecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            //erro
            //decimal montante = decimal.Parse("$123,456.78");

            //está em protuguês (pt-BR) cuidar se estiver em outra cultura
            decimal montante1 = decimal.Parse("R$123.456,78",
             NumberStyles.AllowCurrencySymbol |
             NumberStyles.AllowThousands |
             NumberStyles.AllowDecimalPoint);

            Console.WriteLine(montante1);
        }
    }
}
