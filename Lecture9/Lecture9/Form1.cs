using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double population = 300000;
            for (int i = 2012; i <= 2016; i++)
            {
                lstTable.Items.Add(i+"/\\/\\/\\*-+_+-*/\\/\\/\\ "+population.ToString("N0"));
                population += (population * 0.03);
            } 
        }
    }
}
