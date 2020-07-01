
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiposGenericos
{
    class Program
    {
        static void Main(string[] args)
        {
            ClasseGenerica<int> iAcao = new ClasseGenerica<int>(21);
            iAcao.IdentificaTipoDado();
            ClasseGenerica<decimal> dAcao = new ClasseGenerica<decimal>(21.55m);
            dAcao.IdentificaTipoDado();
            ClasseGenerica<string> sAcao = new ClasseGenerica<string>("xDIDAdev");
            sAcao.IdentificaTipoDado();
            List<string> dsData = new List<string>();
            ClasseGenerica<List<string>> oAction = new ClasseGenerica<List<string>>(dsData);
            oAction.IdentificaTipoDado();
            Console.ReadKey();


            //método genérico
            ClaseMetodoGenerico cmg = new ClaseMetodoGenerico();
            string[] str = { "xdidadev", "Diogo", "Costa", "Santos" };
            var listaRetornada = cmg.CriarLista<string>(str);

            foreach(string s in listaRetornada)
            {
                Console.WriteLine(s);
            }

            Console.ReadKey();

        }
    }

    public class ClasseGenerica<T>
    {
        private T _valor;
        public ClasseGenerica(T valor)
        {
            _valor = valor;
        }
        public void IdentificaTipoDado()
        {
            Console.WriteLine($"O tipo de dados da variável fornecida  é : { _valor.GetType()}");
        }
    }

    class ClaseMetodoGenerico
    {
        public List<T> CriarLista<T>(params T[] pars)
        {
            List<T> lista = new List<T>();
            foreach (T elem in pars)
            {
                lista.Add(elem);
            }

            return lista;
        }
}

}
