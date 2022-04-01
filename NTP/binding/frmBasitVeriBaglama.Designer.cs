namespace NTP
{
    partial class frmBasitVeriBaglama
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
            this.btEkle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbKaynak = new System.Windows.Forms.TextBox();
            this.tbHedef = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb2 = new System.Windows.Forms.TextBox();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btEkle
            // 
            this.btEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btEkle.Location = new System.Drawing.Point(444, 319);
            this.btEkle.Name = "btEkle";
            this.btEkle.Size = new System.Drawing.Size(94, 66);
            this.btEkle.TabIndex = 0;
            this.btEkle.Text = "Ekle";
            this.btEkle.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(151, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kaynak";
            // 
            // tbKaynak
            // 
            this.tbKaynak.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbKaynak.Location = new System.Drawing.Point(263, 199);
            this.tbKaynak.Name = "tbKaynak";
            this.tbKaynak.Size = new System.Drawing.Size(144, 36);
            this.tbKaynak.TabIndex = 2;
            // 
            // tbHedef
            // 
            this.tbHedef.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbHedef.Location = new System.Drawing.Point(263, 242);
            this.tbHedef.Name = "tbHedef";
            this.tbHedef.Size = new System.Drawing.Size(144, 36);
            this.tbHedef.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(151, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Hedef";
            // 
            // tb2
            // 
            this.tb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb2.Location = new System.Drawing.Point(263, 362);
            this.tb2.Name = "tb2";
            this.tb2.Size = new System.Drawing.Size(144, 36);
            this.tb2.TabIndex = 6;
            // 
            // tb1
            // 
            this.tb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb1.Location = new System.Drawing.Point(263, 319);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(144, 36);
            this.tb1.TabIndex = 5;
            this.tb1.TextChanged += new System.EventHandler(this.tb1_TextChanged);
            // 
            // frmBasitVeriBaglama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 483);
            this.Controls.Add(this.tb2);
            this.Controls.Add(this.tb1);
            this.Controls.Add(this.tbHedef);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbKaynak);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btEkle);
            this.Name = "frmBasitVeriBaglama";
            this.Text = "frmBasitVeriBaglama";
            this.Load += new System.EventHandler(this.frmBasitVeriBaglama_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btEkle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbKaynak;
        private System.Windows.Forms.TextBox tbHedef;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb2;
        private System.Windows.Forms.TextBox tb1;
    }
}