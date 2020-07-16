using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetodoAnonimo
{
    public partial class Form1 : Form
    {
        private Func<float, float> funcaoAnonima01 = delegate (float x) { return x * x; };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //criando uma ellipse no formulário
            this.Paint += delegate (object obj, PaintEventArgs args)
            {
                args.Graphics.DrawEllipse(Pens.Red, 10, 10, 200, 100);
            };

            //
            System.Threading.Thread thread = 
                new System.Threading.Thread(

                delegate () { MessageBox.Show("Olá pessoal"); });

            thread.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var i = funcaoAnonima01(10);
            MessageBox.Show(i.ToString());
        }
    }
}
