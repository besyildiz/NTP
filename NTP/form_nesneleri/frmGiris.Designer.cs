namespace NTP
{
    partial class frmGiris
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
            this.btGiris = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbKullaniciAdi = new System.Windows.Forms.TextBox();
            this.btIptal = new System.Windows.Forms.Button();
            this.tbKullaniciSifre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbHataKullaniciAdi = new System.Windows.Forms.Label();
            this.lbHataKullaniciSifresi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btGiris
            // 
            this.btGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btGiris.Location = new System.Drawing.Point(274, 137);
            this.btGiris.Name = "btGiris";
            this.btGiris.Size = new System.Drawing.Size(69, 37);
            this.btGiris.TabIndex = 0;
            this.btGiris.Text = "Giriş";
            this.btGiris.UseVisualStyleBackColor = true;
            this.btGiris.Click += new System.EventHandler(this.btGiris_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(52, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // tbKullaniciAdi
            // 
            this.tbKullaniciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbKullaniciAdi.Location = new System.Drawing.Point(183, 34);
            this.tbKullaniciAdi.Name = "tbKullaniciAdi";
            this.tbKullaniciAdi.Size = new System.Drawing.Size(160, 30);
            this.tbKullaniciAdi.TabIndex = 2;
            this.tbKullaniciAdi.TextChanged += new System.EventHandler(this.tbKullaniciAdi_TextChanged);
            this.tbKullaniciAdi.Validating += new System.ComponentModel.CancelEventHandler(this.textBox1_Validating);
            // 
            // btIptal
            // 
            this.btIptal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btIptal.Location = new System.Drawing.Point(183, 137);
            this.btIptal.Name = "btIptal";
            this.btIptal.Size = new System.Drawing.Size(69, 37);
            this.btIptal.TabIndex = 3;
            this.btIptal.Text = "İptal";
            this.btIptal.UseVisualStyleBackColor = true;
            // 
            // tbKullaniciSifre
            // 
            this.tbKullaniciSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbKullaniciSifre.Location = new System.Drawing.Point(183, 83);
            this.tbKullaniciSifre.Name = "tbKullaniciSifre";
            this.tbKullaniciSifre.Size = new System.Drawing.Size(160, 30);
            this.tbKullaniciSifre.TabIndex = 4;
            this.tbKullaniciSifre.TextChanged += new System.EventHandler(this.tbKullaniciSifre_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(111, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Şifresi";
            // 
            // lbHataKullaniciAdi
            // 
            this.lbHataKullaniciAdi.AutoSize = true;
            this.lbHataKullaniciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbHataKullaniciAdi.ForeColor = System.Drawing.Color.Red;
            this.lbHataKullaniciAdi.Location = new System.Drawing.Point(361, 39);
            this.lbHataKullaniciAdi.Name = "lbHataKullaniciAdi";
            this.lbHataKullaniciAdi.Size = new System.Drawing.Size(0, 25);
            this.lbHataKullaniciAdi.TabIndex = 6;
            // 
            // lbHataKullaniciSifresi
            // 
            this.lbHataKullaniciSifresi.AutoSize = true;
            this.lbHataKullaniciSifresi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbHataKullaniciSifresi.ForeColor = System.Drawing.Color.Red;
            this.lbHataKullaniciSifresi.Location = new System.Drawing.Point(361, 86);
            this.lbHataKullaniciSifresi.Name = "lbHataKullaniciSifresi";
            this.lbHataKullaniciSifresi.Size = new System.Drawing.Size(0, 25);
            this.lbHataKullaniciSifresi.TabIndex = 7;
            // 
            // frmGiris
            // 
            this.AcceptButton = this.btGiris;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 236);
            this.Controls.Add(this.lbHataKullaniciSifresi);
            this.Controls.Add(this.lbHataKullaniciAdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbKullaniciSifre);
            this.Controls.Add(this.btIptal);
            this.Controls.Add(this.tbKullaniciAdi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btGiris);
            this.Name = "frmGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmGiris";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btGiris;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbKullaniciAdi;
        private System.Windows.Forms.Button btIptal;
        private System.Windows.Forms.TextBox tbKullaniciSifre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbHataKullaniciAdi;
        private System.Windows.Forms.Label lbHataKullaniciSifresi;
    }
}