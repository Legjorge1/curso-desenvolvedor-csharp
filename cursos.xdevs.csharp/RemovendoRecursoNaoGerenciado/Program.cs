using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace RemovendoRecursoNaoGerenciado
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Instanciando ConsoleMonitor ....");
            ConsoleMonitor monitor = new ConsoleMonitor();
            monitor.Write();
            monitor.Dispose();
        }
    }




    public class ConsoleMonitor : IDisposable
    {
        const int STD_INPUT_HANDLE = -10;
        const int STD_OUTPUT_HANDLE = -11;
        const int STD_ERROR_HANDLE = -12;

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern IntPtr GetStdHandle(int nStdHandle);

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern bool WriteConsole(IntPtr hConsoleOutput, string lpBuffer,
               uint nNumberOfCharsToWrite, out uint lpNumberOfCharsWritten,
               IntPtr lpReserved);

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern bool CloseHandle(IntPtr handle);

        private bool disposed = false;
        private IntPtr handle;
        private Component component;

        public ConsoleMonitor()
        {
            handle = GetStdHandle(STD_OUTPUT_HANDLE);
            if (handle == IntPtr.Zero)
                throw new InvalidOperationException("A console handle não está habilitado.");

            component = new Component();

            string output = "Construtor da classe ConsoleMonitor.\n";
            uint written = 0;
            WriteConsole(handle, output, (uint)output.Length, out written, IntPtr.Zero);
        }

        // Destrutor ( Finalize )
        ~ConsoleMonitor()
        {
            if (handle != IntPtr.Zero)
            {
                string output = "O Finalizer ConsoleMonitor.\n";
                uint written = 0;
                WriteConsole(handle, output, (uint)output.Length, out written, IntPtr.Zero);
            }
            else
            {
                Console.Error.WriteLine("Finalizar objeto.");
            }
            // Call Dispose with disposing = false.
            Dispose(false);
        }

        public void Write()
        {
            string output = "Executando o método Write.\n";
            uint written = 0;
            WriteConsole(handle, output, (uint)output.Length, out written, IntPtr.Zero);
        }

        public void Dispose()
        {
            string output = "O método Dispose.\n";
            uint written = 0;
            WriteConsole(handle, output, (uint)output.Length, out written, IntPtr.Zero);

            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            string output = String.Format("O método Dispose ({0}).\n", disposing);
            uint written = 0;
            WriteConsole(handle, output, (uint)output.Length, out written, IntPtr.Zero);

            // Execute se os recursos ainda não tiverem sido descartados.
            if (!disposed)
            {
                // Se a chamada for por Dispose, libere os recursos gerenciados.
                if (disposing)
                {
                    Console.Error.WriteLine("Realizando o Disposing dos recursos gerenciados.");
                    if (component != null)
                        component.Dispose();
                }
                // Liberar recursos não gerenciados.
                output = "Disposing de recursos não gerenciados.";
                WriteConsole(handle, output, (uint)output.Length, out written, IntPtr.Zero);

                if (handle != IntPtr.Zero)
                {
                    if (!CloseHandle(handle))
                        Console.Error.WriteLine("Handle não pode ser fechado.");
                }
            }
            disposed = true;
        }
    }
}
