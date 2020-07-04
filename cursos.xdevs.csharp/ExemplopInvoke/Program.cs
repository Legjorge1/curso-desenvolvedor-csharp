using System;
using System.Runtime.InteropServices;

namespace ExemplopInvoke
{
    class Program
    {
        // Importar a dll user32.dll (contendo a funcção que precisamos) 
        // definimos um método que corresponda ao nativo
        [DllImport("user32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        private static extern int MessageBox(IntPtr hWnd, string lpText, string lpCaption, uint uType);

        static void Main(string[] args)
        {
            // Invoke :: invocando a função,.
            // nosso código pe gerenciavel e a dll não é
            MessageBox(IntPtr.Zero, "mensagem enviada pelo nosso CLI", "Título da mensagem!", 0);

        }
    }
}
