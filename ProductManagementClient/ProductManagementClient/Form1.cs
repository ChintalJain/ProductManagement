using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductManagementClient
{
    public partial class Form1 : Form
    {
        List<Panel> productsPanel;
        List<Panel> mainPanel;
        List<Panel> billsPanel;
        List<ServiceReference1.Product> products;
        Bill bill;
        public Form1()
        {
            InitializeComponent();
            mainPanel = new List<Panel>();
            productsPanel = new List<Panel>();
            billsPanel = new List<Panel>();

            mainPanel.Add(ProductsPanel);
            mainPanel.Add(BillPanel);
            productsPanel.Add(AddProductPanel);
            productsPanel.Add(ViewProductsPanel);
            productsPanel.Add(QuantityPanel);
            productsPanel.Add(UpdateProductPanel);
            productsPanel.Add(ProductOutOfStockPanel);
            billsPanel.Add(PlaceOrderPanel);
            billsPanel.Add(LastWeekSalesPanel);
            billsPanel.Add(LastMonthSalesPanel);
            billsPanel.Add(LastYearSalesPanel);
        }

        private void ProductsBtn_Click(object sender, EventArgs e)
        {
            this.mainPanel[0].BringToFront();
            this.productsPanel[0].BringToFront();
            AddProductLbl.Text = "";
            initAddProduct();
        }
        private void AddProductBtn_Click(object sender, EventArgs e)
        {
            this.productsPanel[0].BringToFront();
            initAddProduct();
            AddProductLbl.Text = "";

        }
        private void initAddProduct()
        {
            ProductNameTB.Text = "";
            ProductPriceTB.Text = "";
            QuantityAtShopTB.Text = "0";
            QuantityAtGodownTB.Text = "0";
            DescriptionTB.Text = "";
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            initAddProduct();
            AddProductLbl.Text = "";
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (ProductNameTB.Text == "")
            {
                MessageBox.Show("Please enter product name.");
            }
            else if (ProductPriceTB.Text == "")
            {
                MessageBox.Show("Please enter product price.");
            }
            else if (QuantityAtShopTB.Text == "")
            {
                MessageBox.Show("Please enter product quantity at shop.");
            }
            else if (QuantityAtGodownTB.Text == "")
            {
                MessageBox.Show("Please enter product quantity at godown.");
            }
            else
            {
                Product p = new Product(ProductNameTB.Text, Convert.ToInt32(ProductPriceTB.Text), Convert.ToInt32(QuantityAtShopTB.Text), Convert.ToInt32(QuantityAtGodownTB.Text), DescriptionTB.Text);
                ServiceReference1.Product ps = new ServiceReference1.Product();
                ps.ProductId = p.ProductId;
                ps.ProductName = p.ProductName;
                ps.ProductPrice = p.ProductPrice;
                ps.TotalQuantity = p.TotalQuantity;
                ps.QuantityAtShop = p.QuantityAtShop;
                ps.QuantityAtGodown = p.QuantityAtGodown;
                ps.Description = p.Description;
                ServiceReference1.ProductServiceClient client = new ServiceReference1.ProductServiceClient();
                int id = client.AddProduct(ps);
                if (id == -1)
                {
                    AddProductLbl.Text = "Error adding product.";
                }
                else
                {
                    AddProductLbl.Text = "Product added successfully with id " + id;
                }
            }

            initAddProduct();
        }

        private void ViewProducsBtn_Click(object sender, EventArgs e)
        {
            this.productsPanel[1].BringToFront();
            var source = new BindingSource();
            ServiceReference1.ProductServiceClient client = new ServiceReference1.ProductServiceClient();
            List<ServiceReference1.Product> pList = new List<ServiceReference1.Product>(client.GetAllProduct());
            source.DataSource = pList;
            dataGridView1.DataSource = source;
            dataGridView1.Columns["ProductId"].DisplayIndex = 0;
            dataGridView1.Columns["ProductName"].DisplayIndex = 1;
            dataGridView1.Columns["ProductPrice"].DisplayIndex = 2;
            dataGridView1.Columns["TotalQuantity"].DisplayIndex = 3;
            dataGridView1.Columns["QuantityAtShop"].DisplayIndex = 4;
            dataGridView1.Columns["QuantityAtGodown"].DisplayIndex = 5;
            dataGridView1.Columns["Description"].DisplayIndex = 6;
        }

        private void setGridView2()
        {
            var source = new BindingSource();
            source.DataSource = products;
            dataGridView2.DataSource = source;
            dataGridView2.Columns["ProductId"].DisplayIndex = 0;
            dataGridView2.Columns["ProductName"].DisplayIndex = 1;
            dataGridView2.Columns["ProductPrice"].Visible=false;
            dataGridView2.Columns["TotalQuantity"].DisplayIndex = 2;
            dataGridView2.Columns["QuantityAtShop"].DisplayIndex = 3;
            dataGridView2.Columns["QuantityAtGodown"].DisplayIndex = 4;
            dataGridView2.Columns["Description"].Visible = false;
        }
        private void QuantityBtn_Click(object sender, EventArgs e)
        {
            this.productsPanel[2].BringToFront();
            ServiceReference1.ProductServiceClient client = new ServiceReference1.ProductServiceClient();
            products = new List<ServiceReference1.Product>(client.GetAllProduct());
            setGridView2();
        }

        private void AddQuantityAtShopBtn_Click(object sender, EventArgs e)
        {
            int id = dataGridView2.SelectedRows.Count;
            if(id==0)
            {
                MessageBox.Show("Please Select Product.");
                return;
            }
            if(QuantityTB.Text=="")
            {
                MessageBox.Show("Please Enter Quantity.");
                return;
            }
            ServiceReference1.Product p = products[dataGridView2.SelectedRows[0].Index];
            p.QuantityAtShop += Convert.ToInt32(QuantityTB.Text);
            p.TotalQuantity += Convert.ToInt32(QuantityTB.Text);
            ServiceReference1.ProductServiceClient client = new ServiceReference1.ProductServiceClient();
            client.UpdateProductQuantityAtShop(p.ProductId, p.QuantityAtShop);
            client.UpdateProductTotalQuantity(p.ProductId, p.TotalQuantity);
            QuantityTB.Text = "";
        }

        private void AddQuantityAtGodown_Click(object sender, EventArgs e)
        {
            int id = dataGridView2.SelectedRows.Count;
            if (id == 0)
            {
                MessageBox.Show("Please Select Product.");
                return;
            }
            if (QuantityTB.Text == "")
            {
                MessageBox.Show("Please Enter Quantity.");
                return;
            }
            ServiceReference1.Product p = products[dataGridView2.SelectedRows[0].Index];
            p.QuantityAtGodown += Convert.ToInt32(QuantityTB.Text);
            p.TotalQuantity += Convert.ToInt32(QuantityTB.Text);
            ServiceReference1.ProductServiceClient client = new ServiceReference1.ProductServiceClient();
            client.UpdateProductQuantityAtGodown(p.ProductId, p.QuantityAtGodown);
            client.UpdateProductTotalQuantity(p.ProductId, p.TotalQuantity);
            QuantityTB.Text = "";
        }

        private void TransferFromGodownTOSHopBtn_Click(object sender, EventArgs e)
        {
            int id = dataGridView2.SelectedRows.Count;
            if (id == 0)
            {
                MessageBox.Show("Please Select Product.");
                return;
            }
            if (QuantityTB.Text == "")
            {
                MessageBox.Show("Please Enter Quantity.");
                return;
            }
            ServiceReference1.Product p = products[dataGridView2.SelectedRows[0].Index];
            p.QuantityAtShop += Convert.ToInt32(QuantityTB.Text);
            p.QuantityAtGodown -= Convert.ToInt32(QuantityTB.Text);
            ServiceReference1.ProductServiceClient client = new ServiceReference1.ProductServiceClient();
            client.UpdateProductQuantityAtShop(p.ProductId, p.QuantityAtShop);
            client.UpdateProductQuantityAtGodown(p.ProductId, p.QuantityAtGodown);
            QuantityTB.Text = "";
        }
        private void setGridView3()
        {
            var source = new BindingSource();
            source.DataSource = products;
            dataGridView3.DataSource = source;
            dataGridView3.Columns["ProductId"].DisplayIndex = 0;
            dataGridView3.Columns["ProductName"].DisplayIndex = 1;
            dataGridView3.Columns["ProductPrice"].DisplayIndex = 2;
            dataGridView3.Columns["TotalQuantity"].DisplayIndex = 3;
            dataGridView3.Columns["QuantityAtShop"].DisplayIndex = 4;
            dataGridView3.Columns["QuantityAtGodown"].DisplayIndex = 5;
            dataGridView3.Columns["Description"].DisplayIndex = 6;
        }

        private void UpdateProductBtn_Click(object sender, EventArgs e)
        {
            this.productsPanel[3].BringToFront();
            ServiceReference1.ProductServiceClient client = new ServiceReference1.ProductServiceClient();
            products = new List<ServiceReference1.Product>(client.GetAllProduct());
            setGridView3();
        }

        private void ProductParameters_SelectedIndexChanged(object sender, EventArgs e)
        {
            int count = dataGridView3.SelectedRows.Count;
            if(count==0)
            {
                MessageBox.Show("Please Select Product.");
                ProductParameters.SelectedIndex = -1;
                return;
            }
            ServiceReference1.Product p = products[dataGridView3.SelectedRows[0].Index];
            int id = ProductParameters.SelectedIndex;
            if (id == 4)
            {
                UpdateValueTB.Multiline = true;
            }
            else
            {
                UpdateValueTB.Multiline = false;
            }
            if (id==0)
            {
                UpdateValueTB.Text = p.ProductName;
            }
            else if(id == 1)
            {
                UpdateValueTB.Text = p.ProductPrice.ToString();
            }
            else if (id == 2)
            {
                UpdateValueTB.Text = p.QuantityAtShop.ToString();
            }
            else if (id == 3)
            {
                UpdateValueTB.Text = p.QuantityAtGodown.ToString();
            }
            else if (id == 4)
            {
                UpdateValueTB.Text = p.Description;
            }
        }

        private void dataGridView3_SelectionChanged(object sender, EventArgs e)
        {
            ProductParameters.SelectedIndex = -1;
            UpdateValueTB.Text = "";
        }

        private void UpdateValueBtn_Click(object sender, EventArgs e)
        {
            int count = dataGridView3.SelectedRows.Count;
            if (count == 0)
            {
                MessageBox.Show("Please Select Product.");
                ProductParameters.SelectedIndex = -1;
                return;
            }
            ServiceReference1.Product p = products[dataGridView3.SelectedRows[0].Index];
            int id = ProductParameters.SelectedIndex;
            if(id==-1)
            {
                MessageBox.Show("Please Select Product Parameter.");
                ProductParameters.SelectedIndex = -1;
                return;
            }
            ServiceReference1.ProductServiceClient client = new ServiceReference1.ProductServiceClient();
            if (id == 0)
            {
                if(UpdateValueTB.Text != p.ProductName)
                {
                    p.ProductName = UpdateValueTB.Text;
                    client.UpdateProductName(p.ProductId, p.ProductName);
                }
            }
            else if (id == 1)
            {
                if (Convert.ToInt32(UpdateValueTB.Text) != p.ProductPrice)
                {
                    p.ProductPrice = Convert.ToInt32(UpdateValueTB.Text);
                    client.UpdateProductPrice(p.ProductId, p.ProductPrice);
                }
            }
            else if (id == 2)
            {
                if (Convert.ToInt32(UpdateValueTB.Text) != p.QuantityAtShop)
                {
                    p.TotalQuantity -= p.QuantityAtShop;
                    p.QuantityAtShop = Convert.ToInt32(UpdateValueTB.Text);
                    p.TotalQuantity += p.QuantityAtShop;
                    client.UpdateProductQuantityAtShop(p.ProductId, p.QuantityAtShop);
                    client.UpdateProductTotalQuantity(p.ProductId, p.TotalQuantity);
                }
            }
            else if (id == 3)
            {
                if (Convert.ToInt32(UpdateValueTB.Text) != p.QuantityAtGodown)
                {
                    p.TotalQuantity -= p.QuantityAtGodown;
                    p.QuantityAtGodown = Convert.ToInt32(UpdateValueTB.Text);
                    p.TotalQuantity += p.QuantityAtGodown;
                    client.UpdateProductQuantityAtGodown(p.ProductId, p.QuantityAtGodown);
                    client.UpdateProductTotalQuantity(p.ProductId, p.TotalQuantity);
                }
            }
            else if (id == 4)
            {
                if (UpdateValueTB.Text != p.Description)
                {
                    p.Description = UpdateValueTB.Text;
                    client.UpdateProductDescription(p.ProductId, p.Description);
                }
            }
        }
        private void setGridView4()
        {
            var source = new BindingSource();
            source.DataSource = products;
            dataGridView4.DataSource = source;
            dataGridView4.Columns["ProductId"].DisplayIndex = 0;
            dataGridView4.Columns["ProductName"].DisplayIndex = 1;
            dataGridView4.Columns["ProductPrice"].Visible = false;
            dataGridView4.Columns["TotalQuantity"].DisplayIndex = 2;
            dataGridView4.Columns["QuantityAtShop"].DisplayIndex = 3;
            dataGridView4.Columns["QuantityAtGodown"].DisplayIndex = 4;
            dataGridView4.Columns["Description"].Visible = false;
        }

        private void ProductOutOfStockBtn_Click(object sender, EventArgs e)
        {
            this.productsPanel[4].BringToFront();
            ServiceReference1.ProductServiceClient client = new ServiceReference1.ProductServiceClient();
            products = new List<ServiceReference1.Product>(client.GetProductOutOfStock());
            setGridView4();
        }

        private void BillsBtn_Click(object sender, EventArgs e)
        {
            this.mainPanel[1].BringToFront();
            this.billsPanel[0].BringToFront();
        }

        private void initOrderDetails()
        {
            QuantityInOrderTB.Text = "1";
            ProductInStockLB.Items.Clear();
            ProductInOrderLB.Items.Clear();
            TotalProductsTB.Text = "";
            TotalItemsTB.Text = "";
            TotalAmountTB.Text = "";
            ServiceReference1.ProductServiceClient client = new ServiceReference1.ProductServiceClient();
            products = new List<ServiceReference1.Product>(client.GetProductInStock());
            foreach (ServiceReference1.Product p in products)
            {
                ProductInStockLB.Items.Add("Id :- " + p.ProductId + " Name :- " + p.ProductName);
            }
            PaymentMethodLB.SelectedIndex = -1;
            bill = new Bill();
        }
        private void PlaceOrderBtn_Click(object sender, EventArgs e)
        {
            this.billsPanel[0].BringToFront();
            initOrderDetails();
            OrderIDLbl.Text = "";
        }

        private void AddToOrderBtn_Click(object sender, EventArgs e)
        {
            int id = ProductInStockLB.SelectedIndex;
            if(id==-1)
            {
                MessageBox.Show("Please Select Product From Product In Stock.");
                return;
            }
            ServiceReference1.Product p = products[id];
            int qty = Convert.ToInt32(QuantityInOrderTB.Text);
            if(p.QuantityAtShop<qty)
            {
                MessageBox.Show("Product is available in only "+p.QuantityAtShop+" Quantity in shop.");
                return;
            }
            this.bill.addProductToBill(p, qty);
            ProductInOrderLB.Items.Add("Id :- "+p.ProductId+" Name :- "+p.ProductName+" Price :- "+p.ProductPrice+" Total Amount :-"+p.ProductPrice*qty);
            ProductInStockLB.Items.RemoveAt(id);
            products.RemoveAt(id);
        }

        private void RemoveFromOrderTB_Click(object sender, EventArgs e)
        {
            int id = ProductInOrderLB.SelectedIndex;
            if(id==-1)
            {
                MessageBox.Show("Please Select Product From Product In Order.");
                return;
            }
            ServiceReference1.Product p = this.bill.removeProductFromBill(id);
            ProductInOrderLB.Items.RemoveAt(id);
            ProductInStockLB.Items.Add("Id :- " + p.ProductId + " Name :- " + p.ProductName);
            this.products.Add(p);
        }

        private void GenerateBillBtn_Click(object sender, EventArgs e)
        {
            int count = ProductInOrderLB.Items.Count;
            if(count==0)
            {
                MessageBox.Show("Please Add Product To Order.");
                return;
            }
            this.bill.calculateTotalAmount();
            TotalProductsTB.Text = bill.TotalProducts.ToString();
            TotalItemsTB.Text = bill.TotalItems.ToString();
            TotalAmountTB.Text = bill.TotalAmount.ToString();
        }

        private void ConfirmOrderBtn_Click(object sender, EventArgs e)
        {
            int id=PaymentMethodLB.SelectedIndex;
            int count = ProductInOrderLB.Items.Count;
            if (count == 0)
            {
                MessageBox.Show("Please Add Product To Order.");
                return;
            }
            this.bill.calculateTotalAmount();
            TotalProductsTB.Text = bill.TotalProducts.ToString();
            TotalItemsTB.Text = bill.TotalItems.ToString();
            TotalAmountTB.Text = bill.TotalAmount.ToString();
            if (id==-1)
            {
                MessageBox.Show("Please Select Payment Method.");
                return;
            }
            bill.PaymentMethod = PaymentMethodLB.SelectedItem.ToString();
            ServiceReference1.Bill b = new ServiceReference1.Bill();
            b.BillId = bill.BillId;
            b.BillDate = bill.BillDate;
            b.TotalProducts = bill.TotalProducts;
            b.TotalItems = bill.TotalItems;
            b.TotalAmount = bill.TotalAmount;
            b.PaymentMethod = bill.PaymentMethod;
            b.Products = bill.Products.ToArray();
            b.Quantity = bill.Quantity.ToArray();
            ServiceReference1.ProductServiceClient client = new ServiceReference1.ProductServiceClient();
            int billId = client.AddBill(b);
            if(billId==-1)
            {
                OrderIDLbl.Text = "Error in adding to database.";
                return;
            }
            OrderIDLbl.Text = "Bill added with id :- "+billId;
            initOrderDetails();
            return;
        }

        private void LastWeekSalesBtn_Click(object sender, EventArgs e)
        {
            this.billsPanel[1].BringToFront();
            var source = new BindingSource();
            ServiceReference1.ProductServiceClient client = new ServiceReference1.ProductServiceClient();
            source.DataSource = client.GetLastWeekSales();
            dataGridView5.DataSource = source;
        }

        private void LastMonthSalesBtn_Click(object sender, EventArgs e)
        {
            this.billsPanel[2].BringToFront();
            var source = new BindingSource();
            ServiceReference1.ProductServiceClient client = new ServiceReference1.ProductServiceClient();
            source.DataSource = client.GetLastMonthSales();
            dataGridView6.DataSource = source;
        }

        private void LastYearSalesBtn_Click(object sender, EventArgs e)
        {
            this.billsPanel[3].BringToFront();
            var source = new BindingSource();
            ServiceReference1.ProductServiceClient client = new ServiceReference1.ProductServiceClient();
            source.DataSource = client.GetLastYearSales(); ;
            dataGridView7.DataSource = source;
        }
    }
}
