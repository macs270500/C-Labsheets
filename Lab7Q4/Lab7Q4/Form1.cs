using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7Q4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            string product = lstProduct.Text;
            double total=0,UnitPrice=0, quantity = Double.Parse(txtQuantity.Text);
            switch (product)
            {
                case  "Zinger":
                    UnitPrice = 90;
                    break;
                case "Large Piece":
                    UnitPrice = 50;
                    break;
                case "Strips":
                    UnitPrice = 80;
                    break;
                case "Wedges":
                    UnitPrice = 75;
                    break;
            }
            quantity = Double.Parse(txtQuantity.Text);
            total = quantity * UnitPrice;
            txtUnitPrice.Text = UnitPrice.ToString();
            txtTotal.Text = total.ToString();




        }
    }
}
