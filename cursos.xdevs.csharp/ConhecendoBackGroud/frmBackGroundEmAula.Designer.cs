namespace ConhecendoBackGroud
{
    partial class frmBackGroundEmAula
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt = new System.Windows.Forms.TextBox();
            this.btn = new System.Windows.Forms.Button();
            this.pBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // txt
            // 
            this.txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt.Location = new System.Drawing.Point(50, 52);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(453, 32);
            this.txt.TabIndex = 5;
            // 
            // btn
            // 
            this.btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn.Location = new System.Drawing.Point(50, 101);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(453, 68);
            this.btn.TabIndex = 4;
            this.btn.Text = "Rodar Backgroud";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // pBar
            // 
            this.pBar.Location = new System.Drawing.Point(50, 186);
            this.pBar.Name = "pBar";
            this.pBar.Size = new System.Drawing.Size(453, 22);
            this.pBar.TabIndex = 6;
            // 
            // frmBackGroundEmAula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 220);
            this.Controls.Add(this.pBar);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.btn);
            this.Name = "frmBackGroundEmAula";
            this.Text = "frmBackGroundEmAula";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.ProgressBar pBar;
    }
}