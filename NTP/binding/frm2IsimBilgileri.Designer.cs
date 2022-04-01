namespace NTP
{
    partial class frm2IsimBilgileri
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
            this.tbAdSoyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbAlan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btEkle = new System.Windows.Forms.Button();
            this.tbNumara = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbAdSoyad
            // 
            this.tbAdSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbAdSoyad.Location = new System.Drawing.Point(221, 79);
            this.tbAdSoyad.Name = "tbAdSoyad";
            this.tbAdSoyad.Size = new System.Drawing.Size(144, 36);
            this.tbAdSoyad.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(67, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 29);
            this.label2.TabIndex = 10;
            this.label2.Text = "Ad-Soyad";
            // 
            // tbAlan
            // 
            this.tbAlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbAlan.Location = new System.Drawing.Point(221, 36);
            this.tbAlan.Name = "tbAlan";
            this.tbAlan.Size = new System.Drawing.Size(144, 36);
            this.tbAlan.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(67, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Kaynak";
            // 
            // btEkle
            // 
            this.btEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btEkle.Location = new System.Drawing.Point(360, 228);
            this.btEkle.Name = "btEkle";
            this.btEkle.Size = new System.Drawing.Size(94, 66);
            this.btEkle.TabIndex = 7;
            this.btEkle.Text = "Ekle";
            this.btEkle.UseVisualStyleBackColor = true;
            this.btEkle.Click += new System.EventHandler(this.btEkle_Click);
            // 
            // tbNumara
            // 
            this.tbNumara.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbNumara.Location = new System.Drawing.Point(221, 128);
            this.tbNumara.Name = "tbNumara";
            this.tbNumara.Size = new System.Drawing.Size(144, 36);
            this.tbNumara.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(67, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 29);
            this.label3.TabIndex = 14;
            this.label3.Text = "Numara";
            // 
            // frm2IsimBilgileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 418);
            this.Controls.Add(this.tbNumara);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbAdSoyad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbAlan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btEkle);
            this.Name = "frm2IsimBilgileri";
            this.Text = "Numara";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbAdSoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbAlan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btEkle;
        private System.Windows.Forms.TextBox tbNumara;
        private System.Windows.Forms.Label label3;
    }
}