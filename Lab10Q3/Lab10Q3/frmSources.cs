using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab10Q3
{
    public partial class frmSources : Form
    {
        public frmSources()
        {
            InitializeComponent();
        }
        public static double total = 0;
        private void frmSources_Load(object sender, EventArgs e)
        {
            txtName.Text = frmIncome.name;
            mtxtWages.Clear();
            mtxtInterest.Clear();
            mtxtDividened.Clear();
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            total = double.Parse(mtxtWages.Text) + double.Parse(mtxtInterest.Text)
                + double.Parse(mtxtDividened.Text);
            this.Close();
        }
    }
}
