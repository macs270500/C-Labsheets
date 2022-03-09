using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admission_fee
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDetermine_Click(object sender, EventArgs e)
        {
            if (radChild.Checked)
            {
                txtFee.Text = "$0.00";
            }
            if (radMinor.Checked)
            {
                txtFee.Text = "$5.00";
            }
            if (radAdult.Checked)
            { 
                txtFee.Text = "$10.00";
            }
            if (radSenoir.Checked)
            {
                txtFee.Text = "$7.50";
            }
            
        }
    }
}
