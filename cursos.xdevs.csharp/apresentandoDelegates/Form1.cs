using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace apresentandoDelegates
{

    public partial class Form1 : Form
    {
        //criou um tipo delegate //bom terminar o nome com Delegate, mas não é uma regra
        private delegate float FuncaoDelegate(float x);
        
        //Agora você pode criar uma variável do tipo ( delegate criado )
        private FuncaoDelegate aFuncao;

        public Form1()
        {
            InitializeComponent();
        }

        private static float FuncaoDaClasse(float x)
        {
            //sua lógica que deve retornar o tipo do delegate
            return (float)(12 * Math.Sin(3 * x) / (1 + Math.Abs(x)));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           var resultado  =  aFuncao(10);
            MessageBox.Show(resultado.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //fiz a ligação do delegate com a função escrita
            aFuncao = FuncaoDaClasse;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            aFuncao -= FuncaoDaClasse;
        }
    }
}
