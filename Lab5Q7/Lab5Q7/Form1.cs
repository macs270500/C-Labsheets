using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5Q7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            double tripDistance = Double.Parse(textBox1.Text);
            double kmPerLiterEstimate = Double.Parse(textBox2.Text);
            double averageCost = Double.Parse(textBox3.Text);
            double litersOfFuel = tripDistance / kmPerLiterEstimate;
            double estimatedCost = litersOfFuel * averageCost;
            textBox4.Text = litersOfFuel.ToString();
            textBox5.Text = estimatedCost.ToString();


        }
    }
}
