using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab11Q3
{
    public partial class Form1 : Form
    {
        int[] ids = new int[5]; 
        string[] names = new string[5]; 
        string[] courses = new string[5];
        int count = 0;

        public Form1()
        {
            InitializeComponent();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtId.Clear();
            txtName.Clear();
            txtCourse.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (count > 5)
            {
                MessageBox.Show("List is full", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                ids[count] = int.Parse(txtId.Text);
                names[count] = txtName.Text;
                courses[count] = txtCourse.Text;
                count++;
                lstIndexes.Items.Add(txtId.Text);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int index = lstIndexes.SelectedIndex;
            ids[lstIndexes.SelectedIndex] = int.Parse(txtId.Text);
            names[lstIndexes.SelectedIndex] = txtName.Text;
            courses[lstIndexes.SelectedIndex] = txtCourse.Text;
            lstIndexes.Items.RemoveAt(lstIndexes.SelectedIndex);
            lstIndexes.Items.Insert(index, txtId.Text);
        }

        private void lstIndexes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstIndexes.SelectedIndex>=0) 
            {
                txtId.Text = ids[lstIndexes.SelectedIndex].ToString();
                txtName.Text = names[lstIndexes.SelectedIndex];
                txtCourse.Text = courses[lstIndexes.SelectedIndex];
            } 
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            int[] tmpIds = new int[ids.Length-1];
            string[] tmpNames = new string[names.Length - 1];
            string[] tmpCourses = new string[courses.Length-1];
            int index = lstIndexes.SelectedIndex;

            for (int i = 0; i<ids.Length;i++) 
            {
                if (i < index)
                {
                    tmpIds[i] = ids[i];
                    tmpNames[i] = names[i];
                    tmpCourses[i] = courses[i];
                }
                if(i>index)
                {
                    tmpIds[i-1] = ids[i];
                    tmpNames[i-1] = names[i];
                    tmpCourses[i-1] = courses[i];
                }
            }
            ids = tmpIds;
            names = tmpNames;
            courses = tmpCourses;
            lstIndexes.Items.RemoveAt(lstIndexes.SelectedIndex);
            txtId.Clear();
            txtName.Clear();
            txtCourse.Clear();  
        }
    }
}
