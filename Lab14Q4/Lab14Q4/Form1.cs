﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab14Q4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string names = txtNames.Text;
            string[] Namaiwa = names.Split(';') ;
            for (int i = 0; i < Namaiwa.Length; i++)
            {
                lstNames.Items.Add(Namaiwa[i].ToString());
            }
        }
    }
}
