namespace ProductManagementClient
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ProductsPanel = new System.Windows.Forms.Panel();
            this.AddProductPanel = new System.Windows.Forms.Panel();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.AddProductLbl = new System.Windows.Forms.Label();
            this.DescriptionTB = new System.Windows.Forms.TextBox();
            this.QuantityAtGodownTB = new System.Windows.Forms.TextBox();
            this.QuantityAtShopTB = new System.Windows.Forms.TextBox();
            this.ProductPriceTB = new System.Windows.Forms.TextBox();
            this.ProductNameTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.UpdateProductBtn = new System.Windows.Forms.Button();
            this.QuantityBtn = new System.Windows.Forms.Button();
            this.ViewProducsBtn = new System.Windows.Forms.Button();
            this.AddProductBtn = new System.Windows.Forms.Button();
            this.ProductsBtn = new System.Windows.Forms.Button();
            this.ViewProductsPanel = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.QuantityPanel = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.QuantityTB = new System.Windows.Forms.TextBox();
            this.AddQuantityAtShopBtn = new System.Windows.Forms.Button();
            this.AddQuantityAtGodown = new System.Windows.Forms.Button();
            this.TransferFromGodownTOSHopBtn = new System.Windows.Forms.Button();
            this.UpdateProductPanel = new System.Windows.Forms.Panel();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.ProductParameters = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.UpdateValueTB = new System.Windows.Forms.TextBox();
            this.UpdateValueBtn = new System.Windows.Forms.Button();
            this.ProductOutOfStockBtn = new System.Windows.Forms.Button();
            this.ProductOutOfStockPanel = new System.Windows.Forms.Panel();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.ProductsPanel.SuspendLayout();
            this.AddProductPanel.SuspendLayout();
            this.ViewProductsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.QuantityPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.UpdateProductPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.ProductOutOfStockPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductsPanel
            // 
            this.ProductsPanel.Controls.Add(this.ProductOutOfStockPanel);
            this.ProductsPanel.Controls.Add(this.ProductOutOfStockBtn);
            this.ProductsPanel.Controls.Add(this.UpdateProductPanel);
            this.ProductsPanel.Controls.Add(this.QuantityPanel);
            this.ProductsPanel.Controls.Add(this.ViewProductsPanel);
            this.ProductsPanel.Controls.Add(this.AddProductPanel);
            this.ProductsPanel.Controls.Add(this.UpdateProductBtn);
            this.ProductsPanel.Controls.Add(this.QuantityBtn);
            this.ProductsPanel.Controls.Add(this.ViewProducsBtn);
            this.ProductsPanel.Controls.Add(this.AddProductBtn);
            this.ProductsPanel.Location = new System.Drawing.Point(31, 85);
            this.ProductsPanel.Name = "ProductsPanel";
            this.ProductsPanel.Size = new System.Drawing.Size(1639, 726);
            this.ProductsPanel.TabIndex = 0;
            // 
            // AddProductPanel
            // 
            this.AddProductPanel.Controls.Add(this.CancelBtn);
            this.AddProductPanel.Controls.Add(this.AddBtn);
            this.AddProductPanel.Controls.Add(this.AddProductLbl);
            this.AddProductPanel.Controls.Add(this.DescriptionTB);
            this.AddProductPanel.Controls.Add(this.QuantityAtGodownTB);
            this.AddProductPanel.Controls.Add(this.QuantityAtShopTB);
            this.AddProductPanel.Controls.Add(this.ProductPriceTB);
            this.AddProductPanel.Controls.Add(this.ProductNameTB);
            this.AddProductPanel.Controls.Add(this.label5);
            this.AddProductPanel.Controls.Add(this.label4);
            this.AddProductPanel.Controls.Add(this.label3);
            this.AddProductPanel.Controls.Add(this.label2);
            this.AddProductPanel.Controls.Add(this.label1);
            this.AddProductPanel.Location = new System.Drawing.Point(40, 97);
            this.AddProductPanel.Name = "AddProductPanel";
            this.AddProductPanel.Size = new System.Drawing.Size(1394, 587);
            this.AddProductPanel.TabIndex = 4;
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(301, 370);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(179, 46);
            this.CancelBtn.TabIndex = 12;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(47, 370);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(190, 46);
            this.AddBtn.TabIndex = 11;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // AddProductLbl
            // 
            this.AddProductLbl.AutoSize = true;
            this.AddProductLbl.Location = new System.Drawing.Point(58, 325);
            this.AddProductLbl.Name = "AddProductLbl";
            this.AddProductLbl.Size = new System.Drawing.Size(0, 20);
            this.AddProductLbl.TabIndex = 10;
            // 
            // DescriptionTB
            // 
            this.DescriptionTB.Location = new System.Drawing.Point(224, 220);
            this.DescriptionTB.Multiline = true;
            this.DescriptionTB.Name = "DescriptionTB";
            this.DescriptionTB.Size = new System.Drawing.Size(234, 75);
            this.DescriptionTB.TabIndex = 9;
            // 
            // QuantityAtGodownTB
            // 
            this.QuantityAtGodownTB.Location = new System.Drawing.Point(224, 168);
            this.QuantityAtGodownTB.Name = "QuantityAtGodownTB";
            this.QuantityAtGodownTB.Size = new System.Drawing.Size(234, 26);
            this.QuantityAtGodownTB.TabIndex = 8;
            // 
            // QuantityAtShopTB
            // 
            this.QuantityAtShopTB.Location = new System.Drawing.Point(224, 120);
            this.QuantityAtShopTB.Name = "QuantityAtShopTB";
            this.QuantityAtShopTB.Size = new System.Drawing.Size(234, 26);
            this.QuantityAtShopTB.TabIndex = 7;
            // 
            // ProductPriceTB
            // 
            this.ProductPriceTB.Location = new System.Drawing.Point(224, 70);
            this.ProductPriceTB.Name = "ProductPriceTB";
            this.ProductPriceTB.Size = new System.Drawing.Size(234, 26);
            this.ProductPriceTB.TabIndex = 6;
            // 
            // ProductNameTB
            // 
            this.ProductNameTB.Location = new System.Drawing.Point(224, 20);
            this.ProductNameTB.Name = "ProductNameTB";
            this.ProductNameTB.Size = new System.Drawing.Size(234, 26);
            this.ProductNameTB.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Description :-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Quantity At Godown :-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quantity At Shop :-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Product Price :-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product Name :-";
            // 
            // UpdateProductBtn
            // 
            this.UpdateProductBtn.Location = new System.Drawing.Point(749, 23);
            this.UpdateProductBtn.Name = "UpdateProductBtn";
            this.UpdateProductBtn.Size = new System.Drawing.Size(230, 45);
            this.UpdateProductBtn.TabIndex = 3;
            this.UpdateProductBtn.Text = "Update Product";
            this.UpdateProductBtn.UseVisualStyleBackColor = true;
            this.UpdateProductBtn.Click += new System.EventHandler(this.UpdateProductBtn_Click);
            // 
            // QuantityBtn
            // 
            this.QuantityBtn.Location = new System.Drawing.Point(516, 23);
            this.QuantityBtn.Name = "QuantityBtn";
            this.QuantityBtn.Size = new System.Drawing.Size(183, 45);
            this.QuantityBtn.TabIndex = 2;
            this.QuantityBtn.Text = "Quantity";
            this.QuantityBtn.UseVisualStyleBackColor = true;
            this.QuantityBtn.Click += new System.EventHandler(this.QuantityBtn_Click);
            // 
            // ViewProducsBtn
            // 
            this.ViewProducsBtn.Location = new System.Drawing.Point(294, 23);
            this.ViewProducsBtn.Name = "ViewProducsBtn";
            this.ViewProducsBtn.Size = new System.Drawing.Size(172, 45);
            this.ViewProducsBtn.TabIndex = 1;
            this.ViewProducsBtn.Text = "View Products";
            this.ViewProducsBtn.UseVisualStyleBackColor = true;
            this.ViewProducsBtn.Click += new System.EventHandler(this.ViewProducsBtn_Click);
            // 
            // AddProductBtn
            // 
            this.AddProductBtn.Location = new System.Drawing.Point(40, 23);
            this.AddProductBtn.Name = "AddProductBtn";
            this.AddProductBtn.Size = new System.Drawing.Size(203, 45);
            this.AddProductBtn.TabIndex = 0;
            this.AddProductBtn.Text = "Add Product";
            this.AddProductBtn.UseVisualStyleBackColor = true;
            this.AddProductBtn.Click += new System.EventHandler(this.AddProductBtn_Click);
            // 
            // ProductsBtn
            // 
            this.ProductsBtn.Location = new System.Drawing.Point(31, 21);
            this.ProductsBtn.Name = "ProductsBtn";
            this.ProductsBtn.Size = new System.Drawing.Size(170, 46);
            this.ProductsBtn.TabIndex = 0;
            this.ProductsBtn.Text = "Products";
            this.ProductsBtn.UseVisualStyleBackColor = true;
            this.ProductsBtn.Click += new System.EventHandler(this.ProductsBtn_Click);
            // 
            // ViewProductsPanel
            // 
            this.ViewProductsPanel.Controls.Add(this.dataGridView1);
            this.ViewProductsPanel.Location = new System.Drawing.Point(40, 97);
            this.ViewProductsPanel.Name = "ViewProductsPanel";
            this.ViewProductsPanel.Size = new System.Drawing.Size(1394, 587);
            this.ViewProductsPanel.TabIndex = 13;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(30, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1259, 514);
            this.dataGridView1.TabIndex = 0;
            // 
            // QuantityPanel
            // 
            this.QuantityPanel.Controls.Add(this.TransferFromGodownTOSHopBtn);
            this.QuantityPanel.Controls.Add(this.AddQuantityAtGodown);
            this.QuantityPanel.Controls.Add(this.AddQuantityAtShopBtn);
            this.QuantityPanel.Controls.Add(this.QuantityTB);
            this.QuantityPanel.Controls.Add(this.label6);
            this.QuantityPanel.Controls.Add(this.dataGridView2);
            this.QuantityPanel.Location = new System.Drawing.Point(40, 97);
            this.QuantityPanel.Name = "QuantityPanel";
            this.QuantityPanel.Size = new System.Drawing.Size(1394, 587);
            this.QuantityPanel.TabIndex = 1;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(34, 26);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(1016, 284);
            this.dataGridView2.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 331);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Quantity :-";
            // 
            // QuantityTB
            // 
            this.QuantityTB.Location = new System.Drawing.Point(140, 325);
            this.QuantityTB.Name = "QuantityTB";
            this.QuantityTB.Size = new System.Drawing.Size(179, 26);
            this.QuantityTB.TabIndex = 2;
            // 
            // AddQuantityAtShopBtn
            // 
            this.AddQuantityAtShopBtn.Location = new System.Drawing.Point(50, 417);
            this.AddQuantityAtShopBtn.Name = "AddQuantityAtShopBtn";
            this.AddQuantityAtShopBtn.Size = new System.Drawing.Size(190, 52);
            this.AddQuantityAtShopBtn.TabIndex = 3;
            this.AddQuantityAtShopBtn.Text = "Add Quantity At Shop";
            this.AddQuantityAtShopBtn.UseVisualStyleBackColor = true;
            this.AddQuantityAtShopBtn.Click += new System.EventHandler(this.AddQuantityAtShopBtn_Click);
            // 
            // AddQuantityAtGodown
            // 
            this.AddQuantityAtGodown.Location = new System.Drawing.Point(333, 417);
            this.AddQuantityAtGodown.Name = "AddQuantityAtGodown";
            this.AddQuantityAtGodown.Size = new System.Drawing.Size(229, 52);
            this.AddQuantityAtGodown.TabIndex = 4;
            this.AddQuantityAtGodown.Text = "Add Quantity At Godown";
            this.AddQuantityAtGodown.UseVisualStyleBackColor = true;
            this.AddQuantityAtGodown.Click += new System.EventHandler(this.AddQuantityAtGodown_Click);
            // 
            // TransferFromGodownTOSHopBtn
            // 
            this.TransferFromGodownTOSHopBtn.Location = new System.Drawing.Point(629, 417);
            this.TransferFromGodownTOSHopBtn.Name = "TransferFromGodownTOSHopBtn";
            this.TransferFromGodownTOSHopBtn.Size = new System.Drawing.Size(278, 52);
            this.TransferFromGodownTOSHopBtn.TabIndex = 5;
            this.TransferFromGodownTOSHopBtn.Text = "Transfer From Godown To Shop";
            this.TransferFromGodownTOSHopBtn.UseVisualStyleBackColor = true;
            this.TransferFromGodownTOSHopBtn.Click += new System.EventHandler(this.TransferFromGodownTOSHopBtn_Click);
            // 
            // UpdateProductPanel
            // 
            this.UpdateProductPanel.Controls.Add(this.UpdateValueBtn);
            this.UpdateProductPanel.Controls.Add(this.UpdateValueTB);
            this.UpdateProductPanel.Controls.Add(this.label8);
            this.UpdateProductPanel.Controls.Add(this.label7);
            this.UpdateProductPanel.Controls.Add(this.ProductParameters);
            this.UpdateProductPanel.Controls.Add(this.dataGridView3);
            this.UpdateProductPanel.Location = new System.Drawing.Point(40, 97);
            this.UpdateProductPanel.Name = "UpdateProductPanel";
            this.UpdateProductPanel.Size = new System.Drawing.Size(1394, 587);
            this.UpdateProductPanel.TabIndex = 6;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(34, 26);
            this.dataGridView3.MultiSelect = false;
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowHeadersWidth = 62;
            this.dataGridView3.RowTemplate.Height = 28;
            this.dataGridView3.Size = new System.Drawing.Size(1259, 293);
            this.dataGridView3.TabIndex = 0;
            this.dataGridView3.SelectionChanged += new System.EventHandler(this.dataGridView3_SelectionChanged);
            // 
            // ProductParameters
            // 
            this.ProductParameters.FormattingEnabled = true;
            this.ProductParameters.ItemHeight = 20;
            this.ProductParameters.Items.AddRange(new object[] {
            "Product Name",
            "Product Price",
            "Quantity At Shop",
            "Quantity At Godown",
            "Description"});
            this.ProductParameters.Location = new System.Drawing.Point(34, 396);
            this.ProductParameters.Name = "ProductParameters";
            this.ProductParameters.Size = new System.Drawing.Size(206, 144);
            this.ProductParameters.TabIndex = 1;
            this.ProductParameters.SelectedIndexChanged += new System.EventHandler(this.ProductParameters_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 357);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(202, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Select Update Parameter :-";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(310, 396);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(166, 20);
            this.label8.TabIndex = 3;
            this.label8.Text = "Value to be updated :-";
            // 
            // UpdateValueTB
            // 
            this.UpdateValueTB.Location = new System.Drawing.Point(314, 430);
            this.UpdateValueTB.Name = "UpdateValueTB";
            this.UpdateValueTB.Size = new System.Drawing.Size(191, 26);
            this.UpdateValueTB.TabIndex = 4;
            // 
            // UpdateValueBtn
            // 
            this.UpdateValueBtn.Location = new System.Drawing.Point(314, 506);
            this.UpdateValueBtn.Name = "UpdateValueBtn";
            this.UpdateValueBtn.Size = new System.Drawing.Size(127, 47);
            this.UpdateValueBtn.TabIndex = 5;
            this.UpdateValueBtn.Text = "Update Value";
            this.UpdateValueBtn.UseVisualStyleBackColor = true;
            this.UpdateValueBtn.Click += new System.EventHandler(this.UpdateValueBtn_Click);
            // 
            // ProductOutOfStockBtn
            // 
            this.ProductOutOfStockBtn.Location = new System.Drawing.Point(1036, 23);
            this.ProductOutOfStockBtn.Name = "ProductOutOfStockBtn";
            this.ProductOutOfStockBtn.Size = new System.Drawing.Size(239, 45);
            this.ProductOutOfStockBtn.TabIndex = 14;
            this.ProductOutOfStockBtn.Text = "Product Out Of Stock";
            this.ProductOutOfStockBtn.UseVisualStyleBackColor = true;
            this.ProductOutOfStockBtn.Click += new System.EventHandler(this.ProductOutOfStockBtn_Click);
            // 
            // ProductOutOfStockPanel
            // 
            this.ProductOutOfStockPanel.Controls.Add(this.dataGridView4);
            this.ProductOutOfStockPanel.Location = new System.Drawing.Point(40, 97);
            this.ProductOutOfStockPanel.Name = "ProductOutOfStockPanel";
            this.ProductOutOfStockPanel.Size = new System.Drawing.Size(1394, 587);
            this.ProductOutOfStockPanel.TabIndex = 6;
            // 
            // dataGridView4
            // 
            this.dataGridView4.AllowUserToAddRows = false;
            this.dataGridView4.AllowUserToDeleteRows = false;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(34, 49);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.ReadOnly = true;
            this.dataGridView4.RowHeadersWidth = 62;
            this.dataGridView4.RowTemplate.Height = 28;
            this.dataGridView4.Size = new System.Drawing.Size(1090, 394);
            this.dataGridView4.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1692, 846);
            this.Controls.Add(this.ProductsBtn);
            this.Controls.Add(this.ProductsPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ProductsPanel.ResumeLayout(false);
            this.AddProductPanel.ResumeLayout(false);
            this.AddProductPanel.PerformLayout();
            this.ViewProductsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.QuantityPanel.ResumeLayout(false);
            this.QuantityPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.UpdateProductPanel.ResumeLayout(false);
            this.UpdateProductPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ProductOutOfStockPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ProductsPanel;
        private System.Windows.Forms.Button ProductsBtn;
        private System.Windows.Forms.Panel AddProductPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button UpdateProductBtn;
        private System.Windows.Forms.Button QuantityBtn;
        private System.Windows.Forms.Button ViewProducsBtn;
        private System.Windows.Forms.Button AddProductBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ProductNameTB;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Label AddProductLbl;
        private System.Windows.Forms.TextBox DescriptionTB;
        private System.Windows.Forms.TextBox QuantityAtGodownTB;
        private System.Windows.Forms.TextBox QuantityAtShopTB;
        private System.Windows.Forms.TextBox ProductPriceTB;
        private System.Windows.Forms.Panel ViewProductsPanel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel QuantityPanel;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button TransferFromGodownTOSHopBtn;
        private System.Windows.Forms.Button AddQuantityAtGodown;
        private System.Windows.Forms.Button AddQuantityAtShopBtn;
        private System.Windows.Forms.TextBox QuantityTB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel UpdateProductPanel;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button UpdateValueBtn;
        private System.Windows.Forms.TextBox UpdateValueTB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox ProductParameters;
        private System.Windows.Forms.Panel ProductOutOfStockPanel;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.Button ProductOutOfStockBtn;
    }
}

