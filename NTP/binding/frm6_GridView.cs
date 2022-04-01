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
    public partial class frm6_GridView : Form
    {
        public frm6_GridView()
        {
            InitializeComponent();
        }


        class Ogrenciler
        {
            public int Numara { get; set; }
            public string AdSoyad { get; set; }
            public int DersNotu { get; set; }
        }

        List<Ogrenciler> liste = new List<Ogrenciler>();

        private void btEkle_Click(object sender, EventArgs e)
        {
            Ogrenciler ogrenci = new Ogrenciler();
            ogrenci.Numara = Convert.ToInt16(tbNumara.Text);
            ogrenci.AdSoyad = tbAdSoyad.Text;
            ogrenci.DersNotu =int.Parse( tbDersNotu.Text);

            liste.Add(ogrenci);
            bagla();

        }

        private void bagla()
        {
            gvListe.DataSource = null;
            gvListe.DataSource = liste;
        }
    }
}
