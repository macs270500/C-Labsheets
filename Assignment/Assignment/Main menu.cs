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
    public partial class Main_menu : Form
    {
        public Main_menu()
        {
            InitializeComponent();
        }

        
        private void btnExit_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            Inventory_Management inventory = new Inventory_Management();
            inventory.Show();
            this.Close();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            Employee_Management employee = new Employee_Management();
            employee.Show();
            this.Close();
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            Sales sales = new Sales();
            sales.Show();
            this.Close();
        }
        private void AddToListView()
        {

            clsInventory.Product product = new clsInventory.Product();
            product.prodId = "01";
            product.prodName = "TurboChargers";
            product.prodPrice = double.Parse("2000");
            product.Qty = int.Parse("4");
            clsInventory.Inventory.Add(product);

            product.prodId = "02";
            product.prodName = "Headers";
            product.prodPrice = double.Parse("5000");
            product.Qty = int.Parse("10");
            clsInventory.Inventory.Add(product);

            product.prodId = "03";
            product.prodName = "Head Gasket";
            product.prodPrice = double.Parse("3000");
            product.Qty = int.Parse("10");
            clsInventory.Inventory.Add(product);

            product.prodId = "04";
            product.prodName = "Mass Air Flow Sensor";
            product.prodPrice = double.Parse("2000");
            product.Qty = int.Parse("10");
            clsInventory.Inventory.Add(product);

            product.prodId = "05";
            product.prodName = "SuperChargers";
            product.prodPrice = double.Parse("3500");
            product.Qty = int.Parse("3");
            clsInventory.Inventory.Add(product);

            product.prodId = "06";
            product.prodName = "Headlights";
            product.prodPrice = double.Parse("1000");
            product.Qty = int.Parse("10");
            clsInventory.Inventory.Add(product);

            product.prodId = "07";
            product.prodName = "Seats";
            product.prodPrice = double.Parse("25000");
            product.Qty = int.Parse("10");
            clsInventory.Inventory.Add(product);

            product.prodId = "08";
            product.prodName = "Mirrors";
            product.prodPrice = double.Parse("2000");
            product.Qty = int.Parse("10");
            clsInventory.Inventory.Add(product);

            product.prodId = "09";
            product.prodName = "Transmission";
            product.prodPrice = double.Parse("35000");
            product.Qty = int.Parse("10");
            clsInventory.Inventory.Add(product);

            product.prodId = "10";
            product.prodName = "Engine Oil";
            product.prodPrice = double.Parse("2000");
            product.Qty = int.Parse("10");
            clsInventory.Inventory.Add(product);
            clsInventory.invDetailBool = true;
        }

        private void Main_menu_Load(object sender, EventArgs e)
        {
            if (clsInventory.invDetailBool == false)
            {
                AddToListView();
            }
        }
    }
}
