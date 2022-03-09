using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        Main_menu mainMenu = new Main_menu();
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtUserName.Text == "SystemAdmin")
            {
                if(txtPassword.Text == "sa270500")
                {
                    mainMenu.Show();
                    this.Hide();
                }
                else
                {
                    txtPassword.Clear();
                    txtPassword.Focus();
                    MessageBox.Show("Invalid Password!! Try again");
                }
            }
            else
            {
                txtUserName.Clear();
                txtPassword.Clear();
                txtUserName.Focus();
                MessageBox.Show("Invalid username!! Try Again");
            }
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPassword.Checked == true)
            {
                txtPassword.PasswordChar ='\0';
            }
            else
            {
                txtPassword.PasswordChar ='*';
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
