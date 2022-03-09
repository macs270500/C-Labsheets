using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    public partial class EmpRegister : Form
    {
        public EmpRegister()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtEmpName.Text != "")
            {
                if(radFullTimer.Checked == true || radPartTimer.Checked == true)
                {
                    clsEmployee.EmpArray[clsEmployee.EmpIndex].EmpID = clsEmployee.EmpIndex+1;
                    clsEmployee.EmpArray[clsEmployee.EmpIndex].EmpName = txtEmpName.Text;
                    if(radFullTimer.Checked == true)
                    {
                        clsEmployee.EmpArray[clsEmployee.EmpIndex].SalaryPerHr = 100;
                        clsEmployee.EmpArray[clsEmployee.EmpIndex].EmpCategory = "Full-Timer"; 
                    }
                    else
                    {
                        clsEmployee.EmpArray[clsEmployee.EmpIndex].SalaryPerHr = 50;
                        clsEmployee.EmpArray[clsEmployee.EmpIndex].EmpCategory = "Part-Timer";
                    }
                    clsEmployee.EmpIndex ++;
                    EmpRegister_Load(sender, e);
                }
            }
        }

        private void EmpRegister_Load(object sender, EventArgs e)
        {
            txtEmpID.Text = (clsEmployee.EmpIndex + 1).ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            EmpDetailedView detailedView = new EmpDetailedView();
            detailedView.Show();
            this.Close();
        }
    }
}
