using System;
using System.Windows.Forms;

namespace Lab14Q6_ii_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            initialize();
        }
        struct Student
        {
            public int[] ID;
            public string[] Name;
            public double[] mod1;
            public double[] mod2;
            public double[] mod3;
            public double[] mod4;
        }
        Student myStud = new Student();
        int index = 0;
        private void initialize()
        {

            myStud.ID = new int[5];
            myStud.Name = new string[5];
            myStud.mod1 = new double[5];
            myStud.mod2 = new double[5];
            myStud.mod3 = new double[5];
            myStud.mod4 = new double[5];

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (index < 5)
            {
                myStud.ID[index] = int.Parse(txtID.Text);
                myStud.Name[index] = txtName.Text;
                myStud.mod1[index] = double.Parse(txtMod1.Text);
                myStud.mod2[index] = double.Parse(txtMod2.Text);
                myStud.mod3[index] = double.Parse(txtMod3.Text);
                myStud.mod4[index] = double.Parse(txtMod4.Text);
                lstIndexes.Items.Insert(index, txtID.Text);
                index++;
            }
            else
            {
                MessageBox.Show("Warning! Maximum data input limit reached","Warning",
                    MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void lstIndexes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstIndexes.SelectedIndex >= 0)
            {
                txtID.Text = myStud.ID[lstIndexes.SelectedIndex].ToString();
                txtName.Text = myStud.Name[lstIndexes.SelectedIndex];
                txtMod1.Text = myStud.mod1[lstIndexes.SelectedIndex].ToString();
                txtMod2.Text = myStud.mod2[lstIndexes.SelectedIndex].ToString();
                txtMod3.Text = myStud.mod3[lstIndexes.SelectedIndex].ToString();
                txtMod4.Text = myStud.mod4[lstIndexes.SelectedIndex].ToString();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lstIndexes.SelectedIndex >= 0)
            {
                int lstindexing = lstIndexes.SelectedIndex;
                myStud.ID[lstIndexes.SelectedIndex] = int.Parse(txtID.Text);
                myStud.Name[lstIndexes.SelectedIndex] = txtName.Text;
                myStud.mod1[lstIndexes.SelectedIndex] = double.Parse(txtMod1.Text);
                myStud.mod2[lstIndexes.SelectedIndex] = double.Parse(txtMod2.Text);
                myStud.mod3[lstIndexes.SelectedIndex] = double.Parse(txtMod3.Text);
                myStud.mod4[lstIndexes.SelectedIndex] = double.Parse(txtMod4.Text);
                lstIndexes.Items.RemoveAt(lstIndexes.SelectedIndex);
                lstIndexes.Items.Insert(lstindexing, txtID.Text);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            txtName.Clear();
            txtMod1.Clear();
            txtMod2.Clear();
            txtMod3.Clear();
            txtMod4.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstIndexes.SelectedIndex >= 0)
            {
                int[] tmpIds = new int[myStud.ID.Length - 1];
                string[] tmpNames = new string[myStud.Name.Length - 1];
                double[] tmpMod1 = new double[myStud.mod1.Length - 1];
                double[] tmpMod2 = new double[myStud.mod2.Length - 1];
                double[] tmpMod3 = new double[myStud.mod3.Length - 1];
                double[] tmpMod4 = new double[myStud.mod4.Length - 1];
                int ix = lstIndexes.SelectedIndex;

                for (int i = 0; i < myStud.ID.Length; i++)
                {
                    if (i < ix)
                    {
                        tmpIds[i] = myStud.ID[i];
                        tmpNames[i] = myStud.Name[i];
                        tmpMod1[i] = myStud.mod1[i];
                        tmpMod2[i] = myStud.mod2[i];
                        tmpMod3[i] = myStud.mod3[i];
                        tmpMod4[i] = myStud.mod4[i];
                    }
                    if (i > ix)
                    {
                        tmpIds[i - 1] = myStud.ID[i];
                        tmpNames[i - 1] = myStud.Name[i];
                        tmpMod1[i - 1] = myStud.mod1[i];
                        tmpMod2[i - 1] = myStud.mod2[i];
                        tmpMod3[i - 1] = myStud.mod3[i];
                        tmpMod4[i - 1] = myStud.mod4[i];
                    }
                }
                for (int i = 0; i < tmpIds.Length; i++)
                {
                    myStud.ID[i] = tmpIds[i];
                    myStud.Name[i] = tmpNames[i];
                    myStud.mod1[i] = tmpMod1[i];
                    myStud.mod2[i] = tmpMod2[i];
                    myStud.mod3[i] = tmpMod3[i];
                    myStud.mod4[i] = tmpMod4[i];
                }
                txtID.Clear();
                txtName.Clear();
                txtMod1.Clear();
                txtMod2.Clear();
                txtMod3.Clear();
                txtMod4.Clear();
                lstIndexes.Items.RemoveAt(lstIndexes.SelectedIndex);
                index--;
            }
        }
    }
}
