using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Purchase_Form_Test
{
    public partial class frmOrder : Form
    {
        public frmOrder()
        {
            InitializeComponent();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != "")
                if(prodName.Text!= "")
                    if(prodQty.Text != "")
                    {
                        ListViewItem lvi = new ListViewItem(comboBox1.Text);
                        lvi.SubItems.Add(SupName.Text);
                        lvi.SubItems.Add(prodName.Text);
                        lvi.SubItems.Add(prodQty.Text);
                        listView1.Items.Add(lvi);
                        prodName.Clear();
                        prodQty.Clear();
                    }          
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.Text == "001")
            {
                SupName.Text = "xxx";
            }
            else if(comboBox1.Text == "002")
            {
                SupName.Text = "yyy";
            }
            else if (comboBox1.Text == "003")
            {
                SupName.Text = "zzz";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
        }
    }
}
