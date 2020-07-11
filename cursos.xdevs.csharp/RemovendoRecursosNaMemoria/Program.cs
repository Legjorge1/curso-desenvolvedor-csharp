using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemovendoRecursosNaMemoria
{
    class Program
    {

        private static int ObjetoNumero = 1;

        static void Main(string[] args)
        {
            // Criar um objeto
            ClasseComDisposible obj = new ClasseComDisposible();
            obj.Nome = "CriarEDispose " + ObjetoNumero.ToString();
            ObjetoNumero++;

            // Dispose o objeto.
            obj.Dispose();


            using (ClasseComDisposible obj3 = new ClasseComDisposible())
            {
                obj3.Nome = "CriarEDispose " + ObjetoNumero.ToString();
                ObjetoNumero++;

                //Ver resposta
            }



        }
    }

    //Interface IDisposible
    class RemovendoRecursosDaMemoria
    {
        //Construtor
        public RemovendoRecursosDaMemoria()
        {

        }

        //Exclicação Garbage Collector


        //Destrutor
        ~RemovendoRecursosDaMemoria() 
        { 
        }
        //Você não vê mas aqui, estamos fazendo um override de um método Finalize
    }


    class ClasseComDisposible : IDisposable
    {
        public string Nome = "";
        public void Dispose()
        {
            LiberarRecursos(true);
        }
        // Destrutor para limpar recursos não gerenciados
        ~ClasseComDisposible()
        {
            LiberarRecursos(false);
        }
        private bool ResourcesAreFreed = false;
        // Limpar recursos.
        private void LiberarRecursos(bool freeManagedResources)
        {
            Console.WriteLine(Nome + ": FreeResources");
            if (!ResourcesAreFreed)
            {
                if (freeManagedResources)
                {
                    // Dispose of managed resources here.
                    Console.WriteLine(Nome + ": Dispose de recursos gerenciados");
                }
                // Dispose de recursos não gerenciados
                Console.WriteLine(Nome + ": Dispose de recursos não gerenciados");
                
                ResourcesAreFreed = true;
                // Nós não precisaremos de destrutor pois
                // nossos recursos foram retirados da memória.
                GC.SuppressFinalize(this);
            }
        }
    }
}
