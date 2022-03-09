using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Days_Determination_in_a_month
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnDetermine_Click(object sender, EventArgs e)
        {
            string month = LstMonths.Text;
            switch (month)
            {
                case "April":
                case "June":
                case "September":
                case "November":
                    txtDays.Text = "30";
                    break;
                case "February":
                    txtDays.Text = "28/29";
                    break;
                default:
                    txtDays.Text = "31";
                    break;
            }
            
        }
    }
}
