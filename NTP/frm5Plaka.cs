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
    public partial class frm5Plaka : Form
    {
        public frm5Plaka()
        {
            InitializeComponent();
        }
        class Sehirler
        {
            public string Plaka { get; set; }
            public string SehirAdi { get; set; }
        }

        List<Sehirler> listSehirler = new List<Sehirler>();
        private void btEkle_Click(object sender, EventArgs e)
        {
            Sehirler sehir = new Sehirler();
            sehir.Plaka = tbPlaka.Text;
            sehir.SehirAdi = tbSehir.Text;
            listSehirler.Add(sehir);
            Bagla();

        }

        private void Bagla()
        {
            comboBox1.DataSource = null;
            comboBox1.DataSource = listSehirler;
            comboBox1.DisplayMember = "SehirAdi";
            comboBox1.ValueMember = "Plaka";
        }

       // public string isim { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {
            //   string isim = "Ergün";



            MessageBox.Show(comboBox1.SelectedValue.ToString() + "-->" + comboBox1.Text);
        }
    }
}
