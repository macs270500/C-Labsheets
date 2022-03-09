using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab9Q6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string search = txtName.Text;
            bool found = false;
            int count = 0;
            for (int i = 0; i <= lstPresidents.Items.Count - 1; i++)
            {
                string name = lstPresidents.Items[i].ToString();
                count++;
                if (name == search)
                {
                    MessageBox.Show($"Searched {count} item(s).President {search} found at index {i}");

                    found = true;
                }               
            }
            if (found == false)
            {
                MessageBox.Show($"Error! President {search} not found");
            }
        }
    }
}
