using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture20___Fibonacci
{
    public partial class FrmFibonacci : Form
    {
        public FrmFibonacci()
        {
            InitializeComponent();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            lstResults.Items.Clear();
            int num = int.Parse(txtFN.Text);
            for(int i = 1; i <= num; i++)
            {
                lstResults.Items.Add($"{i}........{FibNum(i)}");
            }
        }
        private int FibNum(int fn)
        {
            if (fn == 1 || fn == 2)
            {
                return 1;
            }
            else
            {
                return FibNum(fn - 1) + FibNum(fn - 2);
            }
        }
    }
}
