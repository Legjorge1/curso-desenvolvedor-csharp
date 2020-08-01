namespace MexendoComDataBase
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
            this.btnAbriConexao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAbriConexao
            // 
            this.btnAbriConexao.Location = new System.Drawing.Point(39, 42);
            this.btnAbriConexao.Name = "btnAbriConexao";
            this.btnAbriConexao.Size = new System.Drawing.Size(170, 34);
            this.btnAbriConexao.TabIndex = 0;
            this.btnAbriConexao.Text = "Abrir conexão";
            this.btnAbriConexao.UseVisualStyleBackColor = true;
            this.btnAbriConexao.Click += new System.EventHandler(this.btnAbriConexao_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAbriConexao);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAbriConexao;
    }
}

