using System;
using System.Windows.Forms;

namespace Lab10Q1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            radRegular.Click += Compute;
            radVisiting.Click += Compute;
            chkCleaning.Click += Compute;
            chkCavity.Click += Compute;
            chkX_Ray.Click += Compute;
        }

        private void Compute(object sender, EventArgs e)
        {
            double total = 0;
            if (radRegular.Checked)
            {
                txtCleaning.Text = 400.ToString("C");
                txtCavity.Text = 600.ToString("C");
                txtX_Ray.Text = 500.ToString("C");
                if (chkCleaning.Checked)
                {
                    total += 400;
                }
                if (chkCavity.Checked)
                {
                    total += 600;
                }
                if (chkX_Ray.Checked)
                {
                    total += 500;
                }

            }
            else
            {
                txtCleaning.Text = 500.ToString("C");
                txtCavity.Text = 700.ToString("C");
                txtX_Ray.Text = 600.ToString("C");
                if (chkCleaning.Checked)
                {
                    total += 500;
                }
                if (chkCavity.Checked)
                {
                    total += 700;
                }
                if (chkX_Ray.Checked)
                {
                    total += 600;
                }
            }
            txtTotal.Text = total.ToString("C");
        }
    }
}

