namespace NTP
{
    partial class frmSifreDegistir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSifreDegistir));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbYeniSifreTekrar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbYeniSifre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbEskiSifre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btIptal = new System.Windows.Forms.Button();
            this.btSifreDegistir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbYeniSifreTekrar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btIptal);
            this.groupBox1.Controls.Add(this.btSifreDegistir);
            this.groupBox1.Controls.Add(this.tbYeniSifre);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbEskiSifre);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(403, 252);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Güvenlik";
            // 
            // tbYeniSifreTekrar
            // 
            this.tbYeniSifreTekrar.Location = new System.Drawing.Point(209, 114);
            this.tbYeniSifreTekrar.Name = "tbYeniSifreTekrar";
            this.tbYeniSifreTekrar.PasswordChar = '&';
            this.tbYeniSifreTekrar.Size = new System.Drawing.Size(160, 30);
            this.tbYeniSifreTekrar.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Yeni Şifreniz(tekrar):";
            // 
            // tbYeniSifre
            // 
            this.tbYeniSifre.Location = new System.Drawing.Point(209, 70);
            this.tbYeniSifre.Name = "tbYeniSifre";
            this.tbYeniSifre.PasswordChar = '&';
            this.tbYeniSifre.Size = new System.Drawing.Size(160, 30);
            this.tbYeniSifre.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Yeni Şifreniz:";
            // 
            // tbEskiSifre
            // 
            this.tbEskiSifre.Location = new System.Drawing.Point(209, 32);
            this.tbEskiSifre.Name = "tbEskiSifre";
            this.tbEskiSifre.PasswordChar = '&';
            this.tbEskiSifre.Size = new System.Drawing.Size(160, 30);
            this.tbEskiSifre.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Eski şifreniz:";
            // 
            // btIptal
            // 
            this.btIptal.Image = ((System.Drawing.Image)(resources.GetObject("btIptal.Image")));
            this.btIptal.Location = new System.Drawing.Point(86, 171);
            this.btIptal.Name = "btIptal";
            this.btIptal.Size = new System.Drawing.Size(114, 67);
            this.btIptal.TabIndex = 5;
            this.btIptal.UseVisualStyleBackColor = true;
            // 
            // btSifreDegistir
            // 
            this.btSifreDegistir.Image = ((System.Drawing.Image)(resources.GetObject("btSifreDegistir.Image")));
            this.btSifreDegistir.Location = new System.Drawing.Point(255, 171);
            this.btSifreDegistir.Name = "btSifreDegistir";
            this.btSifreDegistir.Size = new System.Drawing.Size(114, 67);
            this.btSifreDegistir.TabIndex = 4;
            this.btSifreDegistir.UseVisualStyleBackColor = true;
            this.btSifreDegistir.Click += new System.EventHandler(this.btSifreDegistir_Click);
            // 
            // frmSifreDegistir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 285);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSifreDegistir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Şifre Değiştir";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btIptal;
        private System.Windows.Forms.Button btSifreDegistir;
        private System.Windows.Forms.TextBox tbYeniSifre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbEskiSifre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbYeniSifreTekrar;
        private System.Windows.Forms.Label label3;
    }
}