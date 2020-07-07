using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectTostring
{
    class Program
    {
        static void Main(string[] args)
        {

            int i = 523;
            string txt = i.ToString();
            Console.WriteLine(txt);

            float valorFlutuante = 1.23f;
            string txtv = valorFlutuante.ToString("0.00");
            Console.WriteLine(txtv);

            ClassTipoReferencia c = new ClassTipoReferencia() { i = 1, t = "Campo de texto" };
            string cl = c.ToString();
            Console.WriteLine(cl);

        }
    }

    class ClassTipoReferencia
    {
        public int i { get; set; }
        public string t { get; set; }

        //Override do Tostring em aula
    }
}
