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
    public partial class frmGiris : Form
    {
        public frmGiris()
        {
            InitializeComponent();
        }

        private void btGiris_Click(object sender, EventArgs e)
        {
            if (kontrol(tbKullaniciAdi.Text))
            {
                frmMenu f = new frmMenu();
                this.Visible = false;
                f.Show();
            }

        }

        private bool kontrol(string deger)
        {
            bool sonuc = false;
            try
            {
                if ((Convert.ToDouble(deger) % 1) >= 0)
                {
                    sonuc = true;
                    lbHataKullaniciAdi.Text = "";
                }

            }
            catch (Exception w)
            {

                sonuc = false;
                lbHataKullaniciAdi.Text = "Sayısal bir değer giriniz";
            }
            return sonuc;
        }



        ErrorProvider ep = new ErrorProvider();

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {

        }

        private void tbKullaniciAdi_TextChanged(object sender, EventArgs e)
        {
            if (tbKullaniciAdi.Text==null || tbKullaniciAdi.Text=="")
            {
                lbHataKullaniciAdi.Text = "";
            }
            else
            {
      bool a = kontrol(tbKullaniciAdi.Text);
            }
      

        }

        private void tbKullaniciSifre_TextChanged(object sender, EventArgs e)
        {
            if (tbKullaniciSifre.Text == null || tbKullaniciSifre.Text == "")
            {
                lbHataKullaniciSifresi.Text = "";
            }
            else
            {
                bool a = kontrolSifre(tbKullaniciSifre.Text);
            }


        }

        private bool kontrolSifre(string deger)
        {
            bool sonuc = false;
            try
            {
                if ((Convert.ToDouble(deger) % 1) >= 0)
                {
                    sonuc = false;
                    lbHataKullaniciSifresi.Text = "Metinsel bir değer giriniz";
             
                }

            }
            catch (Exception w)
            {
                sonuc = true;
                lbHataKullaniciSifresi.Text = "";

            }
            return sonuc;
        }
    }
}
