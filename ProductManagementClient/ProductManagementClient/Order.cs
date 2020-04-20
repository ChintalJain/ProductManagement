using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagementClient
{
    public class Order
    {
        private int orderId;
        private int totalProduct { get; set; }
        private int totalItem { get; set; }
        private DateTime orderDate { get; set; }
        private List<Product> products;
        private List<int> quantity;
        public int OrderId
        {
            get { return this.orderId; }
        }
        public List<Product> Products
        {
            get { return this.products; }
        }
        public List<int> Quantity
        {
            get { return this.quantity; }
        }

        public Order()
        {
            this.orderDate = DateTime.Today;
            products = new List<Product>();
            quantity = new List<int>();
        }
        
        public void addProductToOrder(Product p, int q)
        {
            products.Add(p);
            quantity.Add(q);
            totalProduct++;
            totalItem += q;
        }
        public void removeProductFromOrder(Product p)
        {
            int i = 0;
            foreach (Product p1 in this.products)
            {
                if (p1.ProductId == p.ProductId)
                {
                    break;
                }
                i++;
            }
            products.RemoveAt(i);
            totalProduct--;
            totalItem -= quantity[i];
            quantity.RemoveAt(i);
        }
    }
}
