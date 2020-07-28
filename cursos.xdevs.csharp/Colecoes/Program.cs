using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecoes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Facilidade, mas temos de tomar cuidado com os tipos

            //Adiciona qualquer objeto
            System.Collections.ArrayList arrayList = new ArrayList();
            arrayList.Add("string");
            arrayList.Add(2);
            arrayList.Add(true);

            //Chave valor
            System.Collections.Hashtable hashTable = new Hashtable();
            hashTable.Add("Key", "Value");
            hashTable.Add("Chave", "Valor");
            hashTable.Add("Chave", 23);

            //Fila - FIFO
            System.Collections.Queue queue = new Queue();
            queue.Enqueue("objeto");
            queue.Enqueue(123);
            queue.Enqueue(new { Campo = "Texto", OutroCampo = "outroCampo"});

            //Sorted
            System.Collections.SortedList sorted = new SortedList();
            sorted.Add("Chave", "Valor");
            sorted.Add(1, "Valor");
            sorted.Add(true, 098);

            //Stack FILO
            System.Collections.Stack stack = new Stack();
            stack.Push("Olá");
            stack.Push("Tudo");
            stack.Push("Bem");
            stack.Push(654);
            stack.Push(DateTime.Now);

        }
    }
}
