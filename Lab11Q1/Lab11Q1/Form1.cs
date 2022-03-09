using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab11Q1
{
    public partial class Form1 : Form
    {
        public int[] ages = { 57, 61, 57, 57, 58, 57, 61, 54, 68, 51, 49, 64, 50, 48, 65, 52, 56, 46, 54, 49, 51, 47, 55, 55, 54, 42, 51,
            56, 55, 51, 54, 51, 60, 62, 43, 55, 56, 61, 52, 69, 64, 46, 54, 47, 70 };
        public Form1()
        {
            InitializeComponent();
           
            for(int index = 0; index < ages.Length; index++)
            {
                lstAges.Items.Add(ages[index]);
            }
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {

            int max = ages[0], min = ages[0], total = 0, average = 0;
            for (int index = 1; index < ages.Length; index++)
            {
                if (ages[index] > max)
                {
                    max = ages[index];
                }
                if (ages[index] < min)
                {
                    min = ages[index];
                }
                total += ages[index];
            }
            average = total / ages.Length;
            txtMin.Text = min.ToString();
            txtMax.Text = max.ToString();
            txtAverage.Text = average.ToString("N0");
        }
    }
}
