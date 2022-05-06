using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NTP
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }


        private void kapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #region menü grubu
        private void kesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            kes();
        }

        private void kopyalaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            kopyala();
        }

        private void yapıştırToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            yapistir();

        }
      

        private void kesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kes();
        }

        private void kopyalaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kopyala();

        }

        private void yapıştırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            yapistir();
        }

        #endregion

        private void kes()
        {
            rtbYazi.Cut();
        }

        private void kopyala()
        {
            rtbYazi.Copy();
        }

        private void yapistir()
        {
            rtbYazi.Paste();
        }

        private void hakkındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHakkinda f = new frmHakkinda();
            f.ShowDialog();

        }

        private void yazdırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDialog p = new PrintDialog();
            DialogResult d = p.ShowDialog();
            if (d==DialogResult.OK)
            {
                belge.Print();
            }

        }


        private void açToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog o = new OpenFileDialog();
            o.Filter = "Text Dosyaları | *.txt";
            DialogResult c = o.ShowDialog();
            if (c == DialogResult.OK)
            {
                rtbYazi.LoadFile(o.FileName, RichTextBoxStreamType.PlainText);

            }

        }
        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog s = new SaveFileDialog();

            s.Filter = "Text Dosyaları | *.txt | Tüm Dosyalar | *.*";
            DialogResult d = s.ShowDialog();

            if (d == DialogResult.OK)
            {  //   MessageBox.Show("Kaydetme işlemi başlıyor");
                rtbYazi.SaveFile(s.FileName, RichTextBoxStreamType.PlainText);
            }


        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            rtbYazi.Text = "Efe Evin\nMuhammet Aydın\nFurkan Demirci\nSu kurbağası Bal";


           

        }

        private void belge_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(rtbYazi.Text, rtbYazi.Font, Brushes.Black, new Point(100, 100));
        }

        private void renkDeğiştirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog c = new ColorDialog();
            if (c.ShowDialog()==DialogResult.OK)
            {
                rtbYazi.SelectionColor = c.Color;
            }
        }

        private void frmMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
