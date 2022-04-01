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
    public partial class frm3DataSource : Form
    {
        public frm3DataSource()
        {
            InitializeComponent();
        }

        private void btVeriBagla_Click(object sender, EventArgs e)
        {
            string[] siniflar = { "9A", "10A", "11A", "12A" };
            listBox1.DataSource = siniflar;
            comboBox1.DataSource = siniflar;
        }
    }
}
