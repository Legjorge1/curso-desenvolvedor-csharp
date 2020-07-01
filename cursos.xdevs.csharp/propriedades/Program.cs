using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace propriedades
{
    class Program
    {
        static void Main(string[] args)
        {
            Estudante estu = new Estudante();
            estu.PrimeiroNome = "Diogo";
            //estu.UltimoNome = "Santos";
        }
    }

    class Estudante
    {
        private string primeiroNome;
        public string PrimeiroNome
        {
            get { return primeiroNome; }
            set { primeiroNome = value; }
        }

        public string UltimoNome { get; private set; }
            
    }
}
