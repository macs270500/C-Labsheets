using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab19Q1
{
    public partial class frmMainArray : Form
    {
        public frmMainArray()
        {
            InitializeComponent();
        }
        List<clsStudent> allStud = new List<clsStudent>();
        
        string frmStr = "{0,-20}{1,-30}{2,-25}";
       
        private void btnEnterInfo_Click(object sender, EventArgs e)
        {
            clsStudent myStud = new clsStudent();

            myStud.Id = int.Parse(txtID.Text);
            myStud.Name = txtName.Text;
            myStud.Midterm = double.Parse(txtMidTerm.Text);
            myStud.Final = double.Parse(txtFinal.Text);

            allStud.Add(myStud);
            lstDisplayGrade.Items.Clear();
            lstDisplayGrade.Items.Add($"Student {myStud.Name} recorded!");
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            lstDisplayGrade.Items.Clear();
            lstDisplayGrade.Items.Add(String.Format(frmStr, "ID", "Student Name", "Grade"));
            foreach(clsStudent Stud in allStud)
            {
                lstDisplayGrade.Items.Add(String.Format(frmStr, Stud.Id,Stud.Name,Stud.CalcGrade()));
            }
        }

        private void lstDisplayGrade_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lstDisplayGrade.SelectedIndex;
            if (index > 0)
            {
                clsStudent myStud = allStud[index - 1];
                txtID.Text = myStud.Id.ToString();
                txtName.Text = myStud.Name;
                txtMidTerm.Text = myStud.Midterm.ToString();
                txtFinal.Text = myStud.Final.ToString();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int index = lstDisplayGrade.SelectedIndex ;
            if(index > 0)
            {
                clsStudent myStud = new clsStudent();

                myStud.Id = int.Parse(txtID.Text);
                myStud.Name = txtName.Text;
                myStud.Midterm = double.Parse(txtMidTerm.Text);
                myStud.Final = double.Parse(txtFinal.Text);

                allStud.RemoveAt(lstDisplayGrade.SelectedIndex - 1);
                allStud.Insert(index -1 , myStud);
                lstDisplayGrade.Items.RemoveAt(lstDisplayGrade.SelectedIndex);
                lstDisplayGrade.Items.Insert(index, String.Format(frmStr, myStud.Id, myStud.Name, myStud.CalcGrade()));
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            allStud.RemoveAt(lstDisplayGrade.SelectedIndex - 1);
            lstDisplayGrade.Items.RemoveAt(lstDisplayGrade.SelectedIndex);
            txtID.Clear();
            txtName.Clear();
            txtMidTerm.Clear();
            txtFinal.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
