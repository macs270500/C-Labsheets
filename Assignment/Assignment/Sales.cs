using System;
using System.Windows.Forms;

namespace Assignment
{
    public partial class Sales : Form
    {
        public Sales()
        {
            InitializeComponent();
        }

        private void Sales_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < clsInventory.Inventory.Count; i++)
            {
                cmbProdName.Items.Add(clsInventory.Inventory[i].prodName);
            }
        }

        private void cmbProdName_SelectedIndexChanged(object sender, EventArgs e)
        {
            clsInventory Inventory = new clsInventory();
            txtProdId.Text = clsInventory.Inventory[cmbProdName.SelectedIndex].prodId;
            txtPrice.Text = Inventory.Price(cmbProdName.Text).ToString();
        }
        static double Total = 0;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtProdId.Text != "")
            {
                if (txtQuantity.Text != "")
                {
                    ListViewItem lvi = new ListViewItem(txtProdId.Text);
                    lvi.SubItems.Add(cmbProdName.Text);
                    lvi.SubItems.Add(txtPrice.Text);
                    lvi.SubItems.Add(txtQuantity.Text);
                    double total = double.Parse(txtPrice.Text) * double.Parse(txtQuantity.Text);
                    lvi.SubItems.Add(total.ToString());
                    prodListView.Items.Add(lvi);
                    Total += total;
                    txtTotal.Text = Total.ToString();
                }
            }
        }

        private void prodListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtProdId.Text = prodListView.SelectedItems[0].Text;
                cmbProdName.Text = prodListView.SelectedItems[0].SubItems[1].Text;
                txtPrice.Text = prodListView.SelectedItems[0].SubItems[2].Text;
                txtQuantity.Text = prodListView.SelectedItems[0].SubItems[3].Text;
            }
            catch (Exception) { }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtQuantity.Text != "")
            {
                try
                {
                    Total -= double.Parse(prodListView.SelectedItems[0].SubItems[4].Text);
                    int index = prodListView.SelectedIndices[0];
                    prodListView.Items.Remove(prodListView.SelectedItems[0]);
                    ListViewItem lvi = new ListViewItem(txtProdId.Text);
                    lvi.SubItems.Add(cmbProdName.Text);
                    lvi.SubItems.Add(txtPrice.Text);
                    lvi.SubItems.Add(txtQuantity.Text);
                    double total = double.Parse(txtPrice.Text) * double.Parse(txtQuantity.Text);
                    lvi.SubItems.Add(total.ToString());
                    prodListView.Items.Insert(index, lvi);
                    Total += total;
                    txtTotal.Text = Total.ToString();
                }
                catch (Exception) { }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Total -= double.Parse(prodListView.SelectedItems[0].SubItems[4].Text);
                prodListView.Items.Remove(prodListView.SelectedItems[0]);
                txtTotal.Text = Total.ToString();
            }
            catch (Exception) { }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Main_menu menu = new Main_menu();
            menu.Show();
            this.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            for(int i =0; i < clsInventory.Inventory.Count; i++)
            {
                for(int j = 0; j < prodListView.Items.Count; j++)
                {                    
                    clsInventory.Product product;
                    if (clsInventory.Inventory[i].prodId == prodListView.Items[j].Text)
                    {
                        int quantity = clsInventory.Inventory[i].Qty;
                        quantity -= int.Parse(prodListView.Items[j].SubItems[3].Text);
                        product.prodId = clsInventory.Inventory[i].prodId;
                        product.prodName = clsInventory.Inventory[ i].prodName;
                        product.prodPrice = clsInventory.Inventory[i].prodPrice;
                        product.Qty = quantity;
                        clsInventory.Inventory.RemoveAt(i);
                        clsInventory.Inventory.Insert( i, product);
                    }
                }
            }
            MessageBox.Show("Sales confirmed", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            prodListView.Items.Clear();
            txtPrice.Clear();
            txtProdId.Clear();
            txtQuantity.Clear();
            txtTotal.Clear();
        }
    }
}
