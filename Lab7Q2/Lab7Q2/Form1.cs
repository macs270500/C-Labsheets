using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7Q2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double sum =0.05* Double.Parse(txtSum.Text);
            if (chkRiot.Checked)
            {
                sum += 2000;
            }
            if (chkTheft.Checked)
            {
                sum += 4500;
            }
            if (chkFire.Checked)
            {
                sum += 3750;
            }
            txtPremium.Text = sum.ToString("C");
        }
    }
}
