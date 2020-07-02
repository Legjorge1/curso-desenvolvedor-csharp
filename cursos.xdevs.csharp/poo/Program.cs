using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace poo
{
    class Program
    {
        /*
           Regras para uma classe abstrata
           - Não pode ser instanciada. Você não pode criar um objeto a partir de uma classe abstrata.
            - Pode ser herdada e geralmente serve como classe base para outras classes.
            - Pode conter métodos abstratos e métodos comuns. Uma classe abstrata também podem possuir construtores, propriedades, indexadores e eventos.
            - Não pode ser estática (static). Uma classe abstrata não pode ser selada (sealed).
            - Uma classe abstrata pode herdar de outra classe abstrata.
         */

        /*
            Métodos Abstratos:
            -É um método que não possui implementação na classe abstrata. 
                Um método abstrato possui somente a definição de sua assinatura. 
                A sua implementação deve ser feita na classe derivada.
            - É um método virtual e deve ser implementado usando o modificador override.
            - Somente pode existir em uma classe abstrata.
            - Um método abstrato não pode usar os modificadores static e virtual.
            */

        static void Main(string[] args)
        {
            //Vou explicar na aula de sábado, mesmo alguns assuntos, mas para não ficar dúvidas na galera
            //aplicação voltada a classe abstrata, visto na aula (live)
            //ter rolado duas questões

            //Erro acontece
            //Forma f = new Forma();

            Quadrado q = new Quadrado();
            Console.WriteLine(q.Descricao());
            Console.WriteLine("Informando o valor do lado do quadrado em metros.");
            q.Lado = 10;
            q.CalcularArea();
            q.CalcularPerimetro();
            Console.WriteLine("A área do quadrado é : " + q.Area + " m2 ");
            Console.WriteLine("O perímetro do quadrado é : " + q.Perimetro + " m ");
            
            //preste atenção ao método Virtual
            Console.WriteLine(q.MetodoVirtual());

            Triagulo t = new Triagulo();
            Console.WriteLine(t.MetodoVirtual());

            Console.ReadKey();

        }
    }

    //Exemplos e explicação, classe abstrata e override nos métodos
    //virtual ==>   não é possível usar o modificador virtual com os 
    //              modificadores static, abstract, private ou override

    public abstract class Forma
    {
        public string Cor { get;set; }
        public double Area { get; set; }
        public double Perimetro { get; set;  }

        public abstract void CalcularArea(); //Método abstrato
        public abstract void CalcularPerimetro(); //Método abstrato
        public string Descricao()  // ==> não é um método abstrato, mesmo que esteja em uma classe abstrata ( questão levanta )
        {
            return "Sou a classe abstrata Forma, mas não sou um método abstrato.";
        }

        public virtual string MetodoVirtual() {
            return "Declarado o método virtual na classe Abstrata";
        }
    }

    public class Quadrado : Forma
    {
        public double Lado
        {
            get;set;
        }

        public override void CalcularArea() //precisamos de um override, visto ser um método abstrato
        {
            this.Area = Lado * Lado;
        }

        public override void CalcularPerimetro() //precisamos de um override, visto ser um método abstrato
        {
            this.Perimetro = 4 * Lado;
        }

        //Existe um método Virtual que eu não sou obrigado a fazer override, 
        //vou utilizar a execução da classe base

        //método::MetodoVirtual

    }

    public class Triagulo : Forma
    {
        //Somos obrigados a fazer um override
        public override void CalcularArea() //precisamos de um override, visto ser um método abstrato
        {
            //desconsidere o valor do retorno
            this.Area = 5000;
        }

        public override void CalcularPerimetro() //precisamos de um override, visto ser um método abstrato
        {
            //desconsidere o valor do retorno
            this.Perimetro = 10000;
        }

        public override string MetodoVirtual()
        {
            return "Sou o triangulo e quero retornar a informação";
        }
    }
}
