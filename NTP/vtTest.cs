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
        OleDbDataAdapter da;
        OleDbCommand cmd;
        DataSet ds;
        private void button1_Click(object sender, EventArgs e)
        {



           // OleDbConnection con = new OleDbConnection(ConfigurationManager.ConnectionStrings["webConnectionString"].ConnectionString);
       
              con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.12.0;Data Source=e:\\web11\\web.mdb");
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
    }
}
