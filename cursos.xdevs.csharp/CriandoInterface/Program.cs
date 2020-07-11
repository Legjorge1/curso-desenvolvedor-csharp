using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriandoInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            //implementação de interface implicita
            Estudante estudante = new Estudante();
            
            //acessamos os cursos;
            estudante.Cursos = new List<string>();


            //se voce implementar a interface explicitamente, voce precisara acessar os membros atraves da interface
            Cliente cliente = new Cliente();
            //cliente. não acho os membros

            IEstudante clienteEstudante = cliente;
            clienteEstudante.Cursos = new List<string>();
            clienteEstudante.MostrarGrade();
        }
    }

    /* Uma interface não pode declarar dados de instância, como campos, 
     * propriedades implementadas automaticamente ou eventos semelhantes a propriedades
     * */

    //Uma interface é parecido com uma classe que especifica propriedades, métodos e eventos, mas ela não implementa o código
    //Interface é um contrato
    public interface IEstudante
    {
        // Lista dos cursos matriculados.
        List<string> Cursos { get; set; }
        // Printar a grade do curso do estudante.
        void MostrarGrade();


        //mostrar implementação em aula
        //decimal RetornarSalario();


    }


    public class Estudante : Pessoa, IEstudante
    {
        public Estudante()
        {

        }

        // Implementa IEstudante.Courses.
        // Lista dos cursos matriculados.
        public List<string> Cursos { get; set; }

        // Implementa IEstudante.MostrarGrade.
        // Método que mostraremos a grade.
        public void MostrarGrade()
        {
            // Faremos o que é necessário...
        }
    }

    public class Cliente : Pessoa, IEstudante
    {
        public Cliente()
        {

        }

        List<string> IEstudante.Cursos { get; set; }

        void IEstudante.MostrarGrade()
        {
            // Faremos o que é necessário...
        }
    }

    public class Pessoa
    {
        //nossa classe
    }
}
