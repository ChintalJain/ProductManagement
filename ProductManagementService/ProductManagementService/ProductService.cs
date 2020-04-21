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
            string q = "select * from Product_Details where TotalQuantity=0 or QuantityAtShop=0 order by TotalQuantity";

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

    }
}
