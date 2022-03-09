using System;
using System.Windows.Forms;

namespace Lab10Q4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int Count = int.Parse(txtNum.Text);
            double total = 0, Average = 0;
            for (int i = 0; i < Count ; i++)
            {
                lstNum.Items.Add(lstMarks.Items[i]);
                total += Double.Parse(lstMarks.Items[i].ToString());
            }
           
            Average = total / Count;
            txtTotal.Text = total.ToString();
            txtAverage.Text = Average.ToString();



        }
    }
}
