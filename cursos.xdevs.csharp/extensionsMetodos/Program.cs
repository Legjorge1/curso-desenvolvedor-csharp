using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace extensionsMetodos
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 10;

            Console.WriteLine(i.multiplicarPeloProprioNumero());
            Console.WriteLine(i.cortaPelaMetade());
        }
    }

    public static class meuMetodoDeExtensao
    {
        public static int multiplicarPeloProprioNumero(this int num)
        {
            int result = 0;
            result = num * num;
            return result;
        }

        public static int cortaPelaMetade(this int num)
        {
            int result = 0;
            result = num / 2;
            return result;
        }
    }
}
