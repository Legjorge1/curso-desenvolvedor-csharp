using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boxxinUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            // inteiro i.
            int i = 10;
            // Box i.
            object iObject = i; //jogamos an Heap
            //object iObject = (object)i; //o que realmente acontece

            int j = (int)iObject; //unboxing
        }
    }
}
