using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab20Q1
{
    public partial class frmStudentRegistration : Form
    {
        public frmStudentRegistration()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ListViewItem lvi = new ListViewItem(txtStudID.Text);
            lvi.SubItems.Add(txtFirst.Text);
            lvi.SubItems.Add(txtLast.Text);
            lvi.SubItems.Add(txtCourseID.Text);
            listViewStudent.Items.Add(lvi);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to delete this item?","Confirm",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
             
            if (result==DialogResult.Yes)
            {
                try
                {
                    listViewStudent.Items.RemoveAt(listViewStudent.SelectedIndices[0]);

                    btnClear_Click(sender, e);
                }
                catch (ArgumentOutOfRangeException AOORE)
                {
                    MessageBox.Show(AOORE.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtStudID.Clear();
            txtFirst.Clear();
            txtLast.Clear();
            txtCourseID.Clear();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string studid = txtStudID.Text;
            bool found = false;
            for(int i =0;i<listViewStudent.Items.Count;i++)
            {
                if(listViewStudent.Items[i].Text == studid)
                {
                    MessageBox.Show("Student ID Found","Record Found",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    int index = i;
                    txtStudID.Text = listViewStudent.Items[index].Text;
                    txtFirst.Text = listViewStudent.Items[index].SubItems[1].Text;
                    txtLast.Text = listViewStudent.Items[index].SubItems[2].Text;
                    txtCourseID.Text = listViewStudent.Items[index].SubItems[3].Text;
                    found = true;
                }               
            }
            if (found == false)
            {
                MessageBox.Show("Student ID Not Found","Record Not Found",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                int index = listViewStudent.SelectedIndices[0];
                listViewStudent.Items[index].Text = txtStudID.Text;
                listViewStudent.Items[index].SubItems[1].Text = txtFirst.Text;
                listViewStudent.Items[index].SubItems[2].Text = txtLast.Text;
                listViewStudent.Items[index].SubItems[3].Text = txtCourseID.Text;
            }
            catch (ArgumentOutOfRangeException AOORE)
            {
                MessageBox.Show(AOORE.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void listViewStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewStudent.SelectedIndices.Count > 0)
            {
                int index = listViewStudent.SelectedIndices[0];
                txtStudID.Text = listViewStudent.Items[index].Text;
                txtFirst.Text = listViewStudent.Items[index].SubItems[1].Text;
                txtLast.Text = listViewStudent.Items[index].SubItems[2].Text;
                txtCourseID.Text = listViewStudent.Items[index].SubItems[3].Text;
            }
        }
    }
}
