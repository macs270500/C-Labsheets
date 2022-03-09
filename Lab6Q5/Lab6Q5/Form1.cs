using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6Q5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnGrade_Click(object sender, EventArgs e)
        {
            double mark = double.Parse(txtMark.Text);
            string grade;
            if (mark>100)
            {
                grade = "Einstein twa pilon!";
            }
            else if (mark >= 80)
            {
                grade = "A";
            }
            else if (mark >= 60)
            {
                grade = "B";
            }
            else if (mark >= 40)
            {
                grade = "C";
            }
            else
            {
                grade = "D";
            }
            txtGrade.Text = grade;
        }
    }
}
