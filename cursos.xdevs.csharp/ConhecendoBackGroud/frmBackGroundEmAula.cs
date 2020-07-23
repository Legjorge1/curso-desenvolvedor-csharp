using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConhecendoBackGroud
{
    public partial class frmBackGroundEmAula : Form
    {
        BackgroundWorker bk;
        public frmBackGroundEmAula()
        {
            InitializeComponent();

            bk = new BackgroundWorker();

            bk.WorkerReportsProgress = true;
            bk.WorkerSupportsCancellation = true;
            
            bk.DoWork += Bk_DoWork;
            bk.RunWorkerCompleted += Bk_RunWorkerCompleted;
            bk.ProgressChanged += Bk_ProgressChanged;
        }

        double FazerCalculosIntensos()
        {
            bk.ReportProgress(15);

            // Nós estamos fazendo calculos intensos
            // com divisões sem sentido
            double result = 100000000d;
            var maxValue = Int32.MaxValue;

            bk.ReportProgress(25);

            for (int i = 1; i < maxValue; i++)
            {
                result /= i;
            }
            bk.ReportProgress(80);
            Thread.Sleep(3000);
            bk.ReportProgress(100);
            return result + 10d;
        }

        private void Bk_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            pBar.Value = e.ProgressPercentage;
        }

        private void Bk_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            txt.Text = e.Result.ToString();
        }

        private void Bk_DoWork(object sender, DoWorkEventArgs e)
        {
            e.Result = FazerCalculosIntensos().ToString();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            if (bk.IsBusy) {
                
                if ( MessageBox.Show("está ocupado, mas deseja para o processo?",
                    "Questão", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    bk.CancelAsync();
                }

                return;
            }

            bk.RunWorkerAsync();
        }
    }
}
