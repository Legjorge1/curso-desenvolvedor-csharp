using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Assincronos_Sincrono
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public  double SimulandoMetodoDemorado()
        {
            Thread.Sleep(2000);
            return 10d;
        }

        public Task<double> SimulandoMetodoDemoradoAsync()
        {
            return Task.Run(new Func<Double>(SimulandoMetodoDemorado));
        }

        private void btnSincrono_Click(object sender, RoutedEventArgs e)
        {
            lblResultado.Content = SimulandoMetodoDemorado();
        }

        private async void btn_Copy_Click(object sender, RoutedEventArgs e)
        {
            lblResultado.Content = await SimulandoMetodoDemoradoAsync();
        }

        private void btn2Sincrono_Click(object sender, RoutedEventArgs e)
        {
            PegarDados();
        }

        private void btn2Assync_Click(object sender, RoutedEventArgs e)
        {
            PegarDadosAsync();
        }

        void PegarDados() {
            lblum.Content = SimulandoMetodoDemorado();
            lbldois.Content = SimulandoMetodoDemorado();
        }

        private async Task PegarDadosAsync() {
            //lblum.Content = await SimulandoMetodoDemoradoAsync(); //aguarda para ir até a próxima linha
            //lbldois.Content = await SimulandoMetodoDemoradoAsync();

            //Exemplo 1
            //var task1 = SimulandoMetodoDemoradoAsync();
            //var task2 = SimulandoMetodoDemoradoAsync();
            //await Task.WhenAll(task1, task2);
            //// agora temos os dados pra mostrar.
            //lblum.Content = task1.Result;
            //lbldois.Content = task2.Result;

            //Exemplo2
            var task1 = SimulandoMetodoDemoradoAsync();
            var task2 = SimulandoMetodoDemoradoAsync();
            lblum.Content = await task1;
            lbldois.Content = await task2;
        }

    }
}
