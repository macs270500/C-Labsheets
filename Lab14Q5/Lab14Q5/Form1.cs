using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Lab14Q5
{
    public partial class Form1 : Form
    {
        struct Student
        {
            public int id;
            public string name;
            public int CPA;
        }
        List<Student> allStudents = new List<Student>();
        Student stud = new Student();

        public Form1()
        {
            InitializeComponent();
        }

        private void lstIDS_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstIDS.SelectedIndex >= 0)
            {
                stud = allStudents[lstIDS.SelectedIndex];
                txtID.Text = stud.id.ToString();
                txtName.Text = stud.name;
                txtCPA.Text = stud.CPA.ToString();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            stud.id = int.Parse(txtID.Text);
            stud.name = txtName.Text;
            stud.CPA = int.Parse(txtCPA.Text);

            allStudents.Add(stud);
            lstIDS.Items.Add(stud.id);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lstIDS.SelectedIndex >= 0)
            {
                int index = lstIDS.SelectedIndex;
                stud.id = int.Parse(txtID.Text);
                stud.name = txtName.Text;
                stud.CPA = int.Parse(txtCPA.Text);
                allStudents.RemoveAt(lstIDS.SelectedIndex);
                lstIDS.Items.RemoveAt(lstIDS.SelectedIndex);
                allStudents.Insert(index, stud);
                lstIDS.Items.Insert(index, txtID.Text);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstIDS.SelectedIndex >= 0)
            {
                allStudents.RemoveAt(lstIDS.SelectedIndex);
                lstIDS.Items.RemoveAt(lstIDS.SelectedIndex);
                txtID.Clear();
                txtName.Clear();
                txtCPA.Clear();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            txtName.Clear();
            txtCPA.Clear();
        }


    }
}
