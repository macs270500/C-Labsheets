using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class clsInventory
    {
        public struct Product
        {
            public string prodId;
            public string prodName;
            public double prodPrice;
            public int Qty;
        }
        public static List<Product> Inventory = new List<Product>();
        public static bool invDetailBool=false;

        public int Price(string item)
        {
            int price = 0;
            switch (item)
            {
                case "Head Gasket":
                    price = 3000;
                    break;
                case "Headers":
                    price = 5000;
                    break;
                case "Engine Oil":
                    price = 2000;
                    break;
                case "Mass Air Flow Sensor":
                    price = 2000;
                    break;
                case "SuperChargers":
                    price = 3500;
                    break;
                case "TurboChargers":
                    price = 2000;
                    break;
                case "Transmission":
                    price = 35000;
                    break;
                case "Mirrors":
                    price = 1000;
                    break;
                case "Headlights":
                    price = 1500;
                    break;
                case "Seats":
                    price = 25000;
                    break;
                default:
                    price = 0;
                    break;
            }

            return price;
        }
    }
}
