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
    public partial class InvCheckInventory : Form
    {
        public InvCheckInventory()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Inventory_Management inventory = new Inventory_Management();
            inventory.Show();
            this.Close();
        }

        private void InvCheckInventory_Load(object sender, EventArgs e)
        {
            for(int i = 0; i < clsInventory.Inventory.Count; i++)
            {
                if (clsInventory.Inventory[i].Qty < 5)
                {
                    ListViewItem lvi = new ListViewItem(clsInventory.Inventory[i].prodId);
                    lvi.SubItems.Add(clsInventory.Inventory[i].prodName);
                    lvi.SubItems.Add(clsInventory.Inventory[i].prodPrice.ToString());
                    lvi.SubItems.Add(clsInventory.Inventory[i].Qty.ToString());
                    checkListView.Items.Add(lvi);
                }
            }
        }
    }
}
