using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab11Q2
{
    public partial class Form1 : Form
    {
        List<int> ids = new List<int>();
        List<string> names = new List<string>();
        List<string> courses = new List<string>();
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
            ids.Add(int.Parse(txtId.Text));
            names.Add(txtName.Text);
            courses.Add(txtCourse.Text);
            lstIndexes.Items.Add(txtId.Text);
        }

        private void lstIndexes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstIndexes.SelectedIndex >= 0)
            {
                txtId.Text = ids[lstIndexes.SelectedIndex].ToString();
                txtName.Text = names[lstIndexes.SelectedIndex];
                txtCourse.Text = courses[lstIndexes.SelectedIndex];
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            ids.RemoveAt(lstIndexes.SelectedIndex);
            names.RemoveAt(lstIndexes.SelectedIndex);
            courses.RemoveAt(lstIndexes.SelectedIndex);
            ids.Insert(lstIndexes.SelectedIndex, int.Parse(txtId.Text));
            names.Insert(lstIndexes.SelectedIndex, txtName.Text);
            courses.Insert(lstIndexes.SelectedIndex, txtCourse.Text);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ids.RemoveAt(lstIndexes.SelectedIndex);
            names.RemoveAt(lstIndexes.SelectedIndex);
            courses.RemoveAt(lstIndexes.SelectedIndex);
            lstIndexes.Items.RemoveAt(lstIndexes.SelectedIndex);
            txtId.Clear();
            txtName.Clear();
            txtCourse.Clear();
        }
    }
}
