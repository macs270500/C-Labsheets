using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test1Q2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lstStarter.Click += Compute;
            radFr.Click += Compute;
            RadFN.Click += Compute;
            chkE.Click += Compute;
            chkC.Click += Compute;
        }

        private void Compute(Object Sender, EventArgs e)
        {
            double total = 0;
           string starter= lstStarter.Text;
            switch (starter)
            {
                case "Fried Chicken":
                    total += 30;
                    break;
                case "Crispy Prawns":
                    total += 45;
                    break;
                case "Veg Spring Rolls":
                    total += 25;
                    break;
            }
            if (radFr.Checked)
            {
                total += 110;
            } 
            else
            {
                total += 125;
            }
            if (chkE.Checked)
            {
                total += 25;
            }
            if (chkC.Checked)
            {
                total += 40;
            }
            txtPrice.Text = total.ToString("C");
        }
    
    }
}
