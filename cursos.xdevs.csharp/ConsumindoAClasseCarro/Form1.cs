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
            // Make some data.
            Carro[] carros = {  new Carro() { Nome="SSC Ultimate Aero", MaximaPotencia=257,  Cavalos=1183, Preco=654400m},
                                new Carro() { Nome="Bugatti Veyron", MaximaPotencia=253, Cavalos=1001, Preco=1700000m}, };

            // Display the cars unsorted.
            DisplayCars(carros, listView1);
            // Sort the array of cars.
            Array.Sort(carros);
            // Display the cars sorted.
            DisplayCars(carros, listView2);
        }

        // Display the cars in the ListView control.
        private void DisplayCars(Carro[] cars, ListView listView)
        {
            listView.Items.Clear();
            foreach (Carro car in cars)
            {
                ListViewItem item = listView.Items.Add(car.Nome);
                item.SubItems.Add(car.MaximaPotencia.ToString());
                item.SubItems.Add(car.Cavalos.ToString());
                item.SubItems.Add(car.Preco.ToString("C"));
            }
            foreach (ColumnHeader header in listView.Columns)
            {
                header.Width = -2;
            }
        }
    }
}
