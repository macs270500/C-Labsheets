using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab18Q1
{
    public partial class SemesterGradeForm : Form
    {
        public SemesterGradeForm()
        {
            InitializeComponent();
        }

        CalcSemGrade myStud = new CalcSemGrade();

        private void btnEnterInfo_Click(object sender, EventArgs e)
        {
            myStud.Name = txtName.Text;
            myStud.ID = int.Parse(txtID.Text);
            myStud.MidTerm = double.Parse(txtMidTerm.Text);
            myStud.Final = double.Parse(txtFinal.Text);

            lstDisplayGrade.Items.Clear();
            lstDisplayGrade.Items.Add($"Student {myStud.Name} registered");
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            string frmtStr = "{0,-20}{1,-40}{2,-4}";

            lstDisplayGrade.Items.Clear();
            lstDisplayGrade.Items.Add(String.Format(frmtStr,myStud.ID,myStud.Name,myStud.CalSemGrade()));
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
