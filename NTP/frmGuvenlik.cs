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
    public partial class frmGuvenlik : Form
    {
        public frmGuvenlik()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public  static string kullaniciAdi="";
           public static string sifre ="";

        OleDbConnection con;
        OleDbCommand sorgu;
        OleDbDataReader veri;
        private void kullaniciBilgileriniKontrolEt()
        {
            try
            {
                con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=verilerim.mdb");
                con.Open();
                sorgu = new OleDbCommand();
                sorgu.CommandText = "select * from kullanicilar where kullaniciAdi='" + tbKullaniciAdi.Text + "' and sifre='" + tbSifre.Text + "'";
                sorgu.Connection = con;
                veri = sorgu.ExecuteReader();
                if (veri.Read())
                {
                    sifre = veri["sifre"].ToString();
                    kullaniciAdi = veri["kullaniciAdi"].ToString();
                    frmAna f = new frmAna();
                    f.Show();
                    this.Visible = false;
                }
                else
                {
                    if (tbKullaniciAdi.Text != kullaniciAdi && tbSifre.Text != sifre)
                        MessageBox.Show("Kullanıcı adı ve şifreniz yanlış", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else

                        if (tbKullaniciAdi.Text != kullaniciAdi)
                        MessageBox.Show("Kullanıcı adı yanlış", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else
                    {
                        if (tbSifre.Text != sifre)
                            MessageBox.Show("Şifreniz yanlış", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }

                }
            }
            catch (Exception w)
            {

                int sil = 0;
            }

        }

        private void tbKullaniciAdi_TextChanged(object sender, EventArgs e)
        {
            EnableYap();
        }

        private void tbSifre_TextChanged(object sender, EventArgs e)
        {
           EnableYap();
        }

        private void EnableYap()
        {
            if (tbKullaniciAdi.Text!=null && tbKullaniciAdi.Text != "" && tbSifre.Text != null && tbSifre.Text != "")
            {
                btGiris.Enabled = true;
            }
            else
            {
                btGiris.Enabled = false;
            }
        }

        private void frmGuvenlik_Load(object sender, EventArgs e)
        {
   
        }

        private void btGiris_Click(object sender, EventArgs e)
        {
            kullaniciBilgileriniKontrolEt();




        }
    }
}
