using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{

    //public O acesso não é restrito.
    //protected O acesso é limitado à classe que os contém ou aos tipos derivados da classe que os contém.
    //internal O acesso é limitado ao assembly atual.
    //protected internal O acesso é limitado ao assembly atual ou aos tipos derivados da classe que os contém.
    //private O acesso é limitado ao tipo recipiente.
    //private protected O acesso é limitado à classe que o contém ou a tipos derivados da classe que o contém no assembly atual.Disponível desde o C# 7.2.

    internal class ClasseInterna
    {
        public static int intM = 0;
        public int intM2 = 0;
    }

    public class AcessandoClass1
    {
        void TestarAcesso() {
            //Class1.intM //acesso ok
            
            //Class1 classe1 = new Class1();
            //classe1.intM2 //acesso ok
        }

        public int propriedadeExposta { get; set; }

        protected internal int meuValor = 0;
    }

    public class DerivandoClasse1 : AcessandoClass1
    {
        public int MeuValor { get { return this.meuValor; } }
    }


}
