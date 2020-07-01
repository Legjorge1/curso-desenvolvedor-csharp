using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace propriedadeIndexada
{
    class Program
    {
        static void Main(string[] args)
        {
            TempRecord tempRecord = new TempRecord();
            // acessando o indexador
            tempRecord[3] = 58.3F;
            tempRecord[5] = 60.1F;

            // Usando o get 
            for (int i = 0; i < 10; i++)
            {
                System.Console.WriteLine("Elemento #{0} = {1}", i, tempRecord[i]);
            }

            System.Console.WriteLine("Pressione qualquer tecla para sair.");
            System.Console.ReadKey();
        }
    }

    class TempRecord
    {
        // Array de valores de temperatura
        private float[] temps = new float[10] { 56.2F, 56.7F, 56.5F, 56.9F, 58.8F,
                                            61.3F, 65.9F, 62.1F, 59.2F, 57.5F };

        // Para habilitar o cliente validar a o cliente saber o tamanho do array
        // quando acessar o indexador.
        public int Length
        {
            get { return temps.Length; }
        }
        // Declaração do Indexer.
        // Se o index estiver fora dos limites, o erro ocorrerá.
        public float this[int index]
        {
            get
            {
                return temps[index];
            }

            set
            {
                temps[index] = value;
            }
        }
    }
}
