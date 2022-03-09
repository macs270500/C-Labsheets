using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6Q7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            double speed = Double.Parse(txtSpeed.Text);
            double fine;        
                
            if (speed <= 110)
            {
                    txtOutput.Text = "Speed limit has not been exceeded";
            }
             else if (speed > 110 && speed <=300)
             {
                    fine = 1000 + ((speed - 110) * 50);
                    txtOutput.Text = $"fine is {fine}";
             }
             else if (speed >300 || speed<0)
             {
                MessageBox.Show ("Invalid speed. Try again");
             }
        }
    }
}
