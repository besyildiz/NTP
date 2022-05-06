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
                    baglanti();
                    sorgu = new OleDbCommand();
                    sorgu.CommandText = "update kullanicilar set sifre='" + tbYeniSifre.Text + "' where kullaniciAdi='" + frmGuvenlik.kullaniciAdi + "'";
                    sorgu.Connection = con;
                    sorgu.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Şifreniz başarıyla değiştirilmiştir");
                }
            }
            catch (Exception w)
            {

                int sil = 0;
            }
        }
        private bool eskiSifreDogru()
        {
            if (frmGuvenlik.sifre == tbEskiSifre.Text)
                return true;
            else { MessageBox.Show("Eski şifre hatalı!..."); return false; }

        }
        OleDbConnection con;
        OleDbCommand sorgu;
        OleDbDataReader veri;

        private bool yeniSifreDogru()
        {
            if (tbYeniSifre.Text == null || tbYeniSifre.Text == "")
            {
                MessageBox.Show("Yeni şifrenizi boş bırakamazsınız!...");
                return false;
            }
            else
            {
                if (tbYeniSifre.Text == tbYeniSifreTekrar.Text)
                    return true;
                else { MessageBox.Show("Yeni şifreler birbirini tutmuyor!..."); return false; }
            }


        }


        public void baglanti()
        {

            try
            {
                con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=verilerim.mdb");
                con.Open();
            }
            catch (Exception w)
            {

                MessageBox.Show(w.Message);
            }
        }

        private void btIptal_Click(object sender, EventArgs e)
        { this.Close();
        }
    }
}
