using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab19Q2
{
    public partial class frmEmployeeManagementSystem : Form
    {
        public frmEmployeeManagementSystem()
        {
            InitializeComponent();
        }
        clsEmployee Emp = new clsEmployee();
        string fmtStr = "{0,-10}{1,-15}{2,-10}";
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Emp.EmpId = int.Parse(txtID.Text);
            Emp.EmpName = txtName.Text;
            Emp.PayRate = double.Parse(txtHrlyRate.Text);
            Emp.HrsWrkd = double.Parse(txtHrsWrkd.Text);
            lstEmployee.Items.Clear();
            lstEmployee.Items.Add($"Employee {Emp.EmpName} recorded!");           
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            lstEmployee.Items.Clear();
            lstEmployee.Items.Add(String.Format(fmtStr, Emp.EmpId, Emp.EmpName, Emp.GrossPay()));            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            txtName.Clear();
            txtHrlyRate.Clear();
            txtHrsWrkd.Clear();
            lstEmployee.Items.Clear();
        }
    }
}
