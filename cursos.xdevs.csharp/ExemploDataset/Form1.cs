using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExemploDataset
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCarregarDS_Click(object sender, EventArgs e)
        {
            CarregarDados();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from datas", @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Projetos\Git\Integrador\curso-desenvolvedor-csharp\cursos.xdevs.csharp\MexendoComDataBase\meubanquinho.mdf;Integrated Security=True");

            SqlCommand insert = new SqlCommand();
            insert.CommandType = CommandType.Text;
            insert.CommandText = "INSERT INTO Datas (Nome, Sobrenome) VALUES (@Nome,  @Sobrenome)";
            insert.Connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Projetos\Git\Integrador\curso-desenvolvedor-csharp\cursos.xdevs.csharp\MexendoComDataBase\meubanquinho.mdf;Integrated Security=True");

            //Criar os parametros
            insert.Parameters.Add(new SqlParameter("@Nome", SqlDbType.VarChar, 50, "Nome"));
            insert.Parameters.Add(new SqlParameter("@Sobrenome", SqlDbType.VarChar, 100, "Sobrenome"));

            //Asociar o comand insert a dataAdapter.
            da.InsertCommand = insert;

            //colocanda tabela em memória
            DataSet ds = new DataSet();
            da.Fill(ds);

            DataRow newRow = ds.Tables[0].NewRow();
            newRow["Nome"] = "teste0005";
            newRow["Sobrenome"] = "testes0006";
            ds.Tables[0].Rows.Add(newRow);

            dgrid.DataSource = ds.Tables[0];

            /////////////////////[PULAR] e ver o banco
            //atualizar o database
            da.Update(ds.Tables[0]);

            CarregarDados();
        }

        void CarregarDados()
        {
            DataSet ds = new DataSet();

            SqlDataAdapter da = new SqlDataAdapter("Select * from datas", @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Projetos\Git\Integrador\curso-desenvolvedor-csharp\cursos.xdevs.csharp\MexendoComDataBase\meubanquinho.mdf;Integrated Security=True");
            da.Fill(ds);
            dgrid.DataSource = ds.Tables[0];
        }
    }
}
