using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace stringVsString
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "Olá mundo";
            String str2 = "Olá mundo";

            Console.WriteLine(str1);
            //string é um alias do String
            //UTF-16 =. um formato de encoding que grava 16bits cada caracter
            //tipo imutável
            
            //outra string em memória
            string str3 = str1.ToUpper();
            Console.WriteLine(str3);

            //ficar manipulando string pode impactar muitos processos na memória,
            //se precisar realizar muitas concatenações usaremos o Stringbuilder

            //Construtor da string
            for (int i = 1; i < 10; i++)
            {
                string str4 = new string(' ', 4 * i);

                // ==> i.Tostring() => convertemos uma variável int em string
                Console.WriteLine(str4 + i.ToString());
            }

            //Campos //propriedades //metodos
            #region "Verificando se uma string está vazia"
            string numero = "                 ";
            if (numero != string.Empty)
            {
                Console.WriteLine("numero não está vazio");
            }

            //
            if (!string.IsNullOrWhiteSpace(numero))
            {
                Console.WriteLine("numero também não está vazio");
            }

            if (str3 != "")
            {
                Console.WriteLine("str3 também não está vazio");
            }
            #endregion

            Console.WriteLine(str3.Replace('O', 'X'));
            Console.WriteLine(str3.PadLeft(20, '0'));


            //Tamanho de uma string 9 quantidade de caracteres
            Console.WriteLine("Quantidade de caracteres na str3 - " + str3.Length);

            //transformar uma string em um Array de char
            string str5 = "programando em c#";
            char[] caracteres = str5.ToCharArray();
            for (int i = 0; i < caracteres.Length; i++)
                if (i % 2 == 0) caracteres[i] = char.ToUpper(caracteres[i]);
                else caracteres[i] = char.ToLower(caracteres[i]);
            str5 = new string(caracteres);
            Console.WriteLine("str5: " + str5);


            //string Join
            string[] diasemanas =
            {
             "Segunda", "Terça", "Quarta",
             "Quinta", "Sexta", "Sabado",
             "Domingo"
            };
            string todosDias = string.Join(",", diasemanas); //retorna um string

            Console.WriteLine(todosDias);

            //string split
            char[] delimitador = { ',', '-' };
            string valores = "12-21,,33-17,929";
            string[] campos = valores.Split(delimitador, StringSplitOptions.RemoveEmptyEntries); //retorna no array

            foreach (string item in campos)
            {
                Console.WriteLine(item);
            }
        }
    }
}
