﻿using System;
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
    public partial class frmStokMalzemeCesidi : Form
    {
        public frmStokMalzemeCesidi()
        {
            InitializeComponent();
        }



        OleDbConnection con;
        OleDbCommand sorgu;
        OleDbDataReader veri;
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

        private void btEkle_Click(object sender, EventArgs e)
        {
            baglanti();
            OleDbCommand sorgu = new OleDbCommand();
            sorgu.CommandText = "insert into stokMalzemeleri (malzemeAdi,birim,markasi) values ('" + tbMalzemeAdi.Text + "', '" + cbBirim.Text + "', '" + tbMarkasi.Text + "')";
            sorgu.Connection = con;
            sorgu.ExecuteNonQuery();
            con.Close();
            tbMalzemeAdi.Text = "";
            tbMarkasi.Text = "";
            gvMalzemeler.Refresh();
        }

        private void frmStokMalzemeCesidi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'verilerimDataSet.stokMalzemeleri' table. You can move, or remove it, as needed.
            this.stokMalzemeleriTableAdapter.Fill(this.verilerimDataSet.stokMalzemeleri);

        }
    }
}
