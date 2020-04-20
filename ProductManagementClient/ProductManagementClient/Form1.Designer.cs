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
            this.ProductPriceTB = new System.Windows.Forms.TextBox();
            this.QuantityAtShopTB = new System.Windows.Forms.TextBox();
            this.QuantityAtGodownTB = new System.Windows.Forms.TextBox();
            this.DescriptionTB = new System.Windows.Forms.TextBox();
            this.AddProductLbl = new System.Windows.Forms.Label();
            this.AddBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.ProductsPanel.SuspendLayout();
            this.AddProductPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProductsPanel
            // 
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
            this.AddProductPanel.Size = new System.Drawing.Size(1093, 587);
            this.AddProductPanel.TabIndex = 4;
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
            // 
            // QuantityBtn
            // 
            this.QuantityBtn.Location = new System.Drawing.Point(516, 23);
            this.QuantityBtn.Name = "QuantityBtn";
            this.QuantityBtn.Size = new System.Drawing.Size(183, 45);
            this.QuantityBtn.TabIndex = 2;
            this.QuantityBtn.Text = "Quantity";
            this.QuantityBtn.UseVisualStyleBackColor = true;
            // 
            // ViewProducsBtn
            // 
            this.ViewProducsBtn.Location = new System.Drawing.Point(294, 23);
            this.ViewProducsBtn.Name = "ViewProducsBtn";
            this.ViewProducsBtn.Size = new System.Drawing.Size(172, 45);
            this.ViewProducsBtn.TabIndex = 1;
            this.ViewProducsBtn.Text = "View Products";
            this.ViewProducsBtn.UseVisualStyleBackColor = true;
            // 
            // AddProductBtn
            // 
            this.AddProductBtn.Location = new System.Drawing.Point(40, 23);
            this.AddProductBtn.Name = "AddProductBtn";
            this.AddProductBtn.Size = new System.Drawing.Size(203, 45);
            this.AddProductBtn.TabIndex = 0;
            this.AddProductBtn.Text = "Add Product";
            this.AddProductBtn.UseVisualStyleBackColor = true;
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
            // ProductPriceTB
            // 
            this.ProductPriceTB.Location = new System.Drawing.Point(224, 70);
            this.ProductPriceTB.Name = "ProductPriceTB";
            this.ProductPriceTB.Size = new System.Drawing.Size(234, 26);
            this.ProductPriceTB.TabIndex = 6;
            // 
            // QuantityAtShopTB
            // 
            this.QuantityAtShopTB.Location = new System.Drawing.Point(224, 120);
            this.QuantityAtShopTB.Name = "QuantityAtShopTB";
            this.QuantityAtShopTB.Size = new System.Drawing.Size(234, 26);
            this.QuantityAtShopTB.TabIndex = 7;
            // 
            // QuantityAtGodownTB
            // 
            this.QuantityAtGodownTB.Location = new System.Drawing.Point(224, 168);
            this.QuantityAtGodownTB.Name = "QuantityAtGodownTB";
            this.QuantityAtGodownTB.Size = new System.Drawing.Size(234, 26);
            this.QuantityAtGodownTB.TabIndex = 8;
            // 
            // DescriptionTB
            // 
            this.DescriptionTB.Location = new System.Drawing.Point(224, 220);
            this.DescriptionTB.Name = "DescriptionTB";
            this.DescriptionTB.Size = new System.Drawing.Size(234, 26);
            this.DescriptionTB.TabIndex = 9;
            // 
            // AddProductLbl
            // 
            this.AddProductLbl.AutoSize = true;
            this.AddProductLbl.Location = new System.Drawing.Point(30, 275);
            this.AddProductLbl.Name = "AddProductLbl";
            this.AddProductLbl.Size = new System.Drawing.Size(0, 20);
            this.AddProductLbl.TabIndex = 10;
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(50, 331);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(190, 46);
            this.AddBtn.TabIndex = 11;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(302, 331);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(179, 46);
            this.CancelBtn.TabIndex = 12;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
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
    }
}

