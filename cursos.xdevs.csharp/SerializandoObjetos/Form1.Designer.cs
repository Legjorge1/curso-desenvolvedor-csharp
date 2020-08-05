namespace SerializandoObjetos
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
            this.btnSerializarBin = new System.Windows.Forms.Button();
            this.txtSobrenome = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnomeDesbin = new System.Windows.Forms.TextBox();
            this.txtsobrenomebin = new System.Windows.Forms.TextBox();
            this.btnDesBin = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSerializarXML = new System.Windows.Forms.Button();
            this.txtsobrenomeserializarxml = new System.Windows.Forms.TextBox();
            this.txtnomeserializarxml = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDeserializarXML = new System.Windows.Forms.Button();
            this.txtsobrenomedeserializarxml = new System.Windows.Forms.TextBox();
            this.txtnomedeserializarxml = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSerializaJson = new System.Windows.Forms.Button();
            this.txtsobreNomejsonserialize = new System.Windows.Forms.TextBox();
            this.txtNomejsonserialize = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnDesSerializaJson = new System.Windows.Forms.Button();
            this.txtsobreNomejsonDeserialize = new System.Windows.Forms.TextBox();
            this.txtNomejsonDesserialize = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSerializarBin
            // 
            this.btnSerializarBin.Location = new System.Drawing.Point(25, 85);
            this.btnSerializarBin.Name = "btnSerializarBin";
            this.btnSerializarBin.Size = new System.Drawing.Size(204, 28);
            this.btnSerializarBin.TabIndex = 0;
            this.btnSerializarBin.Text = "Serializar Binário";
            this.btnSerializarBin.UseVisualStyleBackColor = true;
            this.btnSerializarBin.Click += new System.EventHandler(this.btnSerializarBin_Click);
            // 
            // txtSobrenome
            // 
            this.txtSobrenome.Location = new System.Drawing.Point(95, 48);
            this.txtSobrenome.Name = "txtSobrenome";
            this.txtSobrenome.Size = new System.Drawing.Size(134, 20);
            this.txtSobrenome.TabIndex = 1;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(95, 22);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(134, 20);
            this.txtNome.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sobrenome:";
            // 
            // txtnomeDesbin
            // 
            this.txtnomeDesbin.Location = new System.Drawing.Point(336, 22);
            this.txtnomeDesbin.Name = "txtnomeDesbin";
            this.txtnomeDesbin.Size = new System.Drawing.Size(134, 20);
            this.txtnomeDesbin.TabIndex = 7;
            // 
            // txtsobrenomebin
            // 
            this.txtsobrenomebin.Location = new System.Drawing.Point(336, 48);
            this.txtsobrenomebin.Name = "txtsobrenomebin";
            this.txtsobrenomebin.Size = new System.Drawing.Size(134, 20);
            this.txtsobrenomebin.TabIndex = 6;
            // 
            // btnDesBin
            // 
            this.btnDesBin.Location = new System.Drawing.Point(266, 85);
            this.btnDesBin.Name = "btnDesBin";
            this.btnDesBin.Size = new System.Drawing.Size(204, 28);
            this.btnDesBin.TabIndex = 5;
            this.btnDesBin.Text = "Deserializar Binário";
            this.btnDesBin.UseVisualStyleBackColor = true;
            this.btnDesBin.Click += new System.EventHandler(this.btnDesBin_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(266, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Sobrenome:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(267, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nome:";
            // 
            // btnSerializarXML
            // 
            this.btnSerializarXML.Location = new System.Drawing.Point(25, 204);
            this.btnSerializarXML.Name = "btnSerializarXML";
            this.btnSerializarXML.Size = new System.Drawing.Size(204, 28);
            this.btnSerializarXML.TabIndex = 0;
            this.btnSerializarXML.Text = "Serializar XMLformat";
            this.btnSerializarXML.UseVisualStyleBackColor = true;
            this.btnSerializarXML.Click += new System.EventHandler(this.btnSerializarXML_Click);
            // 
            // txtsobrenomeserializarxml
            // 
            this.txtsobrenomeserializarxml.Location = new System.Drawing.Point(95, 167);
            this.txtsobrenomeserializarxml.Name = "txtsobrenomeserializarxml";
            this.txtsobrenomeserializarxml.Size = new System.Drawing.Size(134, 20);
            this.txtsobrenomeserializarxml.TabIndex = 1;
            // 
            // txtnomeserializarxml
            // 
            this.txtnomeserializarxml.Location = new System.Drawing.Point(95, 141);
            this.txtnomeserializarxml.Name = "txtnomeserializarxml";
            this.txtnomeserializarxml.Size = new System.Drawing.Size(134, 20);
            this.txtnomeserializarxml.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Nome:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Sobrenome:";
            // 
            // btnDeserializarXML
            // 
            this.btnDeserializarXML.Location = new System.Drawing.Point(266, 204);
            this.btnDeserializarXML.Name = "btnDeserializarXML";
            this.btnDeserializarXML.Size = new System.Drawing.Size(204, 28);
            this.btnDeserializarXML.TabIndex = 5;
            this.btnDeserializarXML.Text = "Deserializar XMLformat";
            this.btnDeserializarXML.UseVisualStyleBackColor = true;
            this.btnDeserializarXML.Click += new System.EventHandler(this.btnDeserializarXML_Click);
            // 
            // txtsobrenomedeserializarxml
            // 
            this.txtsobrenomedeserializarxml.Location = new System.Drawing.Point(336, 167);
            this.txtsobrenomedeserializarxml.Name = "txtsobrenomedeserializarxml";
            this.txtsobrenomedeserializarxml.Size = new System.Drawing.Size(134, 20);
            this.txtsobrenomedeserializarxml.TabIndex = 6;
            // 
            // txtnomedeserializarxml
            // 
            this.txtnomedeserializarxml.Location = new System.Drawing.Point(336, 141);
            this.txtnomedeserializarxml.Name = "txtnomedeserializarxml";
            this.txtnomedeserializarxml.Size = new System.Drawing.Size(134, 20);
            this.txtnomedeserializarxml.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(267, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Nome:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(266, 174);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Sobrenome:";
            // 
            // btnSerializaJson
            // 
            this.btnSerializaJson.Location = new System.Drawing.Point(25, 319);
            this.btnSerializaJson.Name = "btnSerializaJson";
            this.btnSerializaJson.Size = new System.Drawing.Size(204, 28);
            this.btnSerializaJson.TabIndex = 0;
            this.btnSerializaJson.Text = "Serializar JSONformat";
            this.btnSerializaJson.UseVisualStyleBackColor = true;
            this.btnSerializaJson.Click += new System.EventHandler(this.btnSerializaJson_Click);
            // 
            // txtsobreNomejsonserialize
            // 
            this.txtsobreNomejsonserialize.Location = new System.Drawing.Point(95, 282);
            this.txtsobreNomejsonserialize.Name = "txtsobreNomejsonserialize";
            this.txtsobreNomejsonserialize.Size = new System.Drawing.Size(134, 20);
            this.txtsobreNomejsonserialize.TabIndex = 1;
            // 
            // txtNomejsonserialize
            // 
            this.txtNomejsonserialize.Location = new System.Drawing.Point(95, 256);
            this.txtNomejsonserialize.Name = "txtNomejsonserialize";
            this.txtNomejsonserialize.Size = new System.Drawing.Size(134, 20);
            this.txtNomejsonserialize.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 262);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Nome:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(25, 289);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Sobrenome:";
            // 
            // btnDesSerializaJson
            // 
            this.btnDesSerializaJson.Location = new System.Drawing.Point(266, 319);
            this.btnDesSerializaJson.Name = "btnDesSerializaJson";
            this.btnDesSerializaJson.Size = new System.Drawing.Size(204, 28);
            this.btnDesSerializaJson.TabIndex = 5;
            this.btnDesSerializaJson.Text = "Deserializar JSONformat";
            this.btnDesSerializaJson.UseVisualStyleBackColor = true;
            this.btnDesSerializaJson.Click += new System.EventHandler(this.btnDesSerializaJson_Click);
            // 
            // txtsobreNomejsonDeserialize
            // 
            this.txtsobreNomejsonDeserialize.Location = new System.Drawing.Point(336, 282);
            this.txtsobreNomejsonDeserialize.Name = "txtsobreNomejsonDeserialize";
            this.txtsobreNomejsonDeserialize.Size = new System.Drawing.Size(134, 20);
            this.txtsobreNomejsonDeserialize.TabIndex = 6;
            // 
            // txtNomejsonDesserialize
            // 
            this.txtNomejsonDesserialize.Location = new System.Drawing.Point(336, 256);
            this.txtNomejsonDesserialize.Name = "txtNomejsonDesserialize";
            this.txtNomejsonDesserialize.Size = new System.Drawing.Size(134, 20);
            this.txtNomejsonDesserialize.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(267, 262);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "Nome:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(266, 289);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 13);
            this.label12.TabIndex = 9;
            this.label12.Text = "Sobrenome:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 384);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(444, 49);
            this.button1.TabIndex = 10;
            this.button1.Text = "Customizado";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 453);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNomejsonDesserialize);
            this.Controls.Add(this.txtnomedeserializarxml);
            this.Controls.Add(this.txtnomeDesbin);
            this.Controls.Add(this.txtsobreNomejsonDeserialize);
            this.Controls.Add(this.txtsobrenomedeserializarxml);
            this.Controls.Add(this.txtsobrenomebin);
            this.Controls.Add(this.btnDesSerializaJson);
            this.Controls.Add(this.btnDeserializarXML);
            this.Controls.Add(this.btnDesBin);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNomejsonserialize);
            this.Controls.Add(this.txtnomeserializarxml);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtsobreNomejsonserialize);
            this.Controls.Add(this.txtsobrenomeserializarxml);
            this.Controls.Add(this.txtSobrenome);
            this.Controls.Add(this.btnSerializaJson);
            this.Controls.Add(this.btnSerializarXML);
            this.Controls.Add(this.btnSerializarBin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSerializarBin;
        private System.Windows.Forms.TextBox txtSobrenome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnomeDesbin;
        private System.Windows.Forms.TextBox txtsobrenomebin;
        private System.Windows.Forms.Button btnDesBin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSerializarXML;
        private System.Windows.Forms.TextBox txtsobrenomeserializarxml;
        private System.Windows.Forms.TextBox txtnomeserializarxml;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnDeserializarXML;
        private System.Windows.Forms.TextBox txtsobrenomedeserializarxml;
        private System.Windows.Forms.TextBox txtnomedeserializarxml;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSerializaJson;
        private System.Windows.Forms.TextBox txtsobreNomejsonserialize;
        private System.Windows.Forms.TextBox txtNomejsonserialize;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnDesSerializaJson;
        private System.Windows.Forms.TextBox txtsobreNomejsonDeserialize;
        private System.Windows.Forms.TextBox txtNomejsonDesserialize;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button1;
    }
}

