namespace TrabalhandoComArquivos
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.abrirArquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.criarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lerArquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deletarArquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.directoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.criarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lerArquivosDoDiretórioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apagarDiretórioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.criarArquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lerArquivoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.directoryToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.criarDiretorioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lerArquivosDoDiretórioToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.apagarDiretórioToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.apagarArquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirArquivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // abrirArquivoToolStripMenuItem
            // 
            this.abrirArquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.directoryToolStripMenuItem,
            this.fileInfoToolStripMenuItem,
            this.directoryToolStripMenuItem1});
            this.abrirArquivoToolStripMenuItem.Name = "abrirArquivoToolStripMenuItem";
            this.abrirArquivoToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.abrirArquivoToolStripMenuItem.Text = "Classes";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.criarToolStripMenuItem,
            this.lerArquivoToolStripMenuItem,
            this.deletarArquivoToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // criarToolStripMenuItem
            // 
            this.criarToolStripMenuItem.Name = "criarToolStripMenuItem";
            this.criarToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.criarToolStripMenuItem.Text = "Criar arquivo";
            this.criarToolStripMenuItem.Click += new System.EventHandler(this.criarToolStripMenuItem_Click);
            // 
            // lerArquivoToolStripMenuItem
            // 
            this.lerArquivoToolStripMenuItem.Name = "lerArquivoToolStripMenuItem";
            this.lerArquivoToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.lerArquivoToolStripMenuItem.Text = "Ler arquivo";
            this.lerArquivoToolStripMenuItem.Click += new System.EventHandler(this.lerArquivoToolStripMenuItem_Click);
            // 
            // deletarArquivoToolStripMenuItem
            // 
            this.deletarArquivoToolStripMenuItem.Name = "deletarArquivoToolStripMenuItem";
            this.deletarArquivoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deletarArquivoToolStripMenuItem.Text = "Deletar arquivo";
            this.deletarArquivoToolStripMenuItem.Click += new System.EventHandler(this.deletarArquivoToolStripMenuItem_Click);
            // 
            // directoryToolStripMenuItem
            // 
            this.directoryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.criarToolStripMenuItem1,
            this.lerArquivosDoDiretórioToolStripMenuItem,
            this.apagarDiretórioToolStripMenuItem});
            this.directoryToolStripMenuItem.Name = "directoryToolStripMenuItem";
            this.directoryToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.directoryToolStripMenuItem.Text = "Directory";
            // 
            // criarToolStripMenuItem1
            // 
            this.criarToolStripMenuItem1.Name = "criarToolStripMenuItem1";
            this.criarToolStripMenuItem1.Size = new System.Drawing.Size(204, 22);
            this.criarToolStripMenuItem1.Text = "Criar Diretório";
            this.criarToolStripMenuItem1.Click += new System.EventHandler(this.criarToolStripMenuItem1_Click);
            // 
            // lerArquivosDoDiretórioToolStripMenuItem
            // 
            this.lerArquivosDoDiretórioToolStripMenuItem.Name = "lerArquivosDoDiretórioToolStripMenuItem";
            this.lerArquivosDoDiretórioToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.lerArquivosDoDiretórioToolStripMenuItem.Text = "Ler arquivos do Diretório";
            this.lerArquivosDoDiretórioToolStripMenuItem.Click += new System.EventHandler(this.lerArquivosDoDiretórioToolStripMenuItem_Click);
            // 
            // apagarDiretórioToolStripMenuItem
            // 
            this.apagarDiretórioToolStripMenuItem.Name = "apagarDiretórioToolStripMenuItem";
            this.apagarDiretórioToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.apagarDiretórioToolStripMenuItem.Text = "Apagar Diretório";
            this.apagarDiretórioToolStripMenuItem.Click += new System.EventHandler(this.apagarDiretórioToolStripMenuItem_Click);
            // 
            // fileInfoToolStripMenuItem
            // 
            this.fileInfoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.criarArquivoToolStripMenuItem,
            this.lerArquivoToolStripMenuItem1,
            this.apagarArquivoToolStripMenuItem});
            this.fileInfoToolStripMenuItem.Name = "fileInfoToolStripMenuItem";
            this.fileInfoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fileInfoToolStripMenuItem.Text = "FileInfo";
            // 
            // criarArquivoToolStripMenuItem
            // 
            this.criarArquivoToolStripMenuItem.Name = "criarArquivoToolStripMenuItem";
            this.criarArquivoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.criarArquivoToolStripMenuItem.Text = "Criar arquivo";
            this.criarArquivoToolStripMenuItem.Click += new System.EventHandler(this.criarArquivoToolStripMenuItem_Click);
            // 
            // lerArquivoToolStripMenuItem1
            // 
            this.lerArquivoToolStripMenuItem1.Name = "lerArquivoToolStripMenuItem1";
            this.lerArquivoToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.lerArquivoToolStripMenuItem1.Text = "Ler arquivo";
            this.lerArquivoToolStripMenuItem1.Click += new System.EventHandler(this.lerArquivoToolStripMenuItem1_Click);
            // 
            // directoryToolStripMenuItem1
            // 
            this.directoryToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.criarDiretorioToolStripMenuItem,
            this.lerArquivosDoDiretórioToolStripMenuItem1,
            this.apagarDiretórioToolStripMenuItem1});
            this.directoryToolStripMenuItem1.Name = "directoryToolStripMenuItem1";
            this.directoryToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.directoryToolStripMenuItem1.Text = "DirectoryInfo";
            // 
            // criarDiretorioToolStripMenuItem
            // 
            this.criarDiretorioToolStripMenuItem.Name = "criarDiretorioToolStripMenuItem";
            this.criarDiretorioToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.criarDiretorioToolStripMenuItem.Text = "Criar Diretorio";
            this.criarDiretorioToolStripMenuItem.Click += new System.EventHandler(this.criarDiretorioToolStripMenuItem_Click);
            // 
            // lerArquivosDoDiretórioToolStripMenuItem1
            // 
            this.lerArquivosDoDiretórioToolStripMenuItem1.Name = "lerArquivosDoDiretórioToolStripMenuItem1";
            this.lerArquivosDoDiretórioToolStripMenuItem1.Size = new System.Drawing.Size(203, 22);
            this.lerArquivosDoDiretórioToolStripMenuItem1.Text = "Ler arquivos do diretório";
            this.lerArquivosDoDiretórioToolStripMenuItem1.Click += new System.EventHandler(this.lerArquivosDoDiretórioToolStripMenuItem1_Click);
            // 
            // apagarDiretórioToolStripMenuItem1
            // 
            this.apagarDiretórioToolStripMenuItem1.Name = "apagarDiretórioToolStripMenuItem1";
            this.apagarDiretórioToolStripMenuItem1.Size = new System.Drawing.Size(203, 22);
            this.apagarDiretórioToolStripMenuItem1.Text = "Apagar diretório";
            this.apagarDiretórioToolStripMenuItem1.Click += new System.EventHandler(this.apagarDiretórioToolStripMenuItem1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 119);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(365, 319);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // apagarArquivoToolStripMenuItem
            // 
            this.apagarArquivoToolStripMenuItem.Name = "apagarArquivoToolStripMenuItem";
            this.apagarArquivoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.apagarArquivoToolStripMenuItem.Text = "Apagar arquivo";
            this.apagarArquivoToolStripMenuItem.Click += new System.EventHandler(this.apagarArquivoToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem abrirArquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem directoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem directoryToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem criarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lerArquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem criarArquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lerArquivoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem criarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem lerArquivosDoDiretórioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem apagarDiretórioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem criarDiretorioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lerArquivosDoDiretórioToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem apagarDiretórioToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deletarArquivoToolStripMenuItem;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ToolStripMenuItem apagarArquivoToolStripMenuItem;
    }
}

