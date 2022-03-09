using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vote_for_one
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnVote_Click(object sender, EventArgs e)
        {
            if (radCandidate1.Checked)
            {
                txtVote.Text = "You vote for Kennedy";
            }
            else
            {
                txtVote.Text = "You vote for Nixon";
            }
        }
    }
}
