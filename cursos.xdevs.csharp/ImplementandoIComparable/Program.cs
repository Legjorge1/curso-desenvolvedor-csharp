using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementandoIComparable
{
    class Program
    {
        static void Main(string[] args)
        {

            


        }

    }

    //==> Comparar por um campo

    public class Carro : IComparable
    {
        public string Nome { get; set; }
        public int MaximaPotencia { get; set; }
        public int Cavalos { get; set; }
        public decimal Preco { get; set; }

        //comparar objetos
        public int CompareTo(object obj)
        {
            if (!(obj is Carro))
                throw new ArgumentException("Objeto não é um carro Carro");
            Carro other = obj as Carro;
            return Nome.CompareTo(other.Nome);
        }


    }

    public class Carro2 : IComparable<Carro2>
    {
        public string Nome { get; set; }
        public int MaximaPotencia { get; set; }
        public int Cavalos { get; set; }
        public decimal Preco { get; set; }

        //comparar objetos
        public int CompareTo(Carro2 obj)
        {
            return this.Nome.CompareTo(obj.Nome);
        }

    }

}
