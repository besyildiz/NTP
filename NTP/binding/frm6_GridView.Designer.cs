namespace NTP
{
    partial class frm6_GridView
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
            this.gvListe = new System.Windows.Forms.DataGridView();
            this.tbDersNotu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbAdSoyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNumara = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btEkle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvListe)).BeginInit();
            this.SuspendLayout();
            // 
            // gvListe
            // 
            this.gvListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvListe.Location = new System.Drawing.Point(402, 36);
            this.gvListe.Name = "gvListe";
            this.gvListe.RowTemplate.Height = 24;
            this.gvListe.Size = new System.Drawing.Size(380, 205);
            this.gvListe.TabIndex = 39;
            // 
            // tbDersNotu
            // 
            this.tbDersNotu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbDersNotu.Location = new System.Drawing.Point(200, 128);
            this.tbDersNotu.Name = "tbDersNotu";
            this.tbDersNotu.Size = new System.Drawing.Size(144, 36);
            this.tbDersNotu.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(46, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 29);
            this.label3.TabIndex = 37;
            this.label3.Text = "Ders Notu";
            // 
            // tbAdSoyad
            // 
            this.tbAdSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbAdSoyad.Location = new System.Drawing.Point(200, 79);
            this.tbAdSoyad.Name = "tbAdSoyad";
            this.tbAdSoyad.Size = new System.Drawing.Size(144, 36);
            this.tbAdSoyad.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(46, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 29);
            this.label2.TabIndex = 35;
            this.label2.Text = "Ad-Soyad";
            // 
            // tbNumara
            // 
            this.tbNumara.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbNumara.Location = new System.Drawing.Point(200, 36);
            this.tbNumara.Name = "tbNumara";
            this.tbNumara.Size = new System.Drawing.Size(144, 36);
            this.tbNumara.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(46, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 29);
            this.label1.TabIndex = 33;
            this.label1.Text = "Numara";
            // 
            // btEkle
            // 
            this.btEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btEkle.Location = new System.Drawing.Point(250, 170);
            this.btEkle.Name = "btEkle";
            this.btEkle.Size = new System.Drawing.Size(94, 66);
            this.btEkle.TabIndex = 32;
            this.btEkle.Text = "Ekle";
            this.btEkle.UseVisualStyleBackColor = true;
            this.btEkle.Click += new System.EventHandler(this.btEkle_Click);
            // 
            // frm6_GridView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 636);
            this.Controls.Add(this.gvListe);
            this.Controls.Add(this.tbDersNotu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbAdSoyad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbNumara);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btEkle);
            this.Name = "frm6_GridView";
            this.Text = "frm6_GridView";
            ((System.ComponentModel.ISupportInitialize)(this.gvListe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvListe;
        private System.Windows.Forms.TextBox tbDersNotu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbAdSoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNumara;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btEkle;
    }
}