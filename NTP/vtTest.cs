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
    public partial class vtTest : Form
    {
        public vtTest()
        {
            InitializeComponent();
        }
        OleDbConnection con;
        OleDbCommand sorgu;
        OleDbDataReader veri;

        private void button1_Click(object sender, EventArgs e)
        {
            con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=verilerim.mdb");
            con.Open();
            sorgu = new OleDbCommand();
            sorgu.CommandText = " select * from kullanicilar where kullaniciAdi='Efe' and sifre ='1'";
            sorgu.Connection = con;
            veri = sorgu.ExecuteReader();

            if (veri.Read())
            {
                int sil = 0;
            }

             
     





           // OleDbConnection con = new OleDbConnection(ConfigurationManager.ConnectionStrings["webConnectionString"].ConnectionString);
       
        /*      con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.12.0;Data Source=e:\\web11\\web.mdb");
            string sorgu = "Select * from kisiler id=9";

           da = new OleDbDataAdapter(sorgu, con);
           
            DataTable dt = new DataTable();


          

            da.Fill(dt);


            int sil = 0;
            con.Close();



            /*
          
            da = new OleDbDataAdapter("Select * from kisiler id=9", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "kisiler");
          //  dataGridView1.DataSource = ds.Tables["ogrenci"];
            con.Close();
            */
        }

        private void vtTest_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'verilerimDataSet.kullanicilar' table. You can move, or remove it, as needed.
      //      this.kullanicilarTableAdapter.Fill(this.verilerimDataSet.kullanicilar);

        }
    }
}
