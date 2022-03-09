using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture_20
{
    public partial class FrmListView1 : Form
    {
        public FrmListView1()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFName.Clear();
            txtLName.Clear();
            txtAddress.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ListViewItem lvi = new ListViewItem(txtFName.Text);
            lvi.SubItems.Add(txtLName.Text);
            lvi.SubItems.Add(txtAddress.Text);

            lviEmployee.Items.Add(lvi);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                //lviEmployee.SelectedItems[0].Text = txtFName.Text;
                //lviEmployee.SelectedItems[0].SubItems[1].Text = txtLName.Text;
                //lviEmployee.SelectedItems[0].SubItems[2].Text = txtAddress.Text;

                //OR

                int index = lviEmployee.SelectedIndices[0];
                lviEmployee.Items[index].Text = txtFName.Text;
                lviEmployee.Items[index].SubItems[1].Text = txtLName.Text;
                lviEmployee.Items[index].SubItems[2].Text = txtAddress.Text;
            }
            catch (ArgumentOutOfRangeException AOORE)
            {
                MessageBox.Show(AOORE.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                //lviEmployee.Items[lviEmployee.SelectedIndices[0]].Remove();
                // OR
                lviEmployee.Items.RemoveAt(lviEmployee.SelectedIndices[0]); 
                btnClear_Click(sender, e);
            }
            catch (ArgumentOutOfRangeException AOORE)
            {
                MessageBox.Show(AOORE.Message,"Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void lviEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (lviEmployee.SelectedIndices.Count > 0)
            //{
            //    txtFName.Text = lviEmployee.SelectedItems[0].Text;
            //    txtLName.Text = lviEmployee.SelectedItems[0].SubItems[1].Text;
            //    txtAddress.Text = lviEmployee.SelectedItems[0].SubItems[2].Text;
            //}
            if (lviEmployee.SelectedIndices.Count > 0)
            {
                int index = lviEmployee.SelectedIndices[0];
                txtFName.Text = lviEmployee.Items[index].Text;
                txtLName.Text = lviEmployee.Items[index].SubItems[1].Text;
                txtAddress.Text = lviEmployee.Items[index].SubItems[2].Text;
            }
        }
    }
}
