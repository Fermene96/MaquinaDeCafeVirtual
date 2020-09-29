namespace MaquinaDeCafeVirtual
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.imagem = new System.Windows.Forms.PictureBox();
            this.painelEsquerdo = new System.Windows.Forms.Panel();
            this.CancelarBtn = new System.Windows.Forms.Button();
            this.PrepararBtn = new System.Windows.Forms.Button();
            this.Sair = new System.Windows.Forms.Button();
            this.Opcoes = new System.Windows.Forms.GroupBox();
            this.CafeComLeiteOpt = new System.Windows.Forms.RadioButton();
            this.MochaOpt = new System.Windows.Forms.RadioButton();
            this.CappuccinoOpt = new System.Windows.Forms.RadioButton();
            this.CafeOpt = new System.Windows.Forms.RadioButton();
            this.PainelDigital = new System.Windows.Forms.TextBox();
            this.tabelaMoedas = new System.Windows.Forms.TableLayoutPanel();
            this.umCentBtn = new System.Windows.Forms.Button();
            this.cincoCentBtn = new System.Windows.Forms.Button();
            this.dezCentBtn = new System.Windows.Forms.Button();
            this.vinteCincoCentBtn = new System.Windows.Forms.Button();
            this.cinquentaCentBtn = new System.Windows.Forms.Button();
            this.umRealBtn = new System.Windows.Forms.Button();
            this.Finalizado = new System.Windows.Forms.TextBox();
            this.FinalizadoImg = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imagem)).BeginInit();
            this.painelEsquerdo.SuspendLayout();
            this.Opcoes.SuspendLayout();
            this.tabelaMoedas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FinalizadoImg)).BeginInit();
            this.SuspendLayout();
            // 
            // imagem
            // 
            this.imagem.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.imagem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imagem.BackgroundImage")));
            this.imagem.Image = ((System.Drawing.Image)(resources.GetObject("imagem.Image")));
            this.imagem.Location = new System.Drawing.Point(258, 12);
            this.imagem.Name = "imagem";
            this.imagem.Size = new System.Drawing.Size(496, 504);
            this.imagem.TabIndex = 0;
            this.imagem.TabStop = false;
            // 
            // painelEsquerdo
            // 
            this.painelEsquerdo.BackColor = System.Drawing.Color.Transparent;
            this.painelEsquerdo.Controls.Add(this.CancelarBtn);
            this.painelEsquerdo.Controls.Add(this.PrepararBtn);
            this.painelEsquerdo.Controls.Add(this.Sair);
            this.painelEsquerdo.Location = new System.Drawing.Point(12, 12);
            this.painelEsquerdo.Name = "painelEsquerdo";
            this.painelEsquerdo.Size = new System.Drawing.Size(240, 608);
            this.painelEsquerdo.TabIndex = 1;
            // 
            // CancelarBtn
            // 
            this.CancelarBtn.BackColor = System.Drawing.Color.Maroon;
            this.CancelarBtn.Enabled = false;
            this.CancelarBtn.FlatAppearance.BorderSize = 0;
            this.CancelarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelarBtn.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelarBtn.Location = new System.Drawing.Point(44, 150);
            this.CancelarBtn.Name = "CancelarBtn";
            this.CancelarBtn.Size = new System.Drawing.Size(143, 69);
            this.CancelarBtn.TabIndex = 2;
            this.CancelarBtn.Text = "Cancelar";
            this.CancelarBtn.UseVisualStyleBackColor = false;
            // 
            // PrepararBtn
            // 
            this.PrepararBtn.BackColor = System.Drawing.Color.Green;
            this.PrepararBtn.Enabled = false;
            this.PrepararBtn.FlatAppearance.BorderSize = 0;
            this.PrepararBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrepararBtn.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrepararBtn.Location = new System.Drawing.Point(44, 37);
            this.PrepararBtn.Name = "PrepararBtn";
            this.PrepararBtn.Size = new System.Drawing.Size(143, 69);
            this.PrepararBtn.TabIndex = 1;
            this.PrepararBtn.Text = "Preparar";
            this.PrepararBtn.UseVisualStyleBackColor = false;
            this.PrepararBtn.Click += new System.EventHandler(this.PrepararBtn_Click);
            // 
            // Sair
            // 
            this.Sair.BackColor = System.Drawing.Color.Gainsboro;
            this.Sair.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Sair.BackgroundImage")));
            this.Sair.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Sair.FlatAppearance.BorderSize = 0;
            this.Sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sair.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sair.ForeColor = System.Drawing.Color.Maroon;
            this.Sair.Location = new System.Drawing.Point(44, 502);
            this.Sair.Name = "Sair";
            this.Sair.Size = new System.Drawing.Size(143, 69);
            this.Sair.TabIndex = 0;
            this.Sair.Text = "Sair";
            this.Sair.UseVisualStyleBackColor = false;
            this.Sair.Click += new System.EventHandler(this.Sair_Click);
            // 
            // Opcoes
            // 
            this.Opcoes.BackColor = System.Drawing.Color.Transparent;
            this.Opcoes.Controls.Add(this.CafeComLeiteOpt);
            this.Opcoes.Controls.Add(this.MochaOpt);
            this.Opcoes.Controls.Add(this.CappuccinoOpt);
            this.Opcoes.Controls.Add(this.CafeOpt);
            this.Opcoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Opcoes.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Opcoes.Location = new System.Drawing.Point(772, 12);
            this.Opcoes.Name = "Opcoes";
            this.Opcoes.Size = new System.Drawing.Size(219, 156);
            this.Opcoes.TabIndex = 2;
            this.Opcoes.TabStop = false;
            this.Opcoes.Text = "Escolha sua bebida";
            // 
            // CafeComLeiteOpt
            // 
            this.CafeComLeiteOpt.AutoSize = true;
            this.CafeComLeiteOpt.Location = new System.Drawing.Point(23, 112);
            this.CafeComLeiteOpt.Name = "CafeComLeiteOpt";
            this.CafeComLeiteOpt.Size = new System.Drawing.Size(117, 22);
            this.CafeComLeiteOpt.TabIndex = 3;
            this.CafeComLeiteOpt.TabStop = true;
            this.CafeComLeiteOpt.Text = "Café com Leite";
            this.CafeComLeiteOpt.UseVisualStyleBackColor = true;
            this.CafeComLeiteOpt.CheckedChanged += new System.EventHandler(this.CafeComLeiteOpt_CheckedChanged);
            // 
            // MochaOpt
            // 
            this.MochaOpt.AutoSize = true;
            this.MochaOpt.Location = new System.Drawing.Point(23, 83);
            this.MochaOpt.Name = "MochaOpt";
            this.MochaOpt.Size = new System.Drawing.Size(68, 22);
            this.MochaOpt.TabIndex = 2;
            this.MochaOpt.TabStop = true;
            this.MochaOpt.Text = "Mocha";
            this.MochaOpt.UseVisualStyleBackColor = true;
            this.MochaOpt.CheckedChanged += new System.EventHandler(this.MochaOpt_CheckedChanged);
            // 
            // CappuccinoOpt
            // 
            this.CappuccinoOpt.AutoSize = true;
            this.CappuccinoOpt.Location = new System.Drawing.Point(23, 54);
            this.CappuccinoOpt.Name = "CappuccinoOpt";
            this.CappuccinoOpt.Size = new System.Drawing.Size(97, 22);
            this.CappuccinoOpt.TabIndex = 1;
            this.CappuccinoOpt.TabStop = true;
            this.CappuccinoOpt.Text = "Cappuccino";
            this.CappuccinoOpt.UseVisualStyleBackColor = true;
            this.CappuccinoOpt.CheckedChanged += new System.EventHandler(this.CappuccinoOpt_CheckedChanged);
            // 
            // CafeOpt
            // 
            this.CafeOpt.AutoSize = true;
            this.CafeOpt.Location = new System.Drawing.Point(23, 25);
            this.CafeOpt.Name = "CafeOpt";
            this.CafeOpt.Size = new System.Drawing.Size(54, 22);
            this.CafeOpt.TabIndex = 0;
            this.CafeOpt.TabStop = true;
            this.CafeOpt.Text = "Café";
            this.CafeOpt.UseVisualStyleBackColor = true;
            this.CafeOpt.CheckedChanged += new System.EventHandler(this.CafeOpt_CheckedChanged);
            // 
            // PainelDigital
            // 
            this.PainelDigital.BackColor = System.Drawing.Color.Green;
            this.PainelDigital.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PainelDigital.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PainelDigital.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.PainelDigital.Location = new System.Drawing.Point(466, 80);
            this.PainelDigital.Multiline = true;
            this.PainelDigital.Name = "PainelDigital";
            this.PainelDigital.Size = new System.Drawing.Size(152, 38);
            this.PainelDigital.TabIndex = 3;
            this.PainelDigital.Text = "Ola, escolha uma bebida!";
            // 
            // tabelaMoedas
            // 
            this.tabelaMoedas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabelaMoedas.ColumnCount = 3;
            this.tabelaMoedas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tabelaMoedas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tabelaMoedas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tabelaMoedas.Controls.Add(this.umCentBtn, 0, 0);
            this.tabelaMoedas.Controls.Add(this.cincoCentBtn, 1, 0);
            this.tabelaMoedas.Controls.Add(this.dezCentBtn, 2, 0);
            this.tabelaMoedas.Controls.Add(this.vinteCincoCentBtn, 0, 1);
            this.tabelaMoedas.Controls.Add(this.cinquentaCentBtn, 1, 1);
            this.tabelaMoedas.Controls.Add(this.umRealBtn, 2, 1);
            this.tabelaMoedas.Location = new System.Drawing.Point(772, 211);
            this.tabelaMoedas.Name = "tabelaMoedas";
            this.tabelaMoedas.RowCount = 2;
            this.tabelaMoedas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tabelaMoedas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tabelaMoedas.Size = new System.Drawing.Size(219, 171);
            this.tabelaMoedas.TabIndex = 4;
            // 
            // umCentBtn
            // 
            this.umCentBtn.BackColor = System.Drawing.Color.Gray;
            this.umCentBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.umCentBtn.FlatAppearance.BorderSize = 4;
            this.umCentBtn.Location = new System.Drawing.Point(3, 3);
            this.umCentBtn.Name = "umCentBtn";
            this.umCentBtn.Size = new System.Drawing.Size(67, 79);
            this.umCentBtn.TabIndex = 0;
            this.umCentBtn.Text = "0,01 ";
            this.umCentBtn.UseVisualStyleBackColor = false;
            this.umCentBtn.Click += new System.EventHandler(this.umCentBtn_Click);
            // 
            // cincoCentBtn
            // 
            this.cincoCentBtn.BackColor = System.Drawing.Color.Gray;
            this.cincoCentBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cincoCentBtn.Location = new System.Drawing.Point(76, 3);
            this.cincoCentBtn.Name = "cincoCentBtn";
            this.cincoCentBtn.Size = new System.Drawing.Size(67, 79);
            this.cincoCentBtn.TabIndex = 1;
            this.cincoCentBtn.Text = "0,05";
            this.cincoCentBtn.UseVisualStyleBackColor = false;
            this.cincoCentBtn.Click += new System.EventHandler(this.cincoCentBtn_Click);
            // 
            // dezCentBtn
            // 
            this.dezCentBtn.BackColor = System.Drawing.Color.Gray;
            this.dezCentBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dezCentBtn.Location = new System.Drawing.Point(149, 3);
            this.dezCentBtn.Name = "dezCentBtn";
            this.dezCentBtn.Size = new System.Drawing.Size(67, 79);
            this.dezCentBtn.TabIndex = 2;
            this.dezCentBtn.Text = "0,10";
            this.dezCentBtn.UseVisualStyleBackColor = false;
            this.dezCentBtn.Click += new System.EventHandler(this.dezCentBtn_Click);
            // 
            // vinteCincoCentBtn
            // 
            this.vinteCincoCentBtn.BackColor = System.Drawing.Color.Gray;
            this.vinteCincoCentBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vinteCincoCentBtn.Location = new System.Drawing.Point(3, 88);
            this.vinteCincoCentBtn.Name = "vinteCincoCentBtn";
            this.vinteCincoCentBtn.Size = new System.Drawing.Size(67, 80);
            this.vinteCincoCentBtn.TabIndex = 3;
            this.vinteCincoCentBtn.Text = "0,25";
            this.vinteCincoCentBtn.UseVisualStyleBackColor = false;
            this.vinteCincoCentBtn.Click += new System.EventHandler(this.vinteCincoCentBtn_Click);
            // 
            // cinquentaCentBtn
            // 
            this.cinquentaCentBtn.BackColor = System.Drawing.Color.Gray;
            this.cinquentaCentBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cinquentaCentBtn.Location = new System.Drawing.Point(76, 88);
            this.cinquentaCentBtn.Name = "cinquentaCentBtn";
            this.cinquentaCentBtn.Size = new System.Drawing.Size(67, 80);
            this.cinquentaCentBtn.TabIndex = 4;
            this.cinquentaCentBtn.Text = "0,50";
            this.cinquentaCentBtn.UseVisualStyleBackColor = false;
            this.cinquentaCentBtn.Click += new System.EventHandler(this.cinquentaCentBtn_Click);
            // 
            // umRealBtn
            // 
            this.umRealBtn.BackColor = System.Drawing.Color.Gray;
            this.umRealBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.umRealBtn.Location = new System.Drawing.Point(149, 88);
            this.umRealBtn.Name = "umRealBtn";
            this.umRealBtn.Size = new System.Drawing.Size(67, 80);
            this.umRealBtn.TabIndex = 5;
            this.umRealBtn.Text = "1,00";
            this.umRealBtn.UseVisualStyleBackColor = false;
            this.umRealBtn.Click += new System.EventHandler(this.umRealBtn_Click);
            // 
            // Finalizado
            // 
            this.Finalizado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Finalizado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Finalizado.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Finalizado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Finalizado.Location = new System.Drawing.Point(258, 522);
            this.Finalizado.Multiline = true;
            this.Finalizado.Name = "Finalizado";
            this.Finalizado.Size = new System.Drawing.Size(496, 107);
            this.Finalizado.TabIndex = 5;
            // 
            // FinalizadoImg
            // 
            this.FinalizadoImg.Location = new System.Drawing.Point(772, 401);
            this.FinalizadoImg.Name = "FinalizadoImg";
            this.FinalizadoImg.Size = new System.Drawing.Size(216, 228);
            this.FinalizadoImg.TabIndex = 6;
            this.FinalizadoImg.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1003, 641);
            this.Controls.Add(this.FinalizadoImg);
            this.Controls.Add(this.Finalizado);
            this.Controls.Add(this.tabelaMoedas);
            this.Controls.Add(this.PainelDigital);
            this.Controls.Add(this.Opcoes);
            this.Controls.Add(this.painelEsquerdo);
            this.Controls.Add(this.imagem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Maquina de Café";
            ((System.ComponentModel.ISupportInitialize)(this.imagem)).EndInit();
            this.painelEsquerdo.ResumeLayout(false);
            this.Opcoes.ResumeLayout(false);
            this.Opcoes.PerformLayout();
            this.tabelaMoedas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FinalizadoImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imagem;
        private System.Windows.Forms.Panel painelEsquerdo;
        private System.Windows.Forms.Button Sair;
        private System.Windows.Forms.GroupBox Opcoes;
        private System.Windows.Forms.RadioButton CafeComLeiteOpt;
        private System.Windows.Forms.RadioButton MochaOpt;
        private System.Windows.Forms.RadioButton CappuccinoOpt;
        private System.Windows.Forms.RadioButton CafeOpt;
        private System.Windows.Forms.TextBox PainelDigital;
        private System.Windows.Forms.Button CancelarBtn;
        private System.Windows.Forms.Button PrepararBtn;
        private System.Windows.Forms.TableLayoutPanel tabelaMoedas;
        private System.Windows.Forms.Button umCentBtn;
        private System.Windows.Forms.Button cincoCentBtn;
        private System.Windows.Forms.Button dezCentBtn;
        private System.Windows.Forms.Button vinteCincoCentBtn;
        private System.Windows.Forms.Button cinquentaCentBtn;
        private System.Windows.Forms.Button umRealBtn;
        private System.Windows.Forms.TextBox Finalizado;
        private System.Windows.Forms.PictureBox FinalizadoImg;
    }
}

