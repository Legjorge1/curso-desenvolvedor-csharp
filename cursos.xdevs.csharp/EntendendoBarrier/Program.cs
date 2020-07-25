using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EntendendoBarrier
{
    //https://docs.microsoft.com/pt-br/dotnet/standard/threading/how-to-synchronize-concurrent-operations-with-a-barrier
    /*
     * Uma Barrier é um objeto que impede que as tarefas individuais em uma operação paralela continuem até que todas as 
     * tarefas atinjam a barreira. É útil quando uma operação paralela ocorre em fases e cada fase requer a sincronização 
     * entre as tarefas. Neste exemplo, há duas fases para a operação. Na primeira fase, cada tarefa preenche sua seção do 
     * buffer com dados. Quando cada tarefa termina de preencher sua seção, a tarefa sinaliza a barreira que ela está pronta 
     * para continuar e, em seguida, aguarda. Quando todas as tarefas sinalizarem a barreira, elas serão desbloqueadas e a 
     * segunda fase começará. A barreira é necessária porque a segunda fase requer que cada tarefa tenha acesso a todos os 
     * dados que foram gerados até este ponto. Sem a barreira, as primeiras tarefas a serem concluídas podem tentar ler de 
     * buffers que ainda não foram preenchidos por outras tarefas. Você pode sincronizar qualquer número das fases dessa maneira.
     * */

    class Program
    {
        static void Main(string[] args)
        {
            var participantes = 5;
            Barrier barrier = new Barrier(participantes + 1,
            // Nós adicionamos a thread principal.
            b =>
            { // Esse método somente é chamado quando todos os participantes chegaram.
                Console.WriteLine("{0} participantes estão em São Paulo {1}.",
                b.ParticipantCount - 1, // Nós subtraimos a thread principal.
                b.CurrentPhaseNumber);
            });
            for (int i = 0; i < participantes; i++)
            {
                var localCopy = i;
                Task.Run(() =>
                {
                    Console.WriteLine("Participante {0} deixou o ponto A!", localCopy);
                    Thread.Sleep(1000 * localCopy + 1); // está realizando alguma lógica
                    if (localCopy % 2 == 0)
                    {
                        Console.WriteLine("Participante {0} chegou no ponto B!", localCopy);
                        barrier.SignalAndWait();
                    }
                    else
                    {
                        Console.WriteLine("Participante {0} mudou de idéia e foi embora!", localCopy);
                        barrier.RemoveParticipant();
                        return;
                    }
                    Thread.Sleep(1000 * (participantes - localCopy)); // Está realizando alguma lógica
                    Console.WriteLine("Participantes {0}chegaram ao ponto C!", localCopy);
                    barrier.SignalAndWait();
                });
            }
            Console.WriteLine("Thread principal {0} está aguardando os participantes!",
            barrier.ParticipantCount - 1);
            barrier.SignalAndWait(); // Aguardando a primeira fase
            barrier.SignalAndWait(); // Aguardando a segunda fase
            Console.WriteLine("Thread está finalizada!");
            Console.ReadKey();
        }
    }
}
