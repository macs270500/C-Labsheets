using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab19Q3
{
    public partial class frmEMS : Form
    {
        public frmEMS()
        {
            InitializeComponent();
            lstEmployee.Items.Add(String.Format(fmtStr, "Id", "Employee Name", "Grosspay"));
        }

        List<clsEmployee> allEmployee = new List<clsEmployee>();        
        string fmtStr = "{0,-10}{1,-20}{2,-10}";        

        private void btnAdd_Click(object sender, EventArgs e)
        {
            clsEmployee Emp = new clsEmployee();
            Emp.EmpId = int.Parse(txtID.Text);
            Emp.EmpName = txtName.Text;
            Emp.PayRate = double.Parse(txtHrlyRate.Text);
            Emp.HrsWrkd = double.Parse(txtHrsWrkd.Text);
            allEmployee.Add(Emp);
            lstEmployee.Items.Add(String.Format(fmtStr, Emp.EmpId, Emp.EmpName, Emp.GrossPay()));
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lstEmployee.SelectedIndex>0) 
            {
                int index = lstEmployee.SelectedIndex;
                clsEmployee Emp = new clsEmployee();
                Emp.EmpId = int.Parse(txtID.Text);
                Emp.EmpName = txtName.Text;
                Emp.PayRate = double.Parse(txtHrlyRate.Text);
                Emp.HrsWrkd = double.Parse(txtHrsWrkd.Text);
                allEmployee.RemoveAt(lstEmployee.SelectedIndex - 1);
                allEmployee.Insert(index - 1, Emp);
                lstEmployee.Items.RemoveAt(lstEmployee.SelectedIndex);
                lstEmployee.Items.Insert(index, String.Format(fmtStr, Emp.EmpId, Emp.EmpName, Emp.GrossPay()));
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstEmployee.SelectedIndex>0)
            {
                allEmployee.RemoveAt(lstEmployee.SelectedIndex - 1);
                lstEmployee.Items.RemoveAt(lstEmployee.SelectedIndex);
                btnClear_Click(sender, e);
            } 
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            txtName.Clear();
            txtHrlyRate.Clear();
            txtHrsWrkd.Clear();            
        }

        private void lstEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            clsEmployee Emp = new clsEmployee();
            if (lstEmployee.SelectedIndex > 0)
            {
                Emp = allEmployee[lstEmployee.SelectedIndex - 1];
                txtID.Text = Emp.EmpId.ToString();
                txtName.Text = Emp.EmpName;
                txtHrlyRate.Text = Emp.PayRate.ToString();
                txtHrsWrkd.Text = Emp.HrsWrkd.ToString();
            }
        }
    }
}
