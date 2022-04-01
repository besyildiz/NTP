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
    public partial class frm2IsimBilgileri : Form
    {
        public frm2IsimBilgileri()
        {
            InitializeComponent();
        }

        class Ogrenciler
        {
            public string Alan { get; set; }
            public string AdSoyad { get; set; }
            public int Numara { get; set; }

        }

        private void btEkle_Click(object sender, EventArgs e)
        {
            Ogrenciler ogrenci = new Ogrenciler();
            ogrenci.Numara = 1111;
            ogrenci.AdSoyad = "Mehmet";
            ogrenci.Alan = "Bilişim Teknolojileri";
            tbNumara.DataBindings.Add("Text", ogrenci, "numara");
            tbAdSoyad.DataBindings.Add("Text", ogrenci, "AdSoyad");
            tbAlan.DataBindings.Add("Text", ogrenci, "Alan");
        }
    }
}
