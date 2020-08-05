using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MexendoComDataBase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAbriConexao_Click(object sender, EventArgs e)
        {
            //talvez na sua máquina o local esteja diferente, preste atenção na explicação em aula sobre esse assunto
            System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
            conn.ConnectionString =
                @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Projetos\Git\Integrador\curso-desenvolvedor-csharp\cursos.xdevs.csharp\MexendoComDataBase\meubanquinho.mdf;Integrated Security=True";
            conn.Open();


            conn.Close();
        }

    }
}
