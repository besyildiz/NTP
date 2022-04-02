using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NTP
{
    public partial class frmSifreDegistir : Form
    {
        public frmSifreDegistir()
        {
            InitializeComponent();
        }

        private void btSifreDegistir_Click(object sender, EventArgs e)
        {
            try
            {
                if (eskiSifreDogru() && yeniSifreDogru())
                {

                }
            }
            catch (Exception w)
            {

                int sil = 0;
            }
        }
        private bool eskiSifreDogru()
        {   if (frmGuvenlik.sifre==tbEskiSifre.Text)
            return true; 
            else { MessageBox.Show("Eski şifre hatalı!..."); return false; }
             
        }
        OleDbConnection con;
        OleDbCommand sorgu;
        OleDbDataReader veri;

        private bool yeniSifreDogru()
        {
            if (tbYeniSifre.Text==tbYeniSifreTekrar.Text)
             return true;else { MessageBox.Show("Yeni şifreler birbirini tutmuyor!..."); return false; }
             
        }


    }
}
