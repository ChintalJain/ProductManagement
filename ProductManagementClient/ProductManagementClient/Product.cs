using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagementClient
{
    public class Product
    {
        private int productId;
        private string productName;
        private int productPrice;
        private int totalQuantity;
        private int quantityAtShop;
        private int quantityAtGodown;
        public string description;

        public Product()
        {
            this.ProductId = -1;
            this.quantityAtShop = 0;
            this.quantityAtGodown = 0;
        }

        public Product(string name, int price, int qAtShop, int qAtGodown, String des)
        {
            this.productId = -1;
            this.productName = name;
            this.productPrice = price;
            this.quantityAtShop = qAtShop;
            this.quantityAtGodown = qAtGodown;
            this.description = des;
            calculateTotalQuantity();
        }
        public Product(int id, string name, int price, int qAtShop, int qAtGodown, String des)
        {
            this.productId = id;
            this.productName = name;
            this.productPrice = price;
            this.quantityAtShop = qAtShop;
            this.quantityAtGodown = qAtGodown;
            this.description = des;
            calculateTotalQuantity();
        }
        public int ProductId
        {
            get { return this.productId; }
            set { this.productId = value; }
        }
        public string ProductName
        {
            get { return this.productName; }
            set { this.productName = value; }
        }

        public int QuantityAtShop
        {
            get { return this.quantityAtShop; }
            set { this.quantityAtShop = value; calculateTotalQuantity(); }
        }

        public int QuantityAtGodown
        {
            get { return this.quantityAtGodown; }
            set { this.quantityAtGodown = value; calculateTotalQuantity(); }
        }
        public int TotalQuantity
        {
            get { return this.totalQuantity; }
            set { this.totalQuantity=value; }
        }
        public string Description
        {
            get { return this.description; }
            set { this.description = value; }
        }
        public int ProductPrice
        {
            get { return this.productPrice; }
            set { this.productPrice = value; }
        }

        public void calculateTotalQuantity()
        {
            this.totalQuantity = this.quantityAtGodown + this.quantityAtShop;
        }
    }
}
