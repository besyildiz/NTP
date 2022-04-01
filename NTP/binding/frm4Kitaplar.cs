using System;
using System.Collections;
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
    public partial class frm4Kitaplar : Form
    {
        public frm4Kitaplar()
        {
            InitializeComponent();
        }


        class Kitaplar
        {
            public string KitapYazari { get; set; }
            public string KitapTuru { get; set; }
            public string   KitapAdi { get; set; }
        }
        ArrayList listem = new ArrayList();

        private void btEkle_Click(object sender, EventArgs e)
        {
            Kitaplar kitap = new Kitaplar();
            kitap.KitapAdi = tbKitapAdi.Text;
            kitap.KitapTuru = tbTuru.Text;
            kitap.KitapYazari = tbYazari.Text;
            listem.Add(kitap);


                
        }

        private void btListele_Click(object sender, EventArgs e)
        { 

            listBox1.DataSource = null;
            listBox1.DataSource = listem;
            listBox1.DisplayMember = "KitapAdi";
            listBox2.DataSource = null;
            listBox2.DataSource = listem;
            listBox2.DisplayMember = "KitapYazari";
            listBox3.DataSource = null;
            listBox3.DataSource = listem;
            listBox3.DisplayMember = "KitapTuru";

        }
    }
}
