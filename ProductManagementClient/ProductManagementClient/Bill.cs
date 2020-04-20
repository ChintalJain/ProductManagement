using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagementClient
{

    public class Bill
    {
        private int billId { get; set; }
        private DateTime billDate { get; set; }
        private int totalAmount;
        private int discount;
        private int netAmount;
        private string paymentMode;
        private Order order;
        public Bill()
        {
            this.billDate = DateTime.Today;
        }
        public Bill(Order o)
        {
            this.billDate = DateTime.Today;
            this.order = o;
            calculateTotalAmount();
        }

        public int TotalAmount
        {
            get { return this.totalAmount; }
        }
        public int NetAmount
        {
            get { return this.netAmount; }
            set { this.netAmount = value; }
        }
        public string PaymentMode
        {
            get { return this.paymentMode; }
            set { this.paymentMode = value; }
        }
        public Order SetOrder
        {
            set { this.order = value; this.calculateTotalAmount(); }
        }
        private void calculateTotalAmount()
        {
            List<Product> pList = this.order.Products;
            List<int> qList = this.order.Quantity;
            int i = 0, sum = 0;
            foreach (Product p in pList)
            {
                sum += qList[i] * p.ProductPrice;
                i++;
            }
            this.totalAmount = sum;
            this.netAmount = sum;
        }
    }
}
