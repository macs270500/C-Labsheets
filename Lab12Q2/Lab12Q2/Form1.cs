using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab12Q2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double length = double.Parse(txtLength.Text);
            double width = double.Parse(txtWidth.Text);

            double area = AreaOfRectangle(length,width);
            double perimeter = PerimeterOfRectangle(length, width);
            txtArea.Text = area.ToString();
            txtPerimeter.Text = perimeter.ToString();
        }
        static double AreaOfRectangle(double length, double width)
        {
            double area = length * width;
            return area;
        }

        static double PerimeterOfRectangle(double length, double width)
        {
            double perimeter = (2 * length) + (2 * width);
            return perimeter;
        }
    }
}
