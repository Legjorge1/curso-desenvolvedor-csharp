using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsandoEntiyFrameWork
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnCarregar_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        void Buscar()
        {
            using (var context = new Contexto())
            {
                dataGridView1.DataSource = context.Datas
                    .AsNoTracking()
                    .ToList();
            }
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            using (var context = new Contexto())
            {
                Datas obj = new Datas();
                obj.Nome = "Di";
                obj.Sobrenome = "Santos";
                obj.DataNascimento = DateTime.Now;

                context.Datas.Add(obj);

                //importante
                context.SaveChanges();
            }

            Buscar();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            using (var context = new Contexto())
            {
                Datas obj = new Datas();
                obj.Id = 11;
                obj.Nome = "Diogo";
                obj.Sobrenome = "Costa";
                obj.DataNascimento = new DateTime(1983, 09, 11);

                context.Entry<Datas>(obj).State = EntityState.Modified;
                
                //importante
                context.SaveChanges();
            }

            Buscar();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            using (var context = new Contexto())
            {
                var obj = context.Datas.Find(11);

                context.Datas.Remove(obj);

                //importante
                context.SaveChanges();
            }

            Buscar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            using (var context = new Contexto())
            {
                var itens = from a in context.Datas
                            where a.Nome.Contains("Di")
                            select a;

                itens.ToList().ForEach(o => MessageBox.Show(o.Nome + "" + o.Sobrenome));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var context = new Contexto())
            {
                    var itens = context.Datas.Where(o => o.Nome.Contains("Di"));
                    itens.ToList().ForEach(o => MessageBox.Show(o.Nome + "" + o.Sobrenome));
            }
        }
    }


}


public class Datas
{
    [Key]
    public int Id { get; set; }

    public string Nome { get; set; }
    public string Sobrenome { get; set; }
    public DateTime? DataNascimento { get; set; }
}

class Contexto : DbContext
{
    public Contexto() : base("Contexto")
    {

    }

    public DbSet<Datas> Datas { get; set; }
}




