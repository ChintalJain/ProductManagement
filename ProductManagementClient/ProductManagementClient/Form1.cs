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
        public Form1()
        {
            InitializeComponent();
            mainPanel = new List<Panel>();
            productsPanel = new List<Panel>();

            mainPanel.Add(ProductsPanel);
            productsPanel.Add(AddProductPanel);
        }

        private void ProductsBtn_Click(object sender, EventArgs e)
        {
            this.mainPanel[0].BringToFront();
            this.AddProductPanel.BringToFront();
            AddProductLbl.Text = "";
            initAddProduct();
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
            initAddProduct();
        }
    }
}
