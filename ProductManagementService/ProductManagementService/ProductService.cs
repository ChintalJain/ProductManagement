using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ProductManagementService
{
    public class ProductService : IProductService
    {
        public int AddProduct(Product product)
        {
            string q = "insert into Product_Details (ProductName,ProductPrice,QuantityAtShop,QuantityAtGodown,TotalQuantity,Description) output inserted.ProductId values (@PN,@PP,@QS,@QG,@TQ,@Des)";
            string cs= ConfigurationManager.ConnectionStrings["ProductManagement"].ConnectionString;
            SqlConnection conn = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand(q, conn);
            cmd.Parameters.AddWithValue("@PN", product.ProductName);
            cmd.Parameters.AddWithValue("@PP", product.ProductPrice);
            cmd.Parameters.AddWithValue("@QS", product.QuantityAtShop);
            cmd.Parameters.AddWithValue("@QG", product.QuantityAtGodown);
            cmd.Parameters.AddWithValue("@TQ", product.TotalQuantity);
            cmd.Parameters.AddWithValue("@Des", product.Description);
            conn.Open();
            int id = Convert.ToInt32(cmd.ExecuteScalar());
            conn.Close();
            if (id != 0)
            {
                return id;
            }
            return -1;
        }
        public List<Product> GetAllProduct()
        {
            List<Product> productList = new List<Product>();
            string q = "select * from Product_Details";

            string cs = ConfigurationManager.ConnectionStrings["ProductManagement"].ConnectionString;
            SqlConnection conn = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand(q, conn);
            conn.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Product p = new Product();
                p.ProductId = Convert.ToInt32(rdr["ProductId"]);
                p.ProductName = rdr["ProductName"].ToString();
                p.ProductPrice= Convert.ToInt32(rdr["ProductPrice"]);
                p.Description = rdr["Description"].ToString();
                p.QuantityAtShop= Convert.ToInt32(rdr["QuantityAtShop"]);
                p.QuantityAtGodown = Convert.ToInt32(rdr["QuantityAtGodown"]);
                p.TotalQuantity= Convert.ToInt32(rdr["TotalQuantity"]);
                productList.Add(p);
            }
            conn.Close();
            return productList;
        }

        public void UpdateProductDescription(int id, string des)
        {
            string cs = ConfigurationManager.ConnectionStrings["ProductManagement"].ConnectionString;
            SqlConnection conn = new SqlConnection(cs);
            string q1 = "update Product_Details set Description=@DES where ProductId=@PID";
            SqlCommand cmd = new SqlCommand(q1, conn);
            cmd.Parameters.AddWithValue("@DES", des);
            cmd.Parameters.AddWithValue("@PID", id);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void UpdateProductName(int id, string name)
        {
            string cs = ConfigurationManager.ConnectionStrings["ProductManagement"].ConnectionString;
            SqlConnection conn = new SqlConnection(cs);
            string q1 = "update Product_Details set ProductName=@PN where ProductId=@PID";
            SqlCommand cmd = new SqlCommand(q1, conn);
            cmd.Parameters.AddWithValue("@PN", name);
            cmd.Parameters.AddWithValue("@PID", id);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void UpdateProductPrice(int id, int price)
        {
            string cs = ConfigurationManager.ConnectionStrings["ProductManagement"].ConnectionString;
            SqlConnection conn = new SqlConnection(cs);
            string q1 = "update Product_Details set ProductPrice=@PP where ProductId=@PID";
            SqlCommand cmd = new SqlCommand(q1, conn);
            cmd.Parameters.AddWithValue("@PP", price);
            cmd.Parameters.AddWithValue("@PID", id);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void UpdateProductQuantityAtGodown(int id, int qag)
        {
            string cs = ConfigurationManager.ConnectionStrings["ProductManagement"].ConnectionString;
            SqlConnection conn = new SqlConnection(cs);
            string q1 = "update Product_Details set QuantityAtGodown=@QG where ProductId=@PID";
            SqlCommand cmd = new SqlCommand(q1, conn);
            cmd.Parameters.AddWithValue("@QG", qag);
            cmd.Parameters.AddWithValue("@PID", id);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void UpdateProductQuantityAtShop(int id, int qas)
        {
            string cs = ConfigurationManager.ConnectionStrings["ProductManagement"].ConnectionString;
            SqlConnection conn = new SqlConnection(cs);
            string q1 = "update Product_Details set QuantityAtShop=@QS where ProductId=@PID";
            SqlCommand cmd = new SqlCommand(q1, conn);
            cmd.Parameters.AddWithValue("@QS", qas);
            cmd.Parameters.AddWithValue("@PID", id);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void UpdateProductTotalQuantity(int id, int tq)
        {
            string cs = ConfigurationManager.ConnectionStrings["ProductManagement"].ConnectionString;
            SqlConnection conn = new SqlConnection(cs);
            string q1 = "update Product_Details set TotalQuantity=@TQ where ProductId=@PID";
            SqlCommand cmd = new SqlCommand(q1, conn);
            cmd.Parameters.AddWithValue("@TQ", tq);
            cmd.Parameters.AddWithValue("@PID", id);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public List<Product> GetProductOutOfStock()
        {
            List<Product> productList = new List<Product>();
            string q = "select * from Product_Details where QuantityAtShop=0 order by TotalQuantity";

            string cs = ConfigurationManager.ConnectionStrings["ProductManagement"].ConnectionString;
            SqlConnection conn = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand(q, conn);
            conn.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Product p = new Product();
                p.ProductId = Convert.ToInt32(rdr["ProductId"]);
                p.ProductName = rdr["ProductName"].ToString();
                p.ProductPrice = Convert.ToInt32(rdr["ProductPrice"]);
                p.Description = rdr["Description"].ToString();
                p.QuantityAtShop = Convert.ToInt32(rdr["QuantityAtShop"]);
                p.QuantityAtGodown = Convert.ToInt32(rdr["QuantityAtGodown"]);
                p.TotalQuantity = Convert.ToInt32(rdr["TotalQuantity"]);
                productList.Add(p);
            }
            conn.Close();
            return productList;
        }
        public List<Product> GetProductInStock()
        {
            List<Product> productList = new List<Product>();
            string q = "select * from Product_Details where QuantityAtShop>0" +
                "";

            string cs = ConfigurationManager.ConnectionStrings["ProductManagement"].ConnectionString;
            SqlConnection conn = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand(q, conn);
            conn.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Product p = new Product();
                p.ProductId = Convert.ToInt32(rdr["ProductId"]);
                p.ProductName = rdr["ProductName"].ToString();
                p.ProductPrice = Convert.ToInt32(rdr["ProductPrice"]);
                p.Description = rdr["Description"].ToString();
                p.QuantityAtShop = Convert.ToInt32(rdr["QuantityAtShop"]);
                p.QuantityAtGodown = Convert.ToInt32(rdr["QuantityAtGodown"]);
                p.TotalQuantity = Convert.ToInt32(rdr["TotalQuantity"]);
                productList.Add(p);
            }
            conn.Close();
            return productList;
        }
        public int AddBill(Bill bill)
        {
            string q = "insert into Bill_Details (BillDate,TotalProducts,TotalItems,TotalAmount,PaymentMethod) output inserted.BillId values (@BD,@TP,@TI,@TA,@PM)";
            string q1 = "insert into ProductInBill (BillId,ProductId,Quantity) values (@BI,@PI,@QTY)";
            string cs = ConfigurationManager.ConnectionStrings["ProductManagement"].ConnectionString;
            SqlConnection conn = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand(q, conn);
            cmd.Parameters.AddWithValue("@BD",bill.BillDate);
            cmd.Parameters.AddWithValue("@TP", bill.TotalProducts);
            cmd.Parameters.AddWithValue("@TI", bill.TotalItems);
            cmd.Parameters.AddWithValue("@TA", bill.TotalAmount);
            cmd.Parameters.AddWithValue("@PM", bill.PaymentMethod);
            conn.Open();
            int id = Convert.ToInt32(cmd.ExecuteScalar());
            conn.Close();
            cmd.Parameters.Clear();
            cmd.CommandText = q1;
            if (id != 0)
            {
                int i = 0;
                List<int> quantity = bill.Quantity;
                foreach(Product p in bill.Products)
                {
                    cmd.Parameters.AddWithValue("@BI", id);
                    cmd.Parameters.AddWithValue("@PI", p.ProductId);
                    cmd.Parameters.AddWithValue("@QTY", quantity[i]);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    UpdateProductQuantityAtShop(p.ProductId, p.QuantityAtShop - quantity[i]);
                    UpdateProductTotalQuantity(p.ProductId, p.TotalQuantity - quantity[i]);
                    i++;
                    cmd.Parameters.Clear();
                }
                return id;
            }

            return -1;
        }
        public List<ProductSales> GetLastWeekSales()
        {
            List<Bill> bills = new List<Bill>();
            string q = "select * from Bill_Details";
            string cs = ConfigurationManager.ConnectionStrings["ProductManagement"].ConnectionString;
            SqlConnection conn = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand(q, conn);
            conn.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Bill b = new Bill();
                b.BillDate = Convert.ToDateTime(rdr["BillDate"]);
                DateTime now = DateTime.Now;
                TimeSpan t = now.Subtract(b.BillDate);
                if (t.Days <= 7)
                {
                    b.BillId = Convert.ToInt32(rdr["BillId"]);
                    b.TotalAmount = Convert.ToInt32(rdr["TotalAmount"]);
                    b.TotalItems = Convert.ToInt32(rdr["TotalItems"]);
                    b.TotalProducts = Convert.ToInt32(rdr["TotalProducts"]);
                    b.PaymentMethod = rdr["PaymentMethod"].ToString();
                    bills.Add(b);
                }
            }
            conn.Close();

            List<ProductSales> productSalesList = new List<ProductSales>();
            q = "select * from ProductInBill";
            cmd = new SqlCommand(q, conn);
            conn.Open();
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                foreach (Bill bill in bills)
                {
                    if (Convert.ToInt32(rdr["BillId"]) == bill.BillId)
                    {
                        int flag = 0;
                        foreach (ProductSales ps in productSalesList)
                        {
                            if (ps.ProductId == Convert.ToInt32(rdr["ProductId"]))
                            {
                                flag = 1;
                                ps.QuantitySold += Convert.ToInt32(rdr["Quantity"]);
                                break;
                            }
                        }
                        if (flag == 0)
                        {
                            ProductSales s = new ProductSales();
                            s.ProductId = Convert.ToInt32(rdr["ProductId"]);
                            s.QuantitySold = Convert.ToInt32(rdr["Quantity"]);
                            productSalesList.Add(s);
                        }
                    }
                }
            }
            conn.Close();

            foreach (ProductSales ps in productSalesList)
            {
                q = "select ProductName from Product_Details where ProductId=" + ps.ProductId;
                cmd = new SqlCommand(q, conn);
                conn.Open();
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    ps.ProductName = rdr["ProductName"].ToString();
                }
                conn.Close();
            }

            List<ProductSales> l = productSalesList.OrderByDescending(x => x.QuantitySold).ToList();
            return l;
        }
        public List<ProductSales> GetLastMonthSales()
        {
            List<Bill> bills = new List<Bill>();
            string q = "select * from Bill_Details";
            string cs = ConfigurationManager.ConnectionStrings["ProductManagement"].ConnectionString;
            SqlConnection conn = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand(q, conn);
            conn.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Bill b = new Bill();
                b.BillDate = Convert.ToDateTime(rdr["BillDate"]);
                DateTime now = DateTime.Now;
                TimeSpan t = now.Subtract(b.BillDate);
                if (t.Days <= 30)
                {
                    b.BillId = Convert.ToInt32(rdr["BillId"]);
                    b.TotalAmount = Convert.ToInt32(rdr["TotalAmount"]);
                    b.TotalItems = Convert.ToInt32(rdr["TotalItems"]);
                    b.TotalProducts = Convert.ToInt32(rdr["TotalProducts"]);
                    b.PaymentMethod = rdr["PaymentMethod"].ToString();
                    bills.Add(b);
                }
            }
            conn.Close();

            List<ProductSales> productSalesList = new List<ProductSales>();
            q = "select * from ProductInBill";
            cmd = new SqlCommand(q, conn);
            conn.Open();
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                foreach (Bill bill in bills)
                {
                    if (Convert.ToInt32(rdr["BillId"]) == bill.BillId)
                    {
                        int flag = 0;
                        foreach (ProductSales ps in productSalesList)
                        {
                            if (ps.ProductId == Convert.ToInt32(rdr["ProductId"]))
                            {
                                flag = 1;
                                ps.QuantitySold += Convert.ToInt32(rdr["Quantity"]);
                                break;
                            }
                        }
                        if (flag == 0)
                        {
                            ProductSales s = new ProductSales();
                            s.ProductId = Convert.ToInt32(rdr["ProductId"]);
                            s.QuantitySold = Convert.ToInt32(rdr["Quantity"]);
                            productSalesList.Add(s);
                        }
                    }
                }
            }
            conn.Close();

            foreach (ProductSales ps in productSalesList)
            {
                q = "select ProductName from Product_Details where ProductId=" + ps.ProductId;
                cmd = new SqlCommand(q, conn);
                conn.Open();
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    ps.ProductName = rdr["ProductName"].ToString();
                }
                conn.Close();
            }

            List<ProductSales> l = productSalesList.OrderByDescending(x => x.QuantitySold).ToList();
            return l;

        }
        public List<ProductSales> GetLastYearSales()
        {
            List<Bill> bills = new List<Bill>();
            string q = "select * from Bill_Details";
            string cs = ConfigurationManager.ConnectionStrings["ProductManagement"].ConnectionString;
            SqlConnection conn = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand(q, conn);
            conn.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Bill b = new Bill();
                b.BillDate = Convert.ToDateTime(rdr["BillDate"]);
                DateTime now = DateTime.Now;
                TimeSpan t = now.Subtract(b.BillDate);
                if (t.Days <= 365)
                {
                    b.BillId = Convert.ToInt32(rdr["BillId"]);
                    b.TotalAmount = Convert.ToInt32(rdr["TotalAmount"]);
                    b.TotalItems = Convert.ToInt32(rdr["TotalItems"]);
                    b.TotalProducts = Convert.ToInt32(rdr["TotalProducts"]);
                    b.PaymentMethod = rdr["PaymentMethod"].ToString();
                    bills.Add(b);
                }
            }
            conn.Close();

            List<ProductSales> productSalesList = new List<ProductSales>();
            q = "select * from ProductInBill";
            cmd = new SqlCommand(q, conn);
            conn.Open();
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                foreach (Bill bill in bills)
                {
                    if (Convert.ToInt32(rdr["BillId"]) == bill.BillId)
                    {
                        int flag = 0;
                        foreach (ProductSales ps in productSalesList)
                        {
                            if (ps.ProductId == Convert.ToInt32(rdr["ProductId"]))
                            {
                                flag = 1;
                                ps.QuantitySold += Convert.ToInt32(rdr["Quantity"]);
                                break;
                            }
                        }
                        if (flag == 0)
                        {
                            ProductSales s = new ProductSales();
                            s.ProductId = Convert.ToInt32(rdr["ProductId"]);
                            s.QuantitySold = Convert.ToInt32(rdr["Quantity"]);
                            productSalesList.Add(s);
                        }
                    }
                }
            }
            conn.Close();

            foreach (ProductSales ps in productSalesList)
            {
                q = "select ProductName from Product_Details where ProductId=" + ps.ProductId;
                cmd = new SqlCommand(q, conn);
                conn.Open();
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    ps.ProductName = rdr["ProductName"].ToString();
                }
                conn.Close();
            }

            List<ProductSales> l = productSalesList.OrderByDescending(x => x.QuantitySold).ToList();
            return l;

        }

    }
}
