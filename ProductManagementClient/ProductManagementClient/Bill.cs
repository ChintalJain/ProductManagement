using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagementClient
{

    public class Bill
    {
        private int billId;
        private DateTime billDate;
        private int totalProducts;
        private int totalItems;
        private int totalAmount;
        private string paymentMethod;
        private List<ServiceReference1.Product> products;
        private List<int> quantity;

        public Bill()
        {
            this.billId = -1;
            this.billDate = DateTime.Today;
            this.totalProducts = 0;
            this.totalItems = 0;
            this.totalAmount = 0;
            products = new List<ServiceReference1.Product>();
            quantity = new List<int>();
        }
        public int BillId
        {
            get { return this.billId; }
            set { this.billId=value; }
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
        public string PaymentMethod
        {
            get { return this.paymentMethod; }
            set { this.paymentMethod = value; }
        }
        public List<ServiceReference1.Product> Products
        {
            get { return this.products; }
            set { this.products = value; }
        }
        public List<int> Quantity
        {
            get { return this.quantity; }
            set { this.quantity = value; }
        }

        public void calculateTotalAmount()
        {
            int i = 0, sum = 0;
            foreach (ServiceReference1.Product p in products)
            {
                sum += quantity[i] * p.ProductPrice;
                i++;
            }
            this.totalAmount = sum;
        }
        public void addProductToBill(ServiceReference1.Product p, int q)
        {
            products.Add(p);
            quantity.Add(q);
            totalProducts++;
            totalItems += q;
        }
        public ServiceReference1.Product removeProductFromBill(int index)
        {
            ServiceReference1.Product p = this.products[index];
            products.RemoveAt(index);
            totalProducts--;
            totalItems -= quantity[index];
            quantity.RemoveAt(index);
            return p;
        }
    }
}
