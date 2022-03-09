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
    public partial class Kalam : Form
    {
        public Kalam()
        {
            InitializeComponent();
        }

        private void studentsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate();
            studentsBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(this.uoMDbDataSet);
        }

        private void Kalam_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'uoMDbDataSet.Students' table. You can move, or remove it, as needed.
            studentsTableAdapter.Fill(this.uoMDbDataSet.Students);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {       
            try
            {
                studentsTableAdapter.Search(uoMDbDataSet.Students, txtSearch.Text);                
            }
            catch (Exception ex)
            {                
                MessageBox.Show(ex.Message);
            }
        }

        
    }
}
