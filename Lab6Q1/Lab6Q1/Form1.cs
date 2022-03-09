using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6Q1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            double num1 = Double.Parse(txtNum1.Text);
            double num2 = Double.Parse(txtNum2.Text);
            if (num1 == num2)
            {
                txtLargerNum.Text = "Both numbers are equal";
            }
            else if (num1>num2)
            {
                txtLargerNum.Text = $"{num1} is greater than {num2}";
            }
            else
            {
                txtLargerNum.Text = $"{num2} is greater than {num1}";
            }
        }
    }
}
