using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab14Q3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            string fullName = txtFullName.Text;
            string middleName = "";
            int index = 0;
            bool flag = false;
            foreach (char ch in fullName)
            {
                if (Char.IsDigit(ch))
                {                    
                    flag = true;   
                }
                else if (Char.IsLetter(ch))
                {
                    index++;
                }
            }
            if (index == fullName.Length)
            {
                messageBox();
            }
            else if (fullName.StartsWith(" "))
            {
                messageBox();
            }
            else if (fullName.EndsWith(" "))
            {
                messageBox();
            }
            else if(flag == true)
            {
                messageBox();
            }
            else 
            { 
            string[] tokens = fullName.Split();
                for (int i = 1; i < tokens.Length - 1; i++)
                {
                    middleName = middleName + tokens[i].ToString() + " ";
                }
            txtFirstName.Text = tokens[0];
            txtMiddleName.Text = middleName;
            txtLastName.Text = tokens[tokens.Length - 1];
            }
        }

        private void messageBox()
        {
            MessageBox.Show("Invalid! Name must follow the format:" +
                        "\nFirst Name [optional Middle Name(s)] Last Name.", "Name entered NOT valid!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
