using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
// using Cefsharp;
namespace NTP
{
    public partial class frmBrowser : Form
    {
        public frmBrowser()
        {
            InitializeComponent();
        }

   //     public ChromiumWebBrowser chromeBrowser;

        private void btGit_Click(object sender, EventArgs e)
        {
            wbTarayicim.Navigate(tbAdres.Text);
        }

        private void btYenile_Click(object sender, EventArgs e)
        {
            wbTarayicim.Refresh();
        }

        private void btIleri_Click(object sender, EventArgs e)
        {
            wbTarayicim.GoForward();
        }

        private void btGeri_Click(object sender, EventArgs e)
        {
            wbTarayicim.GoBack();
        }
    }
}
