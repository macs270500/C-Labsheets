using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Assignment
{
    public partial class InvPurchase : Form
    {
        public InvPurchase()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Inventory_Management inventory = new Inventory_Management();
            inventory.Show();
            Close();
        }
        struct Procurement
        {
            public string Supplier;
            public string Product;
            public double Price;
            public int Quantity;
            public double Total;
        }
        List<Procurement> item = new List<Procurement>();
        private void comboBoxSuppliers_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxSuppliers.SelectedItem)
            {
                case "ChinaBrands":
                    comboBoxProduct.Items.Clear();
                    comboBoxProduct.Items.Add("Head Gasket");
                    comboBoxProduct.Items.Add("Headers");
                    break;
                case "Parts Train":
                    comboBoxProduct.Items.Clear();
                    comboBoxProduct.Items.Add("Engine Oil");
                    comboBoxProduct.Items.Add("TurboChargers");
                    break;
                case "KeyStone Automotive":
                    comboBoxProduct.Items.Clear();
                    comboBoxProduct.Items.Add("Transmission");
                    comboBoxProduct.Items.Add("Mass Air Flow Sensor");
                    break;
                case "Racerseq":
                    comboBoxProduct.Items.Clear();
                    comboBoxProduct.Items.Add("SuperChargers");
                    comboBoxProduct.Items.Add("Mirrors");
                    break;
            }
        }

        private void comboBoxProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            clsInventory inventory = new clsInventory();
            txtPrice.Text = inventory.Price(comboBoxProduct.Text).ToString();
        }
        string fmtStr = "{0,-20}{1,-20}{2,-15}{3,-15}";
        private void InvPurchase_Load(object sender, EventArgs e)
        {
            lstProducts.Items.Add(string.Format(fmtStr, "SupplierName", "Product", "Price", "Quantity"));
        }
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtQty.Text == "")
            {
                MessageBox.Show("Insert Quantity to continue", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Procurement items = new Procurement();
                items.Supplier = comboBoxSuppliers.Text;
                items.Product = comboBoxProduct.Text;
                items.Price = double.Parse(txtPrice.Text);
                items.Quantity = int.Parse(txtQty.Text);
                double Total = items.Price * double.Parse(items.Quantity.ToString());
                item.Add(items);
                lstProducts.Items.Add(string.Format(fmtStr, items.Supplier, items.Product, items.Price, items.Quantity));
                txtTotal.Text = Total.ToString();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                int index = lstProducts.SelectedIndex;
                item.RemoveAt(lstProducts.SelectedIndex - 1);
                lstProducts.Items.RemoveAt(lstProducts.SelectedIndex);
                Procurement items = new Procurement();
                items.Supplier = comboBoxSuppliers.Text;
                items.Product = comboBoxProduct.Text;
                items.Price = double.Parse(txtPrice.Text);
                items.Quantity = int.Parse(txtQty.Text);
                items.Total = items.Price * items.Quantity;
                item.Insert(index - 1, items);
                lstProducts.Items.Insert(index, string.Format(fmtStr, items.Supplier, items.Product, items.Price, items.Quantity, items.Total));
            }
            catch (Exception)
            {
                MessageBox.Show("Select an item to edit", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void lstProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstProducts.SelectedIndex > 0)
            {
                comboBoxSuppliers.Text = item[lstProducts.SelectedIndex - 1].Supplier.ToString();
                comboBoxProduct.Text = item[lstProducts.SelectedIndex-1].Product.ToString();
                txtPrice.Text = item[lstProducts.SelectedIndex-1].Price.ToString();
                txtQty.Text = item[lstProducts.SelectedIndex-1].Quantity.ToString();
                txtTotal.Text = item[lstProducts.SelectedIndex-1].Total.ToString();
            }
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                item.RemoveAt(lstProducts.SelectedIndex - 1);
                lstProducts.Items.RemoveAt(lstProducts.SelectedIndex);
            }
            catch (Exception)
            {

            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            for(int j = 0; j < clsInventory.Inventory.Count; j++)
            {
                for(int i =0; i <item.Count ; i++)
                {
                    clsInventory.Product product;
                    if (clsInventory.Inventory[j].prodName == item[i].Product )
                    {
                        int quantity = clsInventory.Inventory[j].Qty;
                        quantity += item[i].Quantity;
                        product.prodId = clsInventory.Inventory[j].prodId ;
                        product.prodName = clsInventory.Inventory[j].prodName;
                        product.prodPrice = clsInventory.Inventory[j].prodPrice;
                        product.Qty = quantity;
                        clsInventory.Inventory.RemoveAt(j);
                        clsInventory.Inventory.Insert(j,product);
                    }                    
                }
            }

            MessageBox.Show("Purchase Successful", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
            lstProducts.Items.Clear();
            txtPrice.Clear();
            txtQty.Clear();
            txtTotal.Clear();            
        }
    }
}
