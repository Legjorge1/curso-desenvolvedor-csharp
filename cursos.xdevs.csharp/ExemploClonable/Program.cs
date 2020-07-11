using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploClonable
{
    class Program
    {
        static void Main(string[] args)
        {

            Pessoa Joao = new Pessoa()
            {
                PrimeiroNome = "João",
                UltimoNome = "Joaquim"
            };
            Pessoa Maria = new Pessoa()
            {
                PrimeiroNome = "Maria",
                UltimoNome = "Joaquina"
            };
            Pessoa Joao2 = (Pessoa)Joao.Clone();

        }
    }

    class Pessoa : ICloneable
    {
        public string PrimeiroNome { get; set; }
        public string UltimoNome { get; set; }

        public object Clone()
        {
            Pessoa pessoa = new Pessoa();
            pessoa.PrimeiroNome = PrimeiroNome;
            pessoa.UltimoNome = UltimoNome;

            return pessoa;
        }
    }
}
