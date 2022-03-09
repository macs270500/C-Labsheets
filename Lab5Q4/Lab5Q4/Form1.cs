using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5Q4
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
            double depth = Double.Parse(textBox1.Text);
            double celcius = 10 * depth + 20;
            double fahrenheit = 1.8 * celcius + 32;
            textBox2.Text = celcius.ToString();
            textBox3.Text = fahrenheit.ToString();
        }
    }
}
