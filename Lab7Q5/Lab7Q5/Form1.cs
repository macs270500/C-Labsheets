using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7Q5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            radChocolate.Click += Compute;
            radVanilla.Click += Compute;
            radStrawberry.Click += Compute;
            radSmall.Click += Compute;
            radLarge.Click += Compute;
            chkChocoChips.Click += Compute;
            chkCookieCandy.Click += Compute;
            chkNuts.Click += Compute;
            chkFreshFruits.Click += Compute;
        }
        private void Compute(object Sender ,EventArgs e)
        {
            double sum=0;
            if (radSmall.Checked)
            {
                if (radChocolate.Checked)
                {
                    sum = 60.00;
                }
                else if (radVanilla.Checked)
                {
                    sum = 45.00;
                }
                else if (radStrawberry.Checked)
                {
                    sum = 50.00;
                }
            }
            else if (radLarge.Checked)
            {
                if (radChocolate.Checked)
                {
                    sum = 75.00;
                }
                else if (radVanilla.Checked)
                {
                    sum = 65.00;
                }
                else if (radStrawberry.Checked)
                {
                    sum = 60.00;
                }
            }
            if (chkChocoChips.Checked)
            {
                sum += 25.00;
            }
            if (chkCookieCandy.Checked)
            {
                sum += 20.00;
            }
            if (chkNuts.Checked)
            {
                sum += 15.00;
            }
            if (chkFreshFruits.Checked)
            {
                sum += 35.00;
            }
            txtPrice.Text = $"${sum}";
        }     
    }
}
