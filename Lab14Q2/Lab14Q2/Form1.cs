using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab14Q2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDetermine_Click(object sender, EventArgs e)
        {
            string FullName = txtFullName.Text;
            string firstName = FirstName(FullName);
            txtFirstName.Text = firstName;

        }

        private string FirstName(String FullName)
        {
            int index = 0;
            string firstName="";
            foreach (char ch in FullName)
            {
                if (char.IsWhiteSpace(ch))
                {
                    break;
                }
                else
                {
                    index++;
                }
            }
            if (index == FullName.Length)
            {
                MessageBox.Show("Invalid Name! Name must follow format:\nFirst Name [Optional Middle Name(s)] Last Name.", "Name entered NOT valid!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                firstName = FullName.Substring(0, index);
            }
            return firstName;
        }
    }
}
