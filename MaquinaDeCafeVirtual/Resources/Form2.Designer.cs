namespace MaquinaDeCafeVirtual.Resources
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.TrocoTxt = new System.Windows.Forms.TextBox();
            this.CafeImg = new System.Windows.Forms.PictureBox();
            this.PedidoTxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.CafeImg)).BeginInit();
            this.SuspendLayout();
            // 
            // TrocoTxt
            // 
            this.TrocoTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.TrocoTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TrocoTxt.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TrocoTxt.ForeColor = System.Drawing.Color.Teal;
            this.TrocoTxt.Location = new System.Drawing.Point(23, 405);
            this.TrocoTxt.Multiline = true;
            this.TrocoTxt.Name = "TrocoTxt";
            this.TrocoTxt.ReadOnly = true;
            this.TrocoTxt.Size = new System.Drawing.Size(347, 83);
            this.TrocoTxt.TabIndex = 0;
            // 
            // CafeImg
            // 
            this.CafeImg.Image = ((System.Drawing.Image)(resources.GetObject("CafeImg.Image")));
            this.CafeImg.Location = new System.Drawing.Point(44, 51);
            this.CafeImg.Name = "CafeImg";
            this.CafeImg.Size = new System.Drawing.Size(297, 348);
            this.CafeImg.TabIndex = 1;
            this.CafeImg.TabStop = false;
            // 
            // PedidoTxt
            // 
            this.PedidoTxt.BackColor = System.Drawing.Color.Silver;
            this.PedidoTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PedidoTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PedidoTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.PedidoTxt.Location = new System.Drawing.Point(77, 13);
            this.PedidoTxt.Multiline = true;
            this.PedidoTxt.Name = "PedidoTxt";
            this.PedidoTxt.Size = new System.Drawing.Size(217, 32);
            this.PedidoTxt.TabIndex = 2;
            this.PedidoTxt.Text = "Aqui está o seu pedido.";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MaquinaDeCafeVirtual.Properties.Resources.madeira;
            this.ClientSize = new System.Drawing.Size(391, 500);
            this.Controls.Add(this.PedidoTxt);
            this.Controls.Add(this.CafeImg);
            this.Controls.Add(this.TrocoTxt);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.CafeImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TrocoTxt;
        private System.Windows.Forms.PictureBox CafeImg;
        private System.Windows.Forms.TextBox PedidoTxt;
    }
}