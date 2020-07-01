using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace utilizandoClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Estudante primeiroEstudante = new Estudante();
            
            Estudante.EstudanteQuantidade++;
            Estudante segundoEstudante = new Estudante();
            Estudante.EstudanteQuantidade++;

            primeiroEstudante.primeiroNome = "João";
            primeiroEstudante.ultimoNome = "Pedro";
            primeiroEstudante.grau = "seis";

            segundoEstudante.primeiroNome = "Francisco";
            segundoEstudante.ultimoNome = "Joaquim";
            segundoEstudante.grau = "dois";

            Console.WriteLine(primeiroEstudante.primeiroNome);
            Console.WriteLine(segundoEstudante.primeiroNome);
            Console.WriteLine(Estudante.EstudanteQuantidade);

            //*1
            //metodo 
            primeiroEstudante.mostrarNome();

            //*2 construtor

            //*3
            //escopo de variavel, parametro por valor e por referencia
            int num1 = 2;
            int num2 = 3;
            int result;

            result = somar(num1, num2);
            Console.Write("A Soma é: ");
            Console.WriteLine(result); // 5
            Console.WriteLine();

            trocarValores(num1, num2);
            Console.WriteLine();
            Console.WriteLine("após o trocarValores()");
            Console.WriteLine(num1); //  2
            Console.WriteLine(num2); //  3

            Console.WriteLine();
            Console.WriteLine("O primeiro nome do estudante é " + primeiroEstudante.primeiroNome);
            trocarNome(primeiroEstudante);
            Console.WriteLine();
            Console.WriteLine("O primeiro nome do estudante é  " + primeiroEstudante.primeiroNome);

            //4
            //SobreCarga de Método -- fazer ao vivo uma sobrecarga no construtor
            primeiroEstudante.mostrarNome("Sobrecarregando o método");

        }

        static int somar(int value1, int value2)
        {
            Console.WriteLine("passamos no método somar()");
            return value1 + value2;
        }
        static void trocarValores(int value1, int value2)
        {
            Console.WriteLine("In trocarNome()");
            Console.WriteLine("valor é " + value1); //  2
            Console.WriteLine("valor é " + value2); //  3
            Console.WriteLine();
            Console.WriteLine("Trocando valores");
            value1--;
            value2 += 5;
            Console.WriteLine();
            Console.WriteLine("valor agora é " + value1); //  1
            Console.WriteLine("valor agora é " + value2); //  8
        }
        static void trocarNome(Estudante refValue)
        {
            Console.WriteLine();
            Console.WriteLine("passamos no trocarNome()");
            refValue.primeiroNome = "Jorge";
        }
    }

    class Estudante
    {
        public static int EstudanteQuantidade;
        public string primeiroNome;
        public string ultimoNome;
        public string grau;

        //construtor
        public Estudante(string primeiro, string ultimo, string grau)
        {
            this.primeiroNome = primeiro;
            this.ultimoNome = ultimo;
            this.grau = grau;
        }

        public Estudante()
        {
        }

        //métodos
        public string concatenarNome()
        {
            string nomeCompleto = this.primeiroNome + " " + this.ultimoNome;
            return nomeCompleto;
        }
        public void mostrarNome()
        {
            string nome = concatenarNome();
            Console.WriteLine(nome);
        }
        public void mostrarNome(string texto)
        {
            string nome = texto + " " + concatenarNome();
            Console.WriteLine(nome);
        }

    }
}
