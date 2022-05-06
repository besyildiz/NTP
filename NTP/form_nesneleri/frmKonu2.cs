using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NTP
{
    public partial class frmKonu2 : Form
    {
        public frmKonu2()
        {
            InitializeComponent();
        }

        private void btTosya_Click(object sender, EventArgs e)
        {
            lbTosya.Text = "Pirinç";
        }

        private void btDaday_Click(object sender, EventArgs e)
        {
            lbDaday.Text = "Etli ekmek";
        }

        private void btTaskopru_Click(object sender, EventArgs e)
        {
            lbTaskopru.Text = "Sarmısak";
        }

        private void frmKonu2_Load(object sender, EventArgs e)
        {
            lbTaskopru.Text = null;
            lbTosya.Text = null;
            lbDaday.Text = null;


            ToolTip t = new ToolTip();
            t.SetToolTip(btTosya, "Tosya'nın nesi meşhur, tıkla ve gör");
            t.SetToolTip(btDaday, "Daday'ın nesi meşhur, tıkla ve gör");
            t.SetToolTip(btTaskopru, "Tosya'nın nesi meşhur, tıkla ve gör");
        }
    }
}
