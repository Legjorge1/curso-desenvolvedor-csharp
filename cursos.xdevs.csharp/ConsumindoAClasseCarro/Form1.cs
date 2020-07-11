using ImplementandoIComparable;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsumindoAClasseCarro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Lista de carros (objeto)
            Carro[] carros = {  new Carro() { Nome="SSC Ultimate Aero", MaximaPotencia=257,  Cavalos=1183, Preco=654400m},
                                new Carro() { Nome="Bugatti Veyron", MaximaPotencia=253, Cavalos=1001, Preco=1700000m}, 
                                new Carro() { Nome="Palio Elx", MaximaPotencia=10, Cavalos=10, Preco=30000m},
                                new Carro() { Nome="Gol GTI", MaximaPotencia=12, Cavalos=9, Preco=32000m},
            };

            // Mostra a lista sem ordernar
            MostrarCarros(carros, listBox1);
            // Ordernar o array no carro
            Array.Sort(carros);
            // Mostra os carros ordenados
            MostrarCarros(carros, listBox2);
            // Ordernar de formar reversa a lista de carro
            Array.Reverse(carros);
            // Mostrar os carros ordenados de forma Reversa
            MostrarCarros(carros, listBox3);

        }

        private void MostrarCarros(Carro[] cars, ListBox listbox)
        {
            listbox.Items.Clear();
            foreach (Carro car in cars)
            {
                listbox.Items.Add(
                    string.Format("Nome: {0}, Potencia: {1}, Cavalos: {2}, Preço: {3}", car.Nome, car.MaximaPotencia, car.Cavalos, car.Preco.ToString("C"))
                    );

            }
        }



    }
}
