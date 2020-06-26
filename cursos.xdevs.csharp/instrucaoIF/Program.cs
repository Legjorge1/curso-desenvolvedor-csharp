using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace instrucaoIF
{
    class Program
    {
        static void Main(string[] args)
        {
            bool condicao1 = true;
            bool condicao2 = false;
            bool condicao3 = true;

            //#1
            //desnecessário escrever condicao1 == true
            if (condicao1) // se o teste é verdade, então esse bloco será executado.
            {
                Console.WriteLine("IF executado");
            }

            //#2
            if (condicao2)
            {
                //determinamos que a condição 2 é falsa, logo esse código não 
                //será executado
            }
            else
            {
                Console.WriteLine("Else executado");
            }

            //#3 => podemos realizar quantos testes forem necessários
            if (condicao1 && condicao2 || condicao3)
            {
                
            } 
            else if (!condicao3) 
            { 
            
            }
            else if (3 > 4)
            {

            }
            //posso não colocar o bloco else se eu não quiser

            //#4
            //bloco normal if
            if (1 > 2)
            {

            }
            else if (condicao2)
            {

            }
            else if (condicao3)
            {

            }
            else
            {

            }
        }
    }
}
