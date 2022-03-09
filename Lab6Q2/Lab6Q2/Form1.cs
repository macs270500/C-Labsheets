using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6Q2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            if (username =="John" && password=="Smith" || username == "Paula" && password == "Jones")
            {
                txtMessage.Text = "Login successful";
            }
            else
            {
                txtMessage.Text = "Please try again";
            }

            

        }
    }
}
