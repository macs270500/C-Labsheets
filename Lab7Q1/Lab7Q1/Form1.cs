using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7Q1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void  btnClear_Click(object sender, EventArgs e)
        {
            this.txtAdult.Clear();
            this.txtChrildren.Clear();
            this.txtDue.Clear();
            this.radMorning.Checked=false;
            this.radAfternoon.Checked=false;
            this.radEvening.Checked=false;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double total = 0;
            double adult = Double.Parse(txtAdult.Text);
            double chrildren = Double.Parse(txtChrildren.Text);
            if (radMorning.Checked)
            {
                total = (adult * 100) + (chrildren * 60);
                txtDue.Text =$"${total}";
            }
            if (radAfternoon.Checked)
            {
                total = (adult * 125) + (chrildren * 75);
                txtDue.Text = $"${total}"; 
            }
            if(radEvening.Checked)
            {
                total = (adult * 150) + (chrildren * 90);
                txtDue.Text = total.ToString("c"); 
            }
                
        }
    }
}
