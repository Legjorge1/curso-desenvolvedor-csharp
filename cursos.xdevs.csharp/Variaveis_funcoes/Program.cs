using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variaveis_funcoes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaração de variáveis
            int contador;
            float distancia;
            string primeiroNome;

            // atribuindo valor a variável
            contador = 0;
            distancia = 4.5f;
            primeiroNome = "Dida";

            //Chamando o método
            FuncaoRetonaValor();
        }



        /// <summary>
        /// Função que não retorna valor
        /// </summary>
        static void Funcao()
        {

        }

        //Cometário para o programador
        static int FuncaoRetonaValor()
        {
            return 0;
        }


    }
}
