using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab15
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void studentsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.studentsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.uoMDbDataSet);

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'uoMDbDataSet.Students' table. You can move, or remove it, as needed.
            this.studentsTableAdapter.Fill(this.uoMDbDataSet.Students);

        }

        private void btnSearchView_Click(object sender, EventArgs e)
        {
            Kalam kalam = new Kalam();
            kalam.ShowDialog();
        }
    }
}
