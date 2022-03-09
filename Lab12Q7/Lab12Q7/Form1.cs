using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab12Q7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double HrsWrkd = double.Parse(txtHrsWrkd.Text);
            double payrate = double.Parse(txtPayRate.Text);
            double GrossPay = CalcGrossPay(HrsWrkd, payrate);
            txtGrossPay.Text = GrossPay.ToString();
        }
        static double CalcGrossPay(double HrsWrkd, double payRate)
        {
            double grosspay;
            if (HrsWrkd <= 40)
            {
                grosspay = HrsWrkd * payRate;
            }
            else
            {
                grosspay = (40 * payRate) + ((HrsWrkd - 40) * (1.5 * payRate));
            }
            return grosspay;
        }
    }
}
