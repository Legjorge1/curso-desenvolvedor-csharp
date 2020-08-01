using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EscrevendoInstrucaoNoBanco
{

    public partial class Form1 : Form
    {
        System.Data.SqlClient.SqlConnection connection;

        public Form1()
        {
            InitializeComponent();

            connection = new SqlConnection();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connection.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Projetos\Cliente\Cursos\CsharpTwitter\curso-desenvolvedor-csharp\cursos.xdevs.csharp\MexendoComDataBase\meubanquinho.mdf;Integrated Security=True";
            connection.Open();
        }




        ~Form1()
        {
            connection.Close();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            //W3
            SqlCommand comm = new SqlCommand();
            comm.CommandText = $@"INSERT INTO DATAS (NOME, SOBRENOME, DATANASCIMENTO) 
                                  VALUES ('{txtNome.Text}', '{txtSobrenome.Text}', '{dtpCalendar.Value.ToString("yyyy-MM-dd")}')";
            comm.Connection = connection;
            comm.CommandType = CommandType.Text;

            //SQL INJECT

            //PARAMETERS

            //retorna no numero de linnhas afetadas
            comm.ExecuteNonQuery();

            ListarDados();
        }

        private void ListarDados()
        {
            SqlCommand comm = new SqlCommand();
            comm.CommandText = "Select * from DATAS";
            comm.Connection = connection;
            comm.CommandType = CommandType.Text;

            SqlDataReader dr = comm.ExecuteReader(); //fechar conexao, interessante (commandBehavior)

            List<Aniversarios> aniversarios = new List<Aniversarios>();
            Aniversarios aniver;

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    //instanciando um objeto
                    aniver = new Aniversarios();
                    
                    Debug.WriteLine(string.Format("Nome: {0} , SobreNome: {1}", dr["Nome"], dr["SobreNome"]));

                    aniver.Id = dr.GetInt32(0);
                    aniver.Nome = dr.GetString(1);
                    aniver.SobreNome = dr.GetString(2);
                    aniver.DataNascimento = dr.GetDateTime(3);

                    //adicionando objeto a lista
                    aniversarios.Add(aniver);
                }
            }

            //adicionado a lista no grid
            dgridItens.DataSource = aniversarios;

            dr.Close();
        }

        private void btnQuantidade_Click(object sender, EventArgs e)
        {
            SqlCommand comm = new SqlCommand();
            comm.CommandText = "Select Count(*) from DATAS";
            comm.Connection = connection;
            comm.CommandType = CommandType.Text;

            int quantidade = Convert.ToInt32( comm.ExecuteScalar() );

            MessageBox.Show($"Quantidade de registros: {quantidade}");
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            var id = ItemSelecionado();

            if (id != null && id != 0)
            {
                SqlCommand comm = new SqlCommand();
                comm.CommandText = $@"UPDATE DATAS SET NOME='{txtNome.Text}', SOBRENOME='{txtSobrenome.Text}', DATANASCIMENTO = '{dtpCalendar.Value.ToString("yyyy-MM-dd")}'
                                  WHERE ID = {id.Value}";
                comm.Connection = connection;
                comm.CommandType = CommandType.Text;

                //retorna no numero de linnhas afetadas
                comm.ExecuteNonQuery();

                ListarDados();
            }
        }

        int ? ItemSelecionado() {

            var id = dgridItens.SelectedRows[0].Cells[0]?.Value;
            if ( id == null)
            {
                MessageBox.Show("Nenhum registro encontrado");
                return null;
            }
            else
            {
                return Convert.ToInt32(id);
            }

        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            var id = ItemSelecionado();

            if (id != null && id != 0)
            {
                if (MessageBox.Show("Tem certeza que deseja apagar o registro?", "Deletar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SqlCommand comm = new SqlCommand();
                    comm.CommandText = $@"delete from DATAS
                                  WHERE ID = {id.Value}";
                    comm.Connection = connection;
                    comm.CommandType = CommandType.Text;

                    //retorna no numero de linnhas afetadas
                    comm.ExecuteNonQuery();

                    ListarDados();
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            SqlCommand comm = new SqlCommand();
            comm.CommandText = $"Select Nome, Sobrenome from DATAS where nome like '%{txtNome.Text}%' ";
            comm.Connection = connection;
            comm.CommandType = CommandType.Text;

            SqlDataReader dr = comm.ExecuteReader(); //fechar conexao, boa prática (commandBehavior)
            StringBuilder sb = new StringBuilder();
            
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    sb.AppendLine(string.Format("Nome: {0} , SobreNome: {1}", dr[0], dr[1]));
                }
            }

            MessageBox.Show(sb.ToString());

            dr.Close();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            ListarDados();
        }
    }


    class Aniversarios { 
        public int Id { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public DateTime DataNascimento { get; set; }
    }
}
