using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam_Questions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            radStaff.Click += Compute;
            radStudent.Click += Compute;
            radPublic.Click += Compute;
            chkStarter.Click += Compute;
            chkMainMeal.Click += Compute;
            chkDessert.Click += Compute;           
        }

       public  void Compute(object sender ,EventArgs e)
       {
            double total = 0, discount=0,subtotal=0 ;
            if (chkStarter.Checked)
            {
                total += Double.Parse(txtStarter.Text);
                subtotal = total;
            }
            if (chkMainMeal.Checked)
            {
                total += Double.Parse(txtMainMeal.Text);
                subtotal = total;
            }
            if (chkDessert.Checked)
            {
                total += Double.Parse(txtDessert.Text);
                subtotal = total;
            }
            if (chkStarter.Checked && chkMainMeal.Checked && chkDessert.Checked)
            {
                subtotal = Double.Parse(txtStarter.Text) + Double.Parse(txtMainMeal.Text) + Double.Parse(txtDessert.Text);
                discount = subtotal * 0.10;
                total = subtotal - discount;
            }
            txtSubTotal.Text = subtotal.ToString("c");
            txtDiscount.Text = discount.ToString("c");
            txtTotal.Text = total.ToString("c");           
        }

        private void radStaff_CheckedChanged(object sender, EventArgs e)
        {
            if (radStaff.Checked)
            {
                txtStarter.Text = "35";
                txtMainMeal.Text = "80";
                txtDessert.Text = "45";
            }
            
        }

        private void radStudent_CheckedChanged(object sender, EventArgs e)
        {
            if (radStudent.Checked)
            {
                txtStarter.Text = "25";
                txtMainMeal.Text = "75";
                txtDessert.Text = "35";
            }
            
        }

        private void radPublic_CheckedChanged(object sender, EventArgs e)
        {
            if (radPublic.Checked)
            {
                txtStarter.Text = "50";
                txtMainMeal.Text = "100";
                txtDessert.Text = "60";
            }
        }
    }
}
