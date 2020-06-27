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

            DateTime datanascimento;

            // atribuindo valor a variável
            contador = 0;
            distancia = 4.5f;
            primeiroNome = "Dida";

            //Chamando o método
            Funcao();
            int retorno = FuncaoRetonaValor();

            Console.WriteLine(retorno);
            Console.ReadKey();
        }

        /// <summary>
        /// Função que não retorna valor
        /// </summary>
        static void Funcao()
        {
            //logica de codigo 
        }

        //Cometário para o programador
        static int FuncaoRetonaValor()
        {
            //logicas 

            return 10;
        }


    }
}
