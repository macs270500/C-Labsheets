using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    public partial class Inventory_Management : Form
    {
        public Inventory_Management()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Main_menu mainMenu = new Main_menu();
            mainMenu.Show();
            this.Close();
        }

        private void btnDetailedView_Click(object sender, EventArgs e)
        {
            InvDetailedView detailedView = new InvDetailedView();
            detailedView.Show();
            this.Close();
        }

        private void Inventory_Management_Load(object sender, EventArgs e)
        {

            txtProdId.Text = clsInventory.Inventory[0].prodId;
            txtProdName.Text = clsInventory.Inventory[0].prodName;
            txtProdPrice.Text = clsInventory.Inventory[0].prodPrice.ToString();
            txtProdQty.Text = clsInventory.Inventory[0].Qty.ToString();
        }
        int index = 0;
        private void btnFirst_Click(object sender, EventArgs e)
        {

            txtProdId.Text = clsInventory.Inventory[0].prodId;
            txtProdName.Text = clsInventory.Inventory[0].prodName;
            txtProdPrice.Text = clsInventory.Inventory[0].prodPrice.ToString();
            txtProdQty.Text = clsInventory.Inventory[0].Qty.ToString();

        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            try
            {
                index--;
                txtProdId.Text = clsInventory.Inventory[index].prodId;
                txtProdName.Text = clsInventory.Inventory[index].prodName;
                txtProdPrice.Text = clsInventory.Inventory[index].prodPrice.ToString();
                txtProdQty.Text = clsInventory.Inventory[index].Qty.ToString();
            }
            catch (ArgumentOutOfRangeException)
            {

            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            try
            {
                index++;
                txtProdId.Text = clsInventory.Inventory[index].prodId;
                txtProdName.Text = clsInventory.Inventory[index].prodName;
                txtProdPrice.Text = clsInventory.Inventory[index].prodPrice.ToString();
                txtProdQty.Text = clsInventory.Inventory[index].Qty.ToString();
            }
            catch (ArgumentOutOfRangeException)
            {

            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            txtProdId.Text = clsInventory.Inventory[clsInventory.Inventory.Count-1].prodId;
            txtProdName.Text = clsInventory.Inventory[clsInventory.Inventory.Count-1].prodName;
            txtProdPrice.Text = clsInventory.Inventory[clsInventory.Inventory.Count-1].prodPrice.ToString();
            txtProdQty.Text = clsInventory.Inventory[clsInventory.Inventory.Count-1].Qty.ToString();
        }

        private void btnCheckInv_Click(object sender, EventArgs e)
        {
            InvCheckInventory checkInventory = new InvCheckInventory();
            checkInventory.Show();
            this.Close();
        }

        

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            InvPurchase purchase = new InvPurchase();
            purchase.Show();
            this.Close();
        }
    }
}
