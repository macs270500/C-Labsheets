using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab13Q6
{
    public partial class AdmissionSystem : Form
    {
        public AdmissionSystem()
        {
            InitializeComponent();
        }

        private void btnCheckQualification_Click(object sender, EventArgs e)
        {
            char[] sub = new char[3];
            sub[0] = Char.Parse(txtSub1.Text);
            sub[1] = Char.Parse(txtSub2.Text);
            sub[2] = Char.Parse(txtSub3.Text);
            string course = txtCourseEnrolled.Text;
            CheckQualification(sub,course,out double totalMarks,out double minMarks,out string result);
            txtTotalMarks.Text = totalMarks.ToString();
            txtMinMarksNeeded.Text = minMarks.ToString();
            txtResult.Text = result;
        }

        private void CheckQualification(char[] sub, string course,out double totalMarks,out double minMarks,out string result)
        {
            double[] marks = new double[3];
            totalMarks = 0;
            minMarks = 0;
            for (int i = 0; i < sub.Length; i++)
            {
                if (sub[i] == Char.Parse("A"))
                {
                    marks[i] = 10;
                }
                else if (sub[i] == Char.Parse("B"))
                {
                    marks[i] = 8;
                }
                else if (sub[i] == Char.Parse("C"))
                {
                    marks[i] = 6;
                }
                else if (sub[i] == Char.Parse("D"))
                {
                    marks[i] = 4;
                }
                else
                {
                    marks[i] = 2;
                }
                totalMarks += marks[i];
            }
            switch (course)
            {
                case "E311":
                    minMarks = 16;
                    break;
                case "E318":
                    minMarks = 18;
                    break;
                case "E319":
                    minMarks = 22;
                    break;
                case "E320":
                    minMarks = 24;
                    break;
            }
            if (totalMarks >= minMarks)
            {
                result = "Qualified";
            }
            else
            {
                result = "Disqualified";
            }
        }
    }
}
