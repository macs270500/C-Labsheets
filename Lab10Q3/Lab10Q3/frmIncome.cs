using System;
using System.Windows.Forms;

namespace Lab10Q3
{
    public partial class frmIncome : Form
    {
        public static string name;

        public frmIncome()
        {
            InitializeComponent();
        }

        private void btnDetermine_Click(object sender, EventArgs e)
        {
            name = txtName.Text;
            frmSources frm = new frmSources();
            frm.ShowDialog();
            txtIncome.Text = frmSources.total.ToString("N2");
        }

        private void frmIncome_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Goodbye!");
        }
    }
}
