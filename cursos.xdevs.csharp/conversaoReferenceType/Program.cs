using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conversaoReferenceType
{
    class Program
    {
        static void Main(string[] args)
        {
            Celular celular1 = new Celular();
            Capinha capinha1 = celular1;
            Capinha capinha2 = new Capinha();

            // é permitido converter pois, capinha1 tem celular1.
            Celular celular2 = (Celular)capinha1;

            // Não é permitido pois, pessoa2 é uma PESSOA e não um FUNCIONARIO.
            //Celular celular3 = (Celular)capinha2;

            //Mostra o Operador IS
            #region "Mostrar o operador Is"
            if (capinha1 is Celular) // ==> verificando se é do tipo
            {
                Console.WriteLine("capnha1 é do tipo Celular");
            }

            if (capinha1 is Capinha) // ==> verificando se é do tipo
            {
                Console.WriteLine("capinha1 é do tipo CApinha");
            }

            if (capinha2 is Celular) // ==> verificando se é do tipo
            {
                Console.WriteLine("capinha2 é do tipo Celular");
            }

            if (capinha2 is Capinha) // ==> verificando se é do tipo
            {
                Console.WriteLine("capinha2 é do tipo Capinha");
            }
            #endregion

            //Mostrar o Operador AS
            Capinha capinha3 = celular1;
            Celular celular3 = capinha3 as Celular;

        }
    }

    class Capinha
    {
    }

    class Celular : Capinha
    {
    }
}
