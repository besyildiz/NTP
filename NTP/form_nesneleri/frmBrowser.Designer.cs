namespace NTP
{
    partial class frmBrowser
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbAdres = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.wbTarayicim = new System.Windows.Forms.WebBrowser();
            this.btGeri = new System.Windows.Forms.Button();
            this.btYenile = new System.Windows.Forms.Button();
            this.btIleri = new System.Windows.Forms.Button();
            this.btGit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Olive;
            this.panel1.Controls.Add(this.btGeri);
            this.panel1.Controls.Add(this.btYenile);
            this.panel1.Controls.Add(this.btIleri);
            this.panel1.Controls.Add(this.btGit);
            this.panel1.Controls.Add(this.tbAdres);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.DarkGray;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(887, 69);
            this.panel1.TabIndex = 1;
            // 
            // tbAdres
            // 
            this.tbAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbAdres.Location = new System.Drawing.Point(12, 12);
            this.tbAdres.Name = "tbAdres";
            this.tbAdres.Size = new System.Drawing.Size(597, 34);
            this.tbAdres.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.wbTarayicim);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 69);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(887, 664);
            this.panel2.TabIndex = 2;
            // 
            // wbTarayicim
            // 
            this.wbTarayicim.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wbTarayicim.Location = new System.Drawing.Point(0, 0);
            this.wbTarayicim.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbTarayicim.Name = "wbTarayicim";
            this.wbTarayicim.Size = new System.Drawing.Size(887, 664);
            this.wbTarayicim.TabIndex = 1;
            // 
            // btGeri
            // 
            this.btGeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btGeri.Image = global::NTP.Properties.Resources.outline_arrow_back_black_24dp;
            this.btGeri.Location = new System.Drawing.Point(693, 13);
            this.btGeri.Name = "btGeri";
            this.btGeri.Size = new System.Drawing.Size(33, 33);
            this.btGeri.TabIndex = 7;
            this.btGeri.UseVisualStyleBackColor = true;
            this.btGeri.Click += new System.EventHandler(this.btGeri_Click);
            // 
            // btYenile
            // 
            this.btYenile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btYenile.Image = global::NTP.Properties.Resources.outline_refresh_black_24dp;
            this.btYenile.Location = new System.Drawing.Point(654, 12);
            this.btYenile.Name = "btYenile";
            this.btYenile.Size = new System.Drawing.Size(33, 33);
            this.btYenile.TabIndex = 6;
            this.btYenile.UseVisualStyleBackColor = true;
            this.btYenile.Click += new System.EventHandler(this.btYenile_Click);
            // 
            // btIleri
            // 
            this.btIleri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btIleri.Image = global::NTP.Properties.Resources.outline_arrow_forward_black_24dp;
            this.btIleri.Location = new System.Drawing.Point(732, 12);
            this.btIleri.Name = "btIleri";
            this.btIleri.Size = new System.Drawing.Size(33, 33);
            this.btIleri.TabIndex = 5;
            this.btIleri.UseVisualStyleBackColor = true;
            this.btIleri.Click += new System.EventHandler(this.btIleri_Click);
            // 
            // btGit
            // 
            this.btGit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btGit.Image = global::NTP.Properties.Resources.outline_search_black_24dp1;
            this.btGit.Location = new System.Drawing.Point(615, 12);
            this.btGit.Name = "btGit";
            this.btGit.Size = new System.Drawing.Size(33, 33);
            this.btGit.TabIndex = 2;
            this.btGit.UseVisualStyleBackColor = true;
            this.btGit.Click += new System.EventHandler(this.btGit_Click);
            // 
            // frmBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 733);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmBrowser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBrowser";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btGit;
        private System.Windows.Forms.TextBox tbAdres;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.WebBrowser wbTarayicim;
        private System.Windows.Forms.Button btYenile;
        private System.Windows.Forms.Button btIleri;
        private System.Windows.Forms.Button btGeri;
    }
}