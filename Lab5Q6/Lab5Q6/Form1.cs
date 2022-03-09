using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5Q6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            double hours = Double.Parse(textBox1.Text);
            double hourlyPay = Double.Parse(textBox2.Text);
            double grossPay = hours * hourlyPay;
            textBox3.Text = grossPay.ToString();
            
        }
    }
}
