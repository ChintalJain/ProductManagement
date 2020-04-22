using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagementService
{
    public class Bill
    {
        private int billId;
        private DateTime billDate;
        private int totalProducts;
        private int totalItems;
        private int totalAmount;
        private string paymentMethod;
        private List<Product> products;
        private List<int> quantity;

        public Bill()
        {
            this.billId = -1;
            this.billDate = DateTime.Today;
            this.totalProducts = 0;
            this.totalItems = 0;
            this.totalAmount = 0;
            products = new List<Product>();
            quantity = new List<int>();
        }
        public int BillId
        {
            get { return this.billId; }
            set { this.billId = value; }
        }
        public DateTime BillDate
        {
            get { return this.billDate; }
            set { this.billDate = value; }
        }
        public int TotalProducts
        {
            get { return this.totalProducts; }
            set { this.totalProducts = value; }
        }
        public int TotalItems
        {
            get { return this.totalItems; }
            set { this.totalItems = value; }
        }
        public int TotalAmount
        {
            get { return this.totalAmount; }
            set { this.totalAmount = value; }
        }
        public List<Product> Products
        {
            get { return this.products; }
            set { this.products = value; }
        }
        public List<int> Quantity
        {
            get { return this.quantity; }
            set { this.quantity = value; }
        }
        public string PaymentMethod
        {
            get { return this.paymentMethod; }
            set { this.paymentMethod = value; }
        }

    }
}
