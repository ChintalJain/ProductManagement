using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagementService
{
    public class Product
    {
        private int productId;
        private string productName;
        private int productPrice;
        private int totalQuantity;
        private int quantityAtShop;
        private int quantityAtGodown;
        private string description;

        public Product()
        {

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
            set { this.quantityAtShop = value;}
        }

        public int QuantityAtGodown
        {
            get { return this.quantityAtGodown; }
            set { this.quantityAtGodown = value;}
        }
        public int TotalQuantity
        {
            get { return this.totalQuantity; }
            set { this.totalQuantity = value; }
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

    }
}
