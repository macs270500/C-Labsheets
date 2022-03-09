using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab13Q3_3_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private double Vol = 0, TSA = 0;
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double radius = Double.Parse(txtRadius.Text);
            double height = Double.Parse(txtHeight.Text);
            calculate(radius, height)
;            txtVol.Text = Vol.ToString("N2");
            txtTSA.Text = TSA.ToString("N2");
        }
        private void calculate(double radius, double height)
        {
            Vol = (Math.PI * (Math.Pow(radius, 2)) * height);
            TSA = 2 * (Math.PI * radius * height) + 2 * Math.PI * Math.Pow(radius, 2);
        }
    }
}
