using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace usandoConvert
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            bool b = Convert.ToBoolean(a);
            char c = Convert.ToChar("A");
            byte d = Convert.ToByte(c);
            int e = Convert.ToInt32(d);
        }
    }
}
