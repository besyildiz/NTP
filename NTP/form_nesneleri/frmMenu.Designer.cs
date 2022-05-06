namespace NTP
{
    partial class frmMenu
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.açToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.farklıKaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yazdırToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.düzenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.kopyalaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.yapıştırToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.renkDeğiştirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkındaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.kesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kopyalaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yapıştırToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rtbYazi = new System.Windows.Forms.RichTextBox();
            this.belge = new System.Drawing.Printing.PrintDocument();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.düzenToolStripMenuItem,
            this.hakkındaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(750, 36);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.açToolStripMenuItem,
            this.kapatToolStripMenuItem,
            this.kaydetToolStripMenuItem,
            this.farklıKaydetToolStripMenuItem,
            this.yazdırToolStripMenuItem});
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(78, 32);
            this.dosyaToolStripMenuItem.Text = "Dosya";
            // 
            // açToolStripMenuItem
            // 
            this.açToolStripMenuItem.Name = "açToolStripMenuItem";
            this.açToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.açToolStripMenuItem.Size = new System.Drawing.Size(219, 32);
            this.açToolStripMenuItem.Text = "Aç";
            this.açToolStripMenuItem.Click += new System.EventHandler(this.açToolStripMenuItem_Click);
            // 
            // kapatToolStripMenuItem
            // 
            this.kapatToolStripMenuItem.Name = "kapatToolStripMenuItem";
            this.kapatToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.kapatToolStripMenuItem.Size = new System.Drawing.Size(219, 32);
            this.kapatToolStripMenuItem.Text = "Kapat";
            this.kapatToolStripMenuItem.Click += new System.EventHandler(this.kapatToolStripMenuItem_Click);
            // 
            // kaydetToolStripMenuItem
            // 
            this.kaydetToolStripMenuItem.Name = "kaydetToolStripMenuItem";
            this.kaydetToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.kaydetToolStripMenuItem.Size = new System.Drawing.Size(219, 32);
            this.kaydetToolStripMenuItem.Text = "Kaydet";
            this.kaydetToolStripMenuItem.Click += new System.EventHandler(this.kaydetToolStripMenuItem_Click);
            // 
            // farklıKaydetToolStripMenuItem
            // 
            this.farklıKaydetToolStripMenuItem.Name = "farklıKaydetToolStripMenuItem";
            this.farklıKaydetToolStripMenuItem.Size = new System.Drawing.Size(219, 32);
            this.farklıKaydetToolStripMenuItem.Text = "Farklı Kaydet";
            // 
            // yazdırToolStripMenuItem
            // 
            this.yazdırToolStripMenuItem.Name = "yazdırToolStripMenuItem";
            this.yazdırToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.yazdırToolStripMenuItem.Size = new System.Drawing.Size(219, 32);
            this.yazdırToolStripMenuItem.Text = "Yazdır";
            this.yazdırToolStripMenuItem.Click += new System.EventHandler(this.yazdırToolStripMenuItem_Click);
            // 
            // düzenToolStripMenuItem
            // 
            this.düzenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kesToolStripMenuItem1,
            this.kopyalaToolStripMenuItem1,
            this.yapıştırToolStripMenuItem1,
            this.renkDeğiştirToolStripMenuItem});
            this.düzenToolStripMenuItem.Name = "düzenToolStripMenuItem";
            this.düzenToolStripMenuItem.Size = new System.Drawing.Size(79, 32);
            this.düzenToolStripMenuItem.Text = "Düzen";
            // 
            // kesToolStripMenuItem1
            // 
            this.kesToolStripMenuItem1.Name = "kesToolStripMenuItem1";
            this.kesToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.kesToolStripMenuItem1.Size = new System.Drawing.Size(230, 32);
            this.kesToolStripMenuItem1.Text = "Kes";
            this.kesToolStripMenuItem1.Click += new System.EventHandler(this.kesToolStripMenuItem1_Click);
            // 
            // kopyalaToolStripMenuItem1
            // 
            this.kopyalaToolStripMenuItem1.Name = "kopyalaToolStripMenuItem1";
            this.kopyalaToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.kopyalaToolStripMenuItem1.Size = new System.Drawing.Size(230, 32);
            this.kopyalaToolStripMenuItem1.Text = "Kopyala";
            this.kopyalaToolStripMenuItem1.Click += new System.EventHandler(this.kopyalaToolStripMenuItem1_Click);
            // 
            // yapıştırToolStripMenuItem1
            // 
            this.yapıştırToolStripMenuItem1.Name = "yapıştırToolStripMenuItem1";
            this.yapıştırToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.yapıştırToolStripMenuItem1.Size = new System.Drawing.Size(230, 32);
            this.yapıştırToolStripMenuItem1.Text = "Yapıştır";
            this.yapıştırToolStripMenuItem1.Click += new System.EventHandler(this.yapıştırToolStripMenuItem1_Click);
            // 
            // renkDeğiştirToolStripMenuItem
            // 
            this.renkDeğiştirToolStripMenuItem.Name = "renkDeğiştirToolStripMenuItem";
            this.renkDeğiştirToolStripMenuItem.Size = new System.Drawing.Size(230, 32);
            this.renkDeğiştirToolStripMenuItem.Text = "Renk Değiştir";
            this.renkDeğiştirToolStripMenuItem.Click += new System.EventHandler(this.renkDeğiştirToolStripMenuItem_Click);
            // 
            // hakkındaToolStripMenuItem
            // 
            this.hakkındaToolStripMenuItem.Name = "hakkındaToolStripMenuItem";
            this.hakkındaToolStripMenuItem.Size = new System.Drawing.Size(106, 32);
            this.hakkındaToolStripMenuItem.Text = "Hakkında";
            this.hakkındaToolStripMenuItem.Click += new System.EventHandler(this.hakkındaToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kesToolStripMenuItem,
            this.kopyalaToolStripMenuItem,
            this.yapıştırToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(133, 76);
            // 
            // kesToolStripMenuItem
            // 
            this.kesToolStripMenuItem.Name = "kesToolStripMenuItem";
            this.kesToolStripMenuItem.Size = new System.Drawing.Size(132, 24);
            this.kesToolStripMenuItem.Text = "Kes";
            this.kesToolStripMenuItem.Click += new System.EventHandler(this.kesToolStripMenuItem_Click);
            // 
            // kopyalaToolStripMenuItem
            // 
            this.kopyalaToolStripMenuItem.Name = "kopyalaToolStripMenuItem";
            this.kopyalaToolStripMenuItem.Size = new System.Drawing.Size(132, 24);
            this.kopyalaToolStripMenuItem.Text = "Kopyala";
            this.kopyalaToolStripMenuItem.Click += new System.EventHandler(this.kopyalaToolStripMenuItem_Click);
            // 
            // yapıştırToolStripMenuItem
            // 
            this.yapıştırToolStripMenuItem.Name = "yapıştırToolStripMenuItem";
            this.yapıştırToolStripMenuItem.Size = new System.Drawing.Size(132, 24);
            this.yapıştırToolStripMenuItem.Text = "Yapıştır";
            this.yapıştırToolStripMenuItem.Click += new System.EventHandler(this.yapıştırToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rtbYazi);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(750, 464);
            this.panel1.TabIndex = 5;
            // 
            // rtbYazi
            // 
            this.rtbYazi.ContextMenuStrip = this.contextMenuStrip1;
            this.rtbYazi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbYazi.Location = new System.Drawing.Point(0, 0);
            this.rtbYazi.Name = "rtbYazi";
            this.rtbYazi.Size = new System.Drawing.Size(750, 464);
            this.rtbYazi.TabIndex = 5;
            this.rtbYazi.Text = "";
            // 
            // belge
            // 
            this.belge.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.belge_PrintPage);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 500);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMenu";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMenu_FormClosed);
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem açToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kapatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kaydetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem farklıKaydetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem düzenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hakkındaToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox rtbYazi;
        private System.Windows.Forms.ToolStripMenuItem kesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kopyalaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yapıştırToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem kopyalaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem yapıştırToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem yazdırToolStripMenuItem;
        private System.Drawing.Printing.PrintDocument belge;
        private System.Windows.Forms.ToolStripMenuItem renkDeğiştirToolStripMenuItem;
    }
}