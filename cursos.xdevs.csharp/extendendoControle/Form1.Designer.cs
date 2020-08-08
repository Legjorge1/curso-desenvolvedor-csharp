namespace extendendoControle
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
            this.meuCampoTexto1 = new extendendoControle.MeuCampoTexto();
            this.SuspendLayout();
            // 
            // meuCampoTexto1
            // 
            this.meuCampoTexto1.Borda = "miunhasasd";
            this.meuCampoTexto1.Location = new System.Drawing.Point(53, 97);
            this.meuCampoTexto1.Name = "meuCampoTexto1";
            this.meuCampoTexto1.Size = new System.Drawing.Size(172, 20);
            this.meuCampoTexto1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 199);
            this.Controls.Add(this.meuCampoTexto1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MeuCampoTexto meuCampoTexto1;
    }
}

