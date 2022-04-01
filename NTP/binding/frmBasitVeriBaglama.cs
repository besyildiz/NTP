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
    public partial class frmBasitVeriBaglama : Form
    {
        public frmBasitVeriBaglama()
        {
            InitializeComponent();
        }

        private void frmBasitVeriBaglama_Load(object sender, EventArgs e)
        {
            Binding bagla = new Binding("Text", tb1, "Text");
            Binding bagla2 = new Binding("Text", tb1, "Text");
            //  Binding bagla = new Binding("Text", tb1, "Text");


            tbKaynak.DataBindings.Add(bagla);
            tbHedef.DataBindings.Add(bagla2);

            //   tbKaynak.Text
        }

        private void tb1_TextChanged(object sender, EventArgs e)
        {
         //   tb2.Text = tb1.Text;

        }
    }
}
