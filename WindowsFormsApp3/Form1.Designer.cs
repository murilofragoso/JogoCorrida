namespace WindowsFormsApp3
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
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Limpar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAmarelo = new System.Windows.Forms.Button();
            this.apo1 = new System.Windows.Forms.TextBox();
            this.apo2 = new System.Windows.Forms.TextBox();
            this.apo3 = new System.Windows.Forms.TextBox();
            this.apo4 = new System.Windows.Forms.TextBox();
            this.apo5 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnBranco = new System.Windows.Forms.Button();
            this.btnVerde = new System.Windows.Forms.Button();
            this.btnVermelho = new System.Windows.Forms.Button();
            this.btnAzul = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(86, 263);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 39);
            this.button1.TabIndex = 0;
            this.button1.Text = "Começar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(86, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(550, 230);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Limpar
            // 
            this.Limpar.Location = new System.Drawing.Point(86, 303);
            this.Limpar.Name = "Limpar";
            this.Limpar.Size = new System.Drawing.Size(69, 44);
            this.Limpar.TabIndex = 2;
            this.Limpar.Text = "Resultado / Limpar";
            this.Limpar.UseVisualStyleBackColor = true;
            this.Limpar.Click += new System.EventHandler(this.Limpar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Amarelo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Branco";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Verde";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Vermelho";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Azul";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(212, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(261, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = " Facam suas apostas em ordem crescente, jogadores!";
            // 
            // btnAmarelo
            // 
            this.btnAmarelo.Location = new System.Drawing.Point(513, 263);
            this.btnAmarelo.Name = "btnAmarelo";
            this.btnAmarelo.Size = new System.Drawing.Size(60, 25);
            this.btnAmarelo.TabIndex = 9;
            this.btnAmarelo.Text = "Amarelo";
            this.btnAmarelo.UseVisualStyleBackColor = true;
            this.btnAmarelo.Click += new System.EventHandler(this.btnClick);
            // 
            // apo1
            // 
            this.apo1.Location = new System.Drawing.Point(179, 321);
            this.apo1.Name = "apo1";
            this.apo1.ReadOnly = true;
            this.apo1.Size = new System.Drawing.Size(30, 20);
            this.apo1.TabIndex = 11;
            this.apo1.Text = "100";
            // 
            // apo2
            // 
            this.apo2.Location = new System.Drawing.Point(215, 321);
            this.apo2.Name = "apo2";
            this.apo2.ReadOnly = true;
            this.apo2.Size = new System.Drawing.Size(30, 20);
            this.apo2.TabIndex = 12;
            this.apo2.Text = "100";
            // 
            // apo3
            // 
            this.apo3.Location = new System.Drawing.Point(251, 321);
            this.apo3.Name = "apo3";
            this.apo3.ReadOnly = true;
            this.apo3.Size = new System.Drawing.Size(30, 20);
            this.apo3.TabIndex = 13;
            this.apo3.Text = "100";
            // 
            // apo4
            // 
            this.apo4.Location = new System.Drawing.Point(287, 321);
            this.apo4.Name = "apo4";
            this.apo4.ReadOnly = true;
            this.apo4.Size = new System.Drawing.Size(30, 20);
            this.apo4.TabIndex = 14;
            this.apo4.Text = "100";
            // 
            // apo5
            // 
            this.apo5.Location = new System.Drawing.Point(323, 321);
            this.apo5.Name = "apo5";
            this.apo5.ReadOnly = true;
            this.apo5.Size = new System.Drawing.Size(30, 20);
            this.apo5.TabIndex = 15;
            this.apo5.Text = "100";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(202, 285);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Pontuação dos jogadores";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(186, 303);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(222, 303);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "2";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(257, 303);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(13, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "3";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(295, 303);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(13, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "4";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(331, 303);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(13, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "5";
            // 
            // btnBranco
            // 
            this.btnBranco.Location = new System.Drawing.Point(576, 263);
            this.btnBranco.Name = "btnBranco";
            this.btnBranco.Size = new System.Drawing.Size(60, 25);
            this.btnBranco.TabIndex = 22;
            this.btnBranco.Text = "Branco";
            this.btnBranco.UseVisualStyleBackColor = true;
            this.btnBranco.Click += new System.EventHandler(this.btnClick);
            // 
            // btnVerde
            // 
            this.btnVerde.Location = new System.Drawing.Point(513, 291);
            this.btnVerde.Name = "btnVerde";
            this.btnVerde.Size = new System.Drawing.Size(60, 25);
            this.btnVerde.TabIndex = 23;
            this.btnVerde.Text = "Verde";
            this.btnVerde.UseVisualStyleBackColor = true;
            this.btnVerde.Click += new System.EventHandler(this.btnClick);
            // 
            // btnVermelho
            // 
            this.btnVermelho.Location = new System.Drawing.Point(576, 291);
            this.btnVermelho.Name = "btnVermelho";
            this.btnVermelho.Size = new System.Drawing.Size(60, 25);
            this.btnVermelho.TabIndex = 24;
            this.btnVermelho.Text = "Vermelho";
            this.btnVermelho.UseVisualStyleBackColor = true;
            this.btnVermelho.Click += new System.EventHandler(this.btnClick);
            // 
            // btnAzul
            // 
            this.btnAzul.Location = new System.Drawing.Point(540, 322);
            this.btnAzul.Name = "btnAzul";
            this.btnAzul.Size = new System.Drawing.Size(60, 25);
            this.btnAzul.TabIndex = 25;
            this.btnAzul.Text = "Azul";
            this.btnAzul.UseVisualStyleBackColor = true;
            this.btnAzul.Click += new System.EventHandler(this.btnClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(403, 266);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(104, 64);
            this.textBox1.TabIndex = 26;
            this.textBox1.Text = "Cada aposta vale 10 pontos !   Vence quem chegar aos 200 primeiro!";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(446, 333);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 13);
            this.label13.TabIndex = 27;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 353);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnAzul);
            this.Controls.Add(this.btnVermelho);
            this.Controls.Add(this.btnVerde);
            this.Controls.Add(this.btnBranco);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.apo5);
            this.Controls.Add(this.apo4);
            this.Controls.Add(this.apo3);
            this.Controls.Add(this.apo2);
            this.Controls.Add(this.apo1);
            this.Controls.Add(this.btnAmarelo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Limpar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Corrida ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Limpar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAmarelo;
        private System.Windows.Forms.TextBox apo1;
        private System.Windows.Forms.TextBox apo2;
        private System.Windows.Forms.TextBox apo3;
        private System.Windows.Forms.TextBox apo4;
        private System.Windows.Forms.TextBox apo5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnBranco;
        private System.Windows.Forms.Button btnVerde;
        private System.Windows.Forms.Button btnVermelho;
        private System.Windows.Forms.Button btnAzul;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label13;
    }
}

