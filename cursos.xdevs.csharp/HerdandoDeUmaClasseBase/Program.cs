using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerdandoDeUmaClasseBase
{
    /*Construtor de classe herdade, base
     * */

    class Program
    {
        static void Main(string[] args)
        {

            Empregado empregado = new Empregado("Diogo", "Santos", "TI");
            
        }
    }


    public class Pessoa
    {
        public string PrimeiroNome { get; set; }
        public string UltimoNome { get; set; }
        public Pessoa(string primeiroNome, string ultimoNome)
        {
            // Validar o primeiro e o último nome.
            if ((primeiroNome == null) || (primeiroNome.Length < 1))
                throw new ArgumentOutOfRangeException(
                "primeiroNome", primeiroNome,
                "PrimeiroNome dever ser diferente de nulo ou branco.");
            if ((ultimoNome == null) || (ultimoNome.Length < 1))
                throw new ArgumentOutOfRangeException(
                "ultimoNome", ultimoNome,
                "UltimoNome dever ser diferente de nulo ou branco.");
            // guardar o primeiro e o último nome.
            PrimeiroNome = primeiroNome;
            UltimoNome = ultimoNome;
        }

    }
    public class Empregado : Pessoa
    {
        public string DepartamentoNome { get; set; }

        public Empregado(string primeiroNome, string ultimoNome, string departamentoNome) : base (primeiroNome, ultimoNome)
        {
            // Validar o noome do departamento
            if ((departamentoNome == null) || (departamentoNome.Length < 1))
                throw new ArgumentOutOfRangeException("departamentoNome", departamentoNome, 
                    "DepartamentoNome dever ser diferente de nulo ou branco.");
            // Guardar o departamento.
            DepartamentoNome = departamentoNome;
        }
       
    }

}
