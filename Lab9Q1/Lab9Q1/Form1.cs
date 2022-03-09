using System;
using System.Windows.Forms;

namespace Lab9Q1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lstRocket_Click(object sender, EventArgs e)
        {
            int i = 10;
            for (i = 10; i >= 1; i--)
            {
                lstRocket.Items.Add($"{i}");
            }
            if (i == 0)
            {
                lstRocket.Items.Add("The rocket is now launched!!!");
            }
        }
    }
}
