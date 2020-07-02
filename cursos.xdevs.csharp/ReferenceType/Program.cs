
using namespaceDiferente.interno;

namespace ReferenceType
{
    //interface e delegates tmb são referenceType
    class Program
    {
        static void Main(string[] args)
        {
            MinhaClasse minhaClasse = new MinhaClasse();
            MinhaClasse2 minhaClasse2 = new MinhaClasse2();
        }
    }

    class MinhaClasse
    {
        // campos
        // propriedades ( controlar os campos )
        // metodos ( funções )
        // eventos ( acontecimentos ocorridos ), basicamente notifica outros sobre o evento ocorrido
        // event publisher, event subscriber
        // delegates => tipo Referencia que referencia a um método

        // classes aninhadas => outras classes
        class aninhado { 
        
        }
    }
}

namespace namespaceDiferente
{
    namespace interno
    {
        public class MinhaClasse2
        {

        }
    }
        
}