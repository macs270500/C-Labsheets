using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab9Q5
{
    public partial class President_Ages : Form
    {
        public President_Ages()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double Max = 0,Min=0,total=0, average = 0;
            for (int i = 1; i <= (lstAges.Items.Count); i++)
            {
                if (i == 1)
                {
                    Min = Double.Parse(lstAges.Items[i - 1].ToString());
                    Max = Double.Parse(lstAges.Items[i - 1].ToString());
                }
                if (Double.Parse(lstAges.Items[i - 1].ToString())>Max)
                {
                    Max = Double.Parse(lstAges.Items[i - 1].ToString());
                }
                if (Double.Parse(lstAges.Items[i - 1].ToString()) < Min)
                {
                    Min = Double.Parse(lstAges.Items[i - 1].ToString());
                }
                total += Double.Parse(lstAges.Items[i - 1].ToString());
            }
            average = total / lstAges.Items.Count;
            txtMin.Text = Min.ToString();
            txtMax.Text = Max.ToString();
            txtAverage.Text = average.ToString();
        }
    }
}
