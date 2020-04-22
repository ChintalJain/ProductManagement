using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagementService
{
    public class ProductSales
    {
        private int productId;
        private string productName;
        private int quantitySold;

        public ProductSales()
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
        public int QuantitySold
        {
            get { return this.quantitySold; }
            set { this.quantitySold = value; }
        }


    }
}
