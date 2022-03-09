using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Benefits_menu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDetermine_Click(object sender, EventArgs e)
        {
            double sum = 0;
            if (chkDrug.Checked)
            {
                sum += 39.15;
            }
            if (chkDental.Checked)
            {
                sum += 10.81;
            }
            if (chkVision.Checked)
            {
                sum += 2.25;
            }
            if (chkMedical.Checked)
            {
                sum += 55.52;
            }

            txtTotal.Text = $"${sum}";
        }
    }
}
