using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab9Q2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            int count = int.Parse(txtInput.Text);
            if (count % 2 == 0)
            {
                int Odd = 0;
                for (int i = 1; i <= count; i++)
                {                    
                    Odd += 2;
                    lstResult.Items.Add($"{Odd}");
                }
            }
            else
            {
                for (int i = 1; i <= count; i++)
                {
                    lstResult.Items.Add($"{i}");
                }
            }
        }
    }
}
