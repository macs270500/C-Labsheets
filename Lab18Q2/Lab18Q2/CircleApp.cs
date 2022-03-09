using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab18Q2
{
    public partial class CircleApp : Form
    {
        public CircleApp()
        {
            InitializeComponent();
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            Circle Tsa = new Circle();
            Tsa.Radius = double.Parse(txtRadius.Text);
            Tsa.Height = double.Parse(txtHeight.Text);

            txtTSA.Text = Tsa.SurfaceAreaCylinder().ToString();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
