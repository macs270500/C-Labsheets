using System;
using System.Windows.Forms;

namespace Assignment
{
    public partial class EmpDetailedView : Form
    {
        public EmpDetailedView()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Employee_Management employee = new Employee_Management();
            employee.Show();
            Close();
        }

        private void EmpDetailedView_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < clsEmployee.EmpArray.Length; i++)
            {
                ListViewItem lvi = new ListViewItem(clsEmployee.EmpArray[i].EmpID.ToString());
                lvi.SubItems.Add(clsEmployee.EmpArray[i].EmpName);
                lvi.SubItems.Add(clsEmployee.EmpArray[i].EmpCategory);
                lvi.SubItems.Add(clsEmployee.EmpArray[i].SalaryPerHr.ToString());
                lvi.SubItems.Add(clsEmployee.EmpArray[i].SalaryPerDay.ToString());
                EmplistView.Items.Add(lvi);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (EmplistView.SelectedIndices[0] >= 0)
            {
                clsEmployee.Employee[] tmp = new clsEmployee.Employee[clsEmployee.EmpArray.Length];

                int ix = EmplistView.SelectedIndices[0];

                for (int i = 0; i < clsEmployee.EmpArray.Length; i++)
                {
                    if (i < ix)
                    {
                        tmp[i].EmpID = clsEmployee.EmpArray[i].EmpID;
                        tmp[i].EmpName = clsEmployee.EmpArray[i].EmpName;
                        tmp[i].EmpCategory = clsEmployee.EmpArray[i].EmpCategory;
                        tmp[i].SalaryPerHr = clsEmployee.EmpArray[i].SalaryPerHr;
                        tmp[i].SalaryPerDay = clsEmployee.EmpArray[i].SalaryPerDay;
                        
                    }
                    if (i > ix)
                    {
                        tmp[i - 1].EmpID = clsEmployee.EmpArray[i].EmpID;
                        tmp[i - 1].EmpName = clsEmployee.EmpArray[i].EmpName;
                        tmp[i - 1].EmpCategory = clsEmployee.EmpArray[i].EmpCategory;
                        tmp[i - 1].SalaryPerHr = clsEmployee.EmpArray[i].SalaryPerHr;
                        tmp[i - 1].SalaryPerDay = clsEmployee.EmpArray[i].SalaryPerDay;
                        
                    }
                }
                for (int j = 0; j < clsEmployee.EmpArray.Length; j++)
                {
                    clsEmployee.EmpArray[j].EmpID = tmp[j].EmpID;
                    clsEmployee.EmpArray[j].EmpName = tmp[j].EmpName;
                    clsEmployee.EmpArray[j].EmpCategory = tmp[j].EmpCategory;
                    clsEmployee.EmpArray[j].SalaryPerHr = tmp[j].SalaryPerHr;
                    clsEmployee.EmpArray[j].SalaryPerDay = tmp[j].SalaryPerDay;
                }
                EmplistView.SelectedItems[0].Remove();
                clsEmployee.EmpIndex--;
                EmpDetailedView_Load(sender, e);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            EmpRegister register = new EmpRegister();
            register.Show();
            this.Close();
        }
    }
}
