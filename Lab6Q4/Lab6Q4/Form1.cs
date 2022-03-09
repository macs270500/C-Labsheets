using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6Q4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnGrossPay_Click(object sender, EventArgs e)
        {
            double hoursWorked = Double.Parse(txtHrsWorked.Text);
            double hourlyPay = Double.Parse(txtHourlyPay.Text);
            double grossPay;
            if (hoursWorked > 40)
            {
                grossPay = (40 * hourlyPay + (hoursWorked - 40) * hourlyPay * 1.5);
            }
            else
            {
                grossPay = hoursWorked * hourlyPay;
            }
            txtGrossPay.Text = $"${grossPay}";
        }
    }
}
