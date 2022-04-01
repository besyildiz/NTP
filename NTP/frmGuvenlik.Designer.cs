namespace NTP
{
    partial class frmGuvenlik
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGuvenlik));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbSifre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbKullaniciAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btGiris = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.btGiris);
            this.groupBox1.Controls.Add(this.tbSifre);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbKullaniciAdi);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(69, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(375, 276);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Güvenlik";
            // 
            // tbSifre
            // 
            this.tbSifre.Location = new System.Drawing.Point(179, 98);
            this.tbSifre.Name = "tbSifre";
            this.tbSifre.PasswordChar = '&';
            this.tbSifre.Size = new System.Drawing.Size(160, 30);
            this.tbSifre.TabIndex = 3;
            this.tbSifre.Text = "1";
            this.tbSifre.TextChanged += new System.EventHandler(this.tbSifre_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Şifre:";
            // 
            // tbKullaniciAdi
            // 
            this.tbKullaniciAdi.Location = new System.Drawing.Point(179, 58);
            this.tbKullaniciAdi.Name = "tbKullaniciAdi";
            this.tbKullaniciAdi.Size = new System.Drawing.Size(160, 30);
            this.tbKullaniciAdi.TabIndex = 1;
            this.tbKullaniciAdi.Text = "Efe";
            this.tbKullaniciAdi.TextChanged += new System.EventHandler(this.tbKullaniciAdi_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı adı:";
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(36, 172);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 67);
            this.button2.TabIndex = 5;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btGiris
            // 
            this.btGiris.Enabled = false;
            this.btGiris.Image = ((System.Drawing.Image)(resources.GetObject("btGiris.Image")));
            this.btGiris.Location = new System.Drawing.Point(225, 172);
            this.btGiris.Name = "btGiris";
            this.btGiris.Size = new System.Drawing.Size(114, 67);
            this.btGiris.TabIndex = 4;
            this.btGiris.UseVisualStyleBackColor = true;
            this.btGiris.Click += new System.EventHandler(this.btGiris_Click);
            // 
            // frmGuvenlik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 348);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGuvenlik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Güvenli Giriş";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btGiris;
        private System.Windows.Forms.TextBox tbSifre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbKullaniciAdi;
        private System.Windows.Forms.Label label1;
    }
}