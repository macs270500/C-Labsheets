using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A.D.Test2Q1
{
    public partial class frmEMS : Form
    {
        public frmEMS()
        {
            InitializeComponent();
            lstEmployees.Items.Add(String.Format(frmStr, "ID", "Name", "Gross Pay"));
        }
        
        struct Employee
        {
            public int id;
            public string name;
            public Pay myPay;
        }
        struct Pay
        {
            public double rate;
            public double hours;
        }
        List<Employee> allEmployees = new List<Employee>();
        string frmStr = "{0,-10}{1,-15}{2,0}";
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Employee EMP;
                EMP.id = int.Parse(txtID.Text);
                EMP.name = txtName.Text;
                EMP.myPay.hours = double.Parse(txtHours.Text);
                EMP.myPay.rate = double.Parse(txtRate.Text);
                double grosspay = EMP.myPay.rate * EMP.myPay.hours;
                allEmployees.Add(EMP);
                lstEmployees.Items.Add(String.Format(frmStr, EMP.id, EMP.name, grosspay));
            }
            catch(FormatException ex)
            {
                MessageBox.Show(ex.Message,"Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtID.Focus();
            }
        }

        private void lstEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstEmployees.SelectedIndex > 0)
            {
                int index = lstEmployees.SelectedIndex;
                Employee EMP = allEmployees[index-1];
                txtID.Text = EMP.id.ToString();
                txtName.Text = EMP.name;
                txtHours.Text = EMP.myPay.hours.ToString();
                txtRate.Text = EMP.myPay.rate.ToString();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstEmployees.SelectedIndex > 0)
            {
                allEmployees.RemoveAt(lstEmployees.SelectedIndex - 1);
                lstEmployees.Items.RemoveAt(lstEmployees.SelectedIndex);
                btnClear_Click(sender, e);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            txtName.Clear();
            txtHours.Clear();
            txtRate.Clear();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lstEmployees.SelectedIndex > 0)
            {
                int index = lstEmployees.SelectedIndex;
                Employee EMP;
                EMP.id = int.Parse(txtID.Text);
                EMP.name = txtName.Text;
                EMP.myPay.hours = double.Parse(txtHours.Text);
                EMP.myPay.rate = double.Parse(txtRate.Text);
                double grosspay = EMP.myPay.rate * EMP.myPay.hours;
                allEmployees.RemoveAt(index-1);
                allEmployees.Insert(index-1, EMP);
                lstEmployees.Items.RemoveAt(index);
                lstEmployees.Items.Insert(index, String.Format(frmStr, EMP.id, EMP.name, grosspay));
            }
        }
    }
}
