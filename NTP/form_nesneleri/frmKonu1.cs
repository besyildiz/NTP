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
    public partial class frmKonu1 : Form
    {
        public frmKonu1()
        {
            InitializeComponent();
        }

        private void frmKonu1_Load(object sender, EventArgs e)
        {
          //  this.Opacity = 0.5;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Text = "Başlığı değiştirdim";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (tb1.Enabled)
            {
                tb1.Enabled = false;
            }
            else
            {
                tb1.Enabled = true;
            }
        }
        int opacityDegeri = 100;
        private void button6_Click(object sender, EventArgs e)
        {
            

            if (this.Opacity < 1.0)   // Eğer formun opacity değer % 100 den az ise;

            {

                this.Opacity += 0.1;   // bu değeri % 10 arttır..

            }
            else
            {
                this.Opacity -= 0.1;
                if (this.Opacity==0.5)
                {
                    this.Opacity = 1;
                }

            }
             
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Text = "Fare üzerime tıkladı";
        }

        private void button7_MouseHover(object sender, EventArgs e)
        {
            this.Text = "Fare üzerime geldi";
        }

        private void button7_MouseLeave(object sender, EventArgs e)
        {
            this.Text = "Fare üzerimden ayrıldı";
        }
    }
}
