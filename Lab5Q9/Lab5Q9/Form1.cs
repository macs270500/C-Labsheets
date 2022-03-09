using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5Q9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            double h = Double.Parse(textBox1.Text);
            double r = Double.Parse(textBox2.Text);
            double h1 = Double.Parse(textBox3.Text);
            double r1 = Double.Parse(textBox4.Text);
            double r2 = Double.Parse(textBox5.Text);
            double h2 = h - h1; 
            double volume = (Math.PI * r * r)*h;
            double volume1 = (Math.PI * r1 * r1) * h1;
            double volume2 = (Math.PI * r2 * r2) * h2;
            double amtNeeded = volume - (volume1 + volume2);
            textBox6.Text = amtNeeded.ToString();
        }
    }
}
