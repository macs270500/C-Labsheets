using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab12Q4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGrade_Click(object sender, EventArgs e)
        {
            double mark = Double.Parse(txtMark.Text);
            Grade(mark);
        }
        private void Grade(double mark)
        {
            switch (mark)
            {
                case double mk when (mk >= 80):
                    txtGrade.Text = "A";
                    break;
                case double mk when (mk >= 60):
                    txtGrade.Text = "B";
                    break;
                case double mk when (mk >= 40):
                    txtGrade.Text = "C";
                    break;
                default:
                    txtGrade.Text = "D";
                    break;
            }
        }
    }
}
