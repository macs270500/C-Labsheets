using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab14Q7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        struct Student
        {
            public int[] ID;
            public string[] Name;
            public Module Marks;
            public struct Module
            {
                public double[] mod1;
                public double[] mod2;
                public double[] mod3;
                public double[] mod4;
            }
        }
        Student myStud = new Student();
        int index = 0;
        private void initialize()
        {

            myStud.ID = new int[5];
            myStud.Name = new string[5];
            myStud.Marks.mod1 = new double[5];
            myStud.Marks.mod2 = new double[5];
            myStud.Marks.mod3 = new double[5];
            myStud.Marks.mod4 = new double[5];

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            initialize();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (index < 5)
            {
                myStud.ID[index] = int.Parse(txtID.Text);
                myStud.Name[index] = txtName.Text;
                myStud.Marks.mod1[index] = double.Parse(txtMod1.Text);
                myStud.Marks.mod2[index] = double.Parse(txtMod2.Text);
                myStud.Marks.mod3[index] = double.Parse(txtMod3.Text);
                myStud.Marks.mod4[index] = double.Parse(txtMod4.Text);
                lstIndexes.Items.Insert(index, txtID.Text);
                index++;
            }
            else
            {
                MessageBox.Show("Warning! Maximum data input limit reached", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lstIndexes.SelectedIndex >= 0)
            {
                int lstindexing = lstIndexes.SelectedIndex;
                myStud.ID[lstIndexes.SelectedIndex] = int.Parse(txtID.Text);
                myStud.Name[lstIndexes.SelectedIndex] = txtName.Text;
                myStud.Marks.mod1[lstIndexes.SelectedIndex] = double.Parse(txtMod1.Text);
                myStud.Marks.mod2[lstIndexes.SelectedIndex] = double.Parse(txtMod2.Text);
                myStud.Marks.mod3[lstIndexes.SelectedIndex] = double.Parse(txtMod3.Text);
                myStud.Marks.mod4[lstIndexes.SelectedIndex] = double.Parse(txtMod4.Text);
                lstIndexes.Items.RemoveAt(lstIndexes.SelectedIndex);
                lstIndexes.Items.Insert(lstindexing, txtID.Text);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstIndexes.SelectedIndex >= 0)
            {
                int[] tmpIds = new int[myStud.ID.Length - 1];
                string[] tmpNames = new string[myStud.Name.Length - 1];
                double[] tmpMod1 = new double[myStud.Marks.mod1.Length - 1];
                double[] tmpMod2 = new double[myStud.Marks.mod2.Length - 1];
                double[] tmpMod3 = new double[myStud.Marks.mod3.Length - 1];
                double[] tmpMod4 = new double[myStud.Marks.mod4.Length - 1];
                int ix = lstIndexes.SelectedIndex;

                for (int i = 0; i < myStud.ID.Length; i++)
                {
                    if (i < ix)
                    {
                        tmpIds[i] = myStud.ID[i];
                        tmpNames[i] = myStud.Name[i];
                        tmpMod1[i] = myStud.Marks.mod1[i];
                        tmpMod2[i] = myStud.Marks.mod2[i];
                        tmpMod3[i] = myStud.Marks.mod3[i];
                        tmpMod4[i] = myStud.Marks.mod4[i];
                    }
                    if (i > ix)
                    {
                        tmpIds[i - 1] = myStud.ID[i];
                        tmpNames[i - 1] = myStud.Name[i];
                        tmpMod1[i - 1] = myStud.Marks.mod1[i];
                        tmpMod2[i - 1] = myStud.Marks.mod2[i];
                        tmpMod3[i - 1] = myStud.Marks.mod3[i];
                        tmpMod4[i - 1] = myStud.Marks.mod4[i];
                    }
                }
                for (int i = 0; i < tmpIds.Length; i++)
                {
                    myStud.ID[i] = tmpIds[i];
                    myStud.Name[i] = tmpNames[i];
                    myStud.Marks.mod1[i] = tmpMod1[i];
                    myStud.Marks.mod2[i] = tmpMod2[i];
                    myStud.Marks.mod3[i] = tmpMod3[i];
                    myStud.Marks.mod4[i] = tmpMod4[i];
                }
                ClearTextBoxes();
                lstIndexes.Items.RemoveAt(lstIndexes.SelectedIndex);
                index--;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }

        private void lstIndexes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstIndexes.SelectedIndex >= 0)
            {
                txtID.Text = myStud.ID[lstIndexes.SelectedIndex].ToString();
                txtName.Text = myStud.Name[lstIndexes.SelectedIndex];
                txtMod1.Text = myStud.Marks.mod1[lstIndexes.SelectedIndex].ToString();
                txtMod2.Text = myStud.Marks.mod2[lstIndexes.SelectedIndex].ToString();
                txtMod3.Text = myStud.Marks.mod3[lstIndexes.SelectedIndex].ToString();
                txtMod4.Text = myStud.Marks.mod4[lstIndexes.SelectedIndex].ToString();
            }
        }

        private void ClearTextBoxes()
        {
            txtID.Clear();
            txtName.Clear();
            txtMod1.Clear();
            txtMod2.Clear();
            txtMod3.Clear();
            txtMod4.Clear();
        }
    }
}
