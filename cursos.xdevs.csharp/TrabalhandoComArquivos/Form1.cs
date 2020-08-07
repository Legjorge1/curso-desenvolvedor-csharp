using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabalhandoComArquivos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        public delegate string LerArquivoDelegate(string caminho);
        public delegate void escrverArquivoDelegate(string caminho, string texto);
        public delegate void deletarArquivoDelegate(string caminho);

        public LerArquivoDelegate criarArquivo;
        public escrverArquivoDelegate escreverArquivo;
        public deletarArquivoDelegate deletarArquivo;

        //File
        #region exemplo File
        string LerComFile(string caminhoArquivo) {
            return File.ReadAllText(caminhoArquivo);
        }
        
        void EscreveComFile(string caminhoArquivo, string texto)
        {
            File.WriteAllText(caminhoArquivo, texto);
        }

        void DeletarComFile(string caminhoArquivo)
        {
            File.Delete(caminhoArquivo);
        }
        #endregion
        //FileInfo

        #region FileInfo
        string LerComFileInfo(string caminhoArquivo)
        {
            FileInfo f = new FileInfo(caminhoArquivo);
            StreamReader sr = f.OpenText();
            return sr.ReadToEnd();
        }

        void EscreveComFileInfo(string caminhoArquivo, string texto)
        {
            FileInfo f = new FileInfo(caminhoArquivo);
            using (StreamWriter sw = f.CreateText())
            {
                sw.WriteLine(texto);
            }
        }
        
        void DeletarComFileInfo(string caminhoArquivo)
        {
            FileInfo f = new FileInfo(caminhoArquivo);
            f.Delete();
        }
        #endregion

        //Directory
        #region Exemplo Directory
        void CriarDirectory(string pasta) 
        {
            //retorna o DirectoryInfo
            Directory.CreateDirectory(pasta);
        }

        void ApagarDiretorio(string caminhoDiretorio, bool apagacomTodosArquivos) {
            Directory.Delete(caminhoDiretorio, apagacomTodosArquivos);
        }

        string[] VerConteudoDiretorio(string caminhoDiretorio) 
        {
            return Directory.GetFiles(caminhoDiretorio);
        }

        #endregion

        //directoryInfo
        #region Exemplo DirectoryInfo
        void CriarDirectoryInfo(string pasta)
        {
            DirectoryInfo dInfo = new DirectoryInfo(pasta);
            dInfo.Create();
        }
        void ApagarDiretorioInfo(string caminhoDiretorio, bool apagacomTodosArquivos)
        {
            DirectoryInfo dInfo = new DirectoryInfo(caminhoDiretorio);
            dInfo.Delete(apagacomTodosArquivos);
        }
        
        string[] VerConteudoDiretorioInfo(string caminhoDiretorio)
        {
            DirectoryInfo dInfo = new DirectoryInfo(caminhoDiretorio);
            return dInfo.GetFiles().Select(o => o.FullName).ToArray();
        }

        #endregion



        void Criar(escrverArquivoDelegate c)
        {
            using (SaveFileDialog save = new SaveFileDialog())
            {
                save.InitialDirectory = Environment.CurrentDirectory;

                if (save.ShowDialog() == DialogResult.OK)
                {
                    c(save.FileName, richTextBox1.Text);
                }
            }

            richTextBox1.Text += "Operação realizada";
        }
        void Criar(Action<string> diretorio) {
            using (FolderBrowserDialog pasta = new FolderBrowserDialog())
            {
                pasta.RootFolder = Environment.SpecialFolder.DesktopDirectory;

                if (pasta.ShowDialog() == DialogResult.OK)
                {
                    diretorio(pasta.SelectedPath);
                }
            }

            richTextBox1.Text += "Operação realizada";
        }

        void Ler(LerArquivoDelegate c)
        {
            using (OpenFileDialog openF = new OpenFileDialog())
            {
                openF.InitialDirectory = Environment.CurrentDirectory;

                if (openF.ShowDialog() == DialogResult.OK)
                {
                    richTextBox1.Text = c(openF.FileName);
                }
            }
        }
        void Ler(Func<string, string[]> d)
        {
            using (FolderBrowserDialog pasta = new FolderBrowserDialog())
            {
                pasta.RootFolder = Environment.SpecialFolder.DesktopDirectory;

                if (pasta.ShowDialog() == DialogResult.OK)
                {
                    richTextBox1.Text = string.Empty;
                    richTextBox1.Text += string.Join("", d(pasta.SelectedPath));
                }
            }

            richTextBox1.Text += "Operação realizada";
        }

        void Apagar(deletarArquivoDelegate d)
        {
            using (OpenFileDialog save = new OpenFileDialog())
            {
                //save.InitialDirectory = Environment.CurrentDirectory; //==determinei
                save.RestoreDirectory = true; //ultima pasta utilizada

                if (save.ShowDialog() == DialogResult.OK)
                {
                    d(save.FileName);
                }
            }

            richTextBox1.Text += "Operação realizada";
        }
        void Apagar(Action<string, bool> diretorio, bool apagarTudo) {
            using (FolderBrowserDialog pasta = new FolderBrowserDialog())
            {
                pasta.RootFolder = Environment.SpecialFolder.DesktopDirectory;

                if (pasta.ShowDialog() == DialogResult.OK)
                {
                    diretorio(pasta.SelectedPath, apagarTudo);
                }
            }

            richTextBox1.Text += "Operação realizada";
        }




        private void criarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Criar(EscreveComFile);
        }

        private void criarArquivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Criar(EscreveComFileInfo);
        }

        private void criarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Criar(CriarDirectory);
        }

        private void criarDiretorioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Criar(CriarDirectoryInfo);
        }



        private void lerArquivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ler(LerComFile);
        }

        private void lerArquivoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Ler(LerComFileInfo);
        }

        private void lerArquivosDoDiretórioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ler(VerConteudoDiretorio);
        }

        private void lerArquivosDoDiretórioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Ler(VerConteudoDiretorioInfo);
        }



        private void deletarArquivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Apagar(DeletarComFile);
        }

        private void apagarDiretórioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Apagar(ApagarDiretorioInfo, true);
        }

        private void apagarArquivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Apagar(DeletarComFileInfo);
        }

        private void apagarDiretórioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Apagar(ApagarDiretorio, true);
        }
    }
}
