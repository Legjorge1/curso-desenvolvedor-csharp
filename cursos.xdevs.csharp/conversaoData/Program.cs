using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conversaoData
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);

            //Em ingles
            Console.WriteLine(DateTime.Parse("3:45 PM April 1, 2014").ToString());
            Console.WriteLine(DateTime.Parse("1 apr 2014 15:45").ToString());
            Console.WriteLine(DateTime.Parse("15:45 4/1/14").ToString());
            Console.WriteLine(DateTime.Parse("3:45pm 4.1.14").ToString());


            var cultureInfo = new CultureInfo("pt-BR");
            string dateString = "11 set 2020";
            var dateTime = DateTime.Parse(dateString, cultureInfo,
                                            DateTimeStyles.NoCurrentDateDefault);
            Console.WriteLine(dateTime);
        }
    }
}
