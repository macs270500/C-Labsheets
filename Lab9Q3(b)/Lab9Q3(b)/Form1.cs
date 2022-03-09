using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab9Q3_b_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnCompute_Click(object sender, EventArgs e)
        {
            int count = int.Parse(txtSubjects.Text);
            double total = 0, average = 0;
            for (int i = 1; i <= count ; i++)
            {
                total += double.Parse((lstMarks.Items[lstMarks.Items.Count-i]).ToString());
            }
            average = total / count;
            txtTotal.Text = total.ToString("N0");
            txtAverage.Text = average.ToString("N1");
        }
    }
}
 