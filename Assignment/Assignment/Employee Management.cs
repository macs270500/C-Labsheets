using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    public partial class Employee_Management : Form
    {
        public Employee_Management()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Main_menu menu = new Main_menu();
            menu.Show();
            clsEmployee.EmpBool = false;
            this.Close();
        }

        private void Employee_Management_Load(object sender, EventArgs e)
        {
            clsEmployee.EmpArray[0].EmpID = 1;
            clsEmployee.EmpArray[0].EmpName = "Ezio Auditore";
            clsEmployee.EmpArray[0].EmpCategory = "Full-Timer";
            clsEmployee.EmpArray[0].SalaryPerHr = 100;

            clsEmployee.EmpArray[1].EmpID = 2;
            clsEmployee.EmpArray[1].EmpName = "Claudia Auditore";
            clsEmployee.EmpArray[1].EmpCategory = "Full-Timer";
            clsEmployee.EmpArray[1].SalaryPerHr = 100;

            clsEmployee.EmpArray[2].EmpID = 3;
            clsEmployee.EmpArray[2].EmpName = "Cloud Strife";
            clsEmployee.EmpArray[2].EmpCategory = "Full-Timer";
            clsEmployee.EmpArray[2].SalaryPerHr = 200;

            clsEmployee.EmpArray[3].EmpID = 4;
            clsEmployee.EmpArray[3].EmpName = "Edward Kenway";
            clsEmployee.EmpArray[3].EmpCategory = "Full-Timer";
            clsEmployee.EmpArray[3].SalaryPerHr = 250;

            clsEmployee.EmpArray[4].EmpID = 5;
            clsEmployee.EmpArray[4].EmpName = "Connor Kenway";
            clsEmployee.EmpArray[4].EmpCategory = "Part-Timer";
            clsEmployee.EmpArray[4].SalaryPerHr = 100;

            clsEmployee.EmpArray[5].EmpID = 6;
            clsEmployee.EmpArray[5].EmpName = "Haytham Kenway";
            clsEmployee.EmpArray[5].EmpCategory = "Part-Timer";
            clsEmployee.EmpArray[5].SalaryPerHr = 100;

            clsEmployee.EmpArray[6].EmpID = 7;
            clsEmployee.EmpArray[6].EmpName = "Altair Ibn La Ahad";
            clsEmployee.EmpArray[6].EmpCategory = "Full-Timer";
            clsEmployee.EmpArray[6].SalaryPerHr = 100;

            clsEmployee.EmpArray[7].EmpID = 8;
            clsEmployee.EmpArray[7].EmpName = "Crash Bandicoot";
            clsEmployee.EmpArray[7].EmpCategory = "Full-Timer";
            clsEmployee.EmpArray[7].SalaryPerHr = 100;

            clsEmployee.EmpArray[8].EmpID = 9;
            clsEmployee.EmpArray[8].EmpName = "Lara Croft";
            clsEmployee.EmpArray[8].EmpCategory = "Full-Timer";
            clsEmployee.EmpArray[8].SalaryPerHr = 100;

            clsEmployee.EmpArray[9].EmpID = 10;
            clsEmployee.EmpArray[9].EmpName = "Nathan Drake";
            clsEmployee.EmpArray[9].EmpCategory = "Full-Timer";
            clsEmployee.EmpArray[9].SalaryPerHr = 100;


            if (clsEmployee.EmpBool == false)
            {
                for (int i = 0; i < clsEmployee.EmpArray.Length; i++)
                {
                    cmbEmpId.Items.Add(clsEmployee.EmpArray[i].EmpID);
                }
                clsEmployee.EmpBool = true;
            }
        }

        private void cmbEmpId_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtEmpName.Text = clsEmployee.EmpArray[int.Parse(cmbEmpId.Text) - 1].EmpName;
                txtSalaryperHr.Text = (clsEmployee.EmpArray[int.Parse(cmbEmpId.Text) - 1].SalaryPerHr).ToString();
                txtSalaryperDay.Text = clsEmployee.EmpArray[int.Parse(cmbEmpId.Text) - 1].SalaryPerDay.ToString();
                txtCategory.Text = clsEmployee.EmpArray[int.Parse(cmbEmpId.Text) - 1].EmpCategory;
            }
            catch (Exception)
            {

            }
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime TimeIn = DateTime.Parse(txtTimeIn.Text);
                DateTime TimeOut = DateTime.Parse(txtTimeOut.Text);
                TimeSpan HoursWorked = TimeOut.Subtract(TimeIn);
                txtSalaryperDay.Text = (HoursWorked.Hours * clsEmployee.EmpArray[int.Parse(cmbEmpId.Text) - 1].SalaryPerHr).ToString();
                clsEmployee.EmpArray[int.Parse(cmbEmpId.Text) - 1].SalaryPerDay = double.Parse(txtSalaryperDay.Text);
            }
            catch (Exception)
            {

            }
        }

        private void btnDetailedView_Click(object sender, EventArgs e)
        {
            EmpDetailedView detailedView = new EmpDetailedView();
            detailedView.Show();
            clsEmployee.EmpBool = false;
            this.Close();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            try
            {
                int index = int.Parse(cmbEmpId.Text) - 1;
                clsEmployee.EmpArray[index].EmpName = txtEmpName.Text;
                clsEmployee.EmpArray[index].EmpCategory = txtCategory.Text;
                clsEmployee.EmpArray[index].SalaryPerHr = double.Parse(txtSalaryperHr.Text);
            }
            catch (Exception)
            {

            }
        }
    }
}
