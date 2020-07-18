using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExemplosSobreErros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(txtNum1.Text);
            int y = Convert.ToInt32(txtNum2.Text);

            var resultado = x / y;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int x = Convert.ToInt32(txtNum1.Text);
                int y = Convert.ToInt32(txtNum2.Text);

                var resultado = x / y;

            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int x = Convert.ToInt32(txtNum1.Text);
                int y = Convert.ToInt32(txtNum2.Text);

                var resultado = x / y;

            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                int x = Convert.ToInt32(txtNum1.Text);
                int y = Convert.ToInt32(txtNum2.Text);

                var resultado = x / y;

            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                int x = Convert.ToInt32(txtNum1.Text);
                int y = Convert.ToInt32(txtNum2.Text);

                var resultado = x / y;

            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                //Com ou sem erro
                MessageBox.Show("Esse código sempre será executado");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                int x = Convert.ToInt32(txtNum1.Text);
                int y = Convert.ToInt32(txtNum2.Text);

                var resultado = x / y;

            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show(ex.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button10_Click(object sender, EventArgs e)
        {
            MessageBox.Show(calcula().ToString());
        }


        int calcula()
        {
            try
            {
                int[] i = new int[2];
                return i[3];
            }
            catch //Qualquer erro que pegar, retorna 0 
            {
                return 0;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ClassExecutaErro classe = new ClassExecutaErro();
            try
            {
                classe.Processar();
            }
            catch (Exception ex)
            {
                //Tostring mostra da onde foi executado
                MessageBox.Show(ex.ToString());
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ClassExecutaErro classe = new ClassExecutaErro();
            try
            {
                classe.Processar2();
            }
            catch (Exception ex)
            {
                //Tostring mostra da onde foi executado
                MessageBox.Show(ex.Message);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            ClassExecutaErro classe = new ClassExecutaErro();
            try
            {
                classe.Processar3();
            }
            catch (Exception ex)
            {
                //Tostring mostra da onde foi executado
                MessageBox.Show(ex.ToString());
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ClassExecutaErro cErro = new ClassExecutaErro();

            try
            {
                cErro.Processar4();
            }catch(MeuErroException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }


    class ClassExecutaErro
    {
        public void Processar() {

            try
            {
                Convert.ToInt32("A");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }

        public void Processar2() {
            try
            {
                Convert.ToInt32("A");
            }
            catch (Exception ex)
            {
                throw new Exception("Conversão não foi correta");
            }
        }

        public void Processar3()
        {
                Convert.ToInt32("A");
        }

        public void Processar4() {

            throw new MeuErroException("Erro ocorreu aqui também"); 
        }
    }

    [Serializable]
    class MeuErroException : Exception
    {
        public MeuErroException()
        : base() { }
        public MeuErroException(string message)
        : base(message) { }
        public MeuErroException(string message, Exception innerException)
        : base(message, innerException) { }
        protected MeuErroException(SerializationInfo info, StreamingContext context) 
            : base(info, context) { }
    }
}
