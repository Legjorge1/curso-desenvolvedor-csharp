using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace explicandoStructs
{
    class Program
    {
        static void Main(string[] args)
        {

            int variavelCriada = 10;

            Carro carroStr = new Carro();
            carroStr.Nome = "Fox";
            carroStr.Marca = "VW";
            carroStr.Portas = 5;

            //struct é um tipo (value type), mas um tipo complexo
            Estudante estudante = new Estudante();
            estudante.primeiroNome = "Diogo";

            Livro meuLivro = new Livro("Nome do Livro", "Programação", "Diogo Costa", 10, 1, 112345, "Capa dura");
            //propriedades
            Console.WriteLine(meuLivro.titulo);
            Console.WriteLine(meuLivro.categoria);
            Console.WriteLine(meuLivro.autor);
            Console.WriteLine(meuLivro.numPaginas);
            Console.WriteLine(meuLivro.paginaCorrente);
            Console.WriteLine(meuLivro.ISBN);
            Console.WriteLine(meuLivro.estiloCapa);

            //ações
            meuLivro.proximaPagina();
            meuLivro.voltarPagina();
        }
    }

    struct Carro 
    { 
        public string Nome { get; set; }
        public string Marca { get; set; }
        public int Portas { get; set; }
    }

    struct Estudante
    {
        public string primeiroNome { get; set; }
        public string ultimoNome { get; set; }
        public char inicial { get; set; }
        public double media1 { get; set; }
        public double media2 { get; set; }
        public double media3 { get; set; }
        public double media4 { get; set; }
        public double mediaFinal { get; set; }
    }

    public struct Livro
    {
        public string titulo;
        public string categoria;
        public string autor;
        public int numPaginas;
        public int paginaCorrente;
        public double ISBN;
        public string estiloCapa;

        //Construtor somente com todos as propriedades
        public Livro(string titulo, string categoria, string autor, int numPaginas, int
        paginaCorrente, double isbn, string estilocapa)
        {
            this.titulo = titulo;
            this.categoria = categoria;
            this.autor = autor;
            this.numPaginas = numPaginas;
            this.paginaCorrente = paginaCorrente;
            this.ISBN = isbn;
            this.estiloCapa = estilocapa;
        }
        public void proximaPagina()
        {
            if (paginaCorrente != numPaginas)
            {
                paginaCorrente++;
                Console.WriteLine("A pagina corrente é: " + this.paginaCorrente);
            }
            else
            {
                Console.WriteLine("Final do livro.");
            }
        }
        public void voltarPagina()
        {
            if (paginaCorrente != 1)
            {
                paginaCorrente--;
                Console.WriteLine("Agora a página corrente é: " + this.paginaCorrente);
            }
            else
            {
                Console.WriteLine("Início do livro.");
            }
        }
    }

}
