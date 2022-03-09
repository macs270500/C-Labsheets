using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5Q8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            double x1 = Double.Parse(textBox1.Text);
            double y1 = Double.Parse(textBox2.Text);
            double x2 = Double.Parse(textBox3.Text);
            double y2 = Double.Parse(textBox4.Text);
            double slope = (y2 - y1) / (x2 - x1);
            double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            textBox5.Text = slope.ToString();
            textBox6.Text = distance.ToString();


        }
    }
}
