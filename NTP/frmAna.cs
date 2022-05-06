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
    public partial class frmAna : Form
    {
        public frmAna()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmSifreDegistir f = new frmSifreDegistir();
            f.ShowDialog();

        }

        private void btStokMalzemeleri_Click(object sender, EventArgs e)
        {
            frmStokMalzemeCesidi f = new frmStokMalzemeCesidi();

            f.ShowDialog();
        }

        private void frmAna_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}