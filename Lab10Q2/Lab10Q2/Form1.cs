using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab10Q2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string item = txtAdd.Text;
            if (lstFruits.Items.Contains(item))
            {
                MessageBox.Show($"Fruit {item} already exist!", "Warning", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                lstFruits.Items.Add(txtAdd.Text);
                txtAdd.Clear();
            }

        }

        private void lstFruits_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSelected.Text = lstFruits.Text;
        }

        private void lstFruits_DoubleClick(object sender, EventArgs e)
        {
            string item = lstFruits.Text;
            if (MessageBox.Show($"Are you sure you want to delete the fruit: {item}",
                "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)==DialogResult.Yes)
            {
                lstFruits.Items.RemoveAt(lstFruits.SelectedIndex);
            }
        }
    }
}
