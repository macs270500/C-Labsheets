using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5Q5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            double radius = Double.Parse(textBox1.Text);
            double height = Double.Parse(textBox2.Text);
            double areaOfCircle = Math.PI * radius * radius;
            double volumeOfCylinder = areaOfCircle * height;
            double TSA = (2 * areaOfCircle) + (2 * Math.PI * radius * height);
            textBox3.Text = volumeOfCylinder.ToString();
            textBox4.Text = TSA.ToString();

        }
    }
}