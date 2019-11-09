namespace Northwind.WinUI.Forms.FormsProducts
{
    partial class FormUpdateProducts
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
            this.cmbProductsList = new System.Windows.Forms.ComboBox();
            this.lblProducts = new System.Windows.Forms.Label();
            this.lblSupplierName = new System.Windows.Forms.Label();
            this.lblCategoryName = new System.Windows.Forms.Label();
            this.cmbSuppliers = new System.Windows.Forms.ComboBox();
            this.cmbCategories = new System.Windows.Forms.ComboBox();
            this.lblQuantityOfUnit = new System.Windows.Forms.Label();
            this.txtQuantityOfUnit = new System.Windows.Forms.TextBox();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.lblUnitsInStock = new System.Windows.Forms.Label();
            this.txtUnitsInStock = new System.Windows.Forms.TextBox();
            this.lblUnitsOnOrder = new System.Windows.Forms.Label();
            this.txtUnitsOnOrder = new System.Windows.Forms.TextBox();
            this.lblReorderLevel = new System.Windows.Forms.Label();
            this.txtReorderLevel = new System.Windows.Forms.TextBox();
            this.chckDiscontinued = new System.Windows.Forms.CheckBox();
            this.btnShowProductDetails = new System.Windows.Forms.Button();
            this.btnUpdateProduct = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbProductsList
            // 
            this.cmbProductsList.FormattingEnabled = true;
            this.cmbProductsList.Location = new System.Drawing.Point(96, 44);
            this.cmbProductsList.Name = "cmbProductsList";
            this.cmbProductsList.Size = new System.Drawing.Size(240, 21);
            this.cmbProductsList.TabIndex = 0;
            // 
            // lblProducts
            // 
            this.lblProducts.AutoSize = true;
            this.lblProducts.Location = new System.Drawing.Point(32, 47);
            this.lblProducts.Name = "lblProducts";
            this.lblProducts.Size = new System.Drawing.Size(49, 13);
            this.lblProducts.TabIndex = 1;
            this.lblProducts.Text = "Products";
            // 
            // lblSupplierName
            // 
            this.lblSupplierName.AutoSize = true;
            this.lblSupplierName.Location = new System.Drawing.Point(31, 96);
            this.lblSupplierName.Name = "lblSupplierName";
            this.lblSupplierName.Size = new System.Drawing.Size(50, 13);
            this.lblSupplierName.TabIndex = 2;
            this.lblSupplierName.Text = "Suppliers";
            // 
            // lblCategoryName
            // 
            this.lblCategoryName.AutoSize = true;
            this.lblCategoryName.Location = new System.Drawing.Point(32, 140);
            this.lblCategoryName.Name = "lblCategoryName";
            this.lblCategoryName.Size = new System.Drawing.Size(49, 13);
            this.lblCategoryName.TabIndex = 2;
            this.lblCategoryName.Text = "Category";
            // 
            // cmbSuppliers
            // 
            this.cmbSuppliers.Enabled = false;
            this.cmbSuppliers.FormattingEnabled = true;
            this.cmbSuppliers.Location = new System.Drawing.Point(96, 93);
            this.cmbSuppliers.Name = "cmbSuppliers";
            this.cmbSuppliers.Size = new System.Drawing.Size(240, 21);
            this.cmbSuppliers.TabIndex = 3;
            // 
            // cmbCategories
            // 
            this.cmbCategories.Enabled = false;
            this.cmbCategories.FormattingEnabled = true;
            this.cmbCategories.Location = new System.Drawing.Point(96, 137);
            this.cmbCategories.Name = "cmbCategories";
            this.cmbCategories.Size = new System.Drawing.Size(240, 21);
            this.cmbCategories.TabIndex = 4;
            // 
            // lblQuantityOfUnit
            // 
            this.lblQuantityOfUnit.AutoSize = true;
            this.lblQuantityOfUnit.Location = new System.Drawing.Point(403, 47);
            this.lblQuantityOfUnit.Name = "lblQuantityOfUnit";
            this.lblQuantityOfUnit.Size = new System.Drawing.Size(82, 13);
            this.lblQuantityOfUnit.TabIndex = 5;
            this.lblQuantityOfUnit.Text = "Quantity Of Unit";
            // 
            // txtQuantityOfUnit
            // 
            this.txtQuantityOfUnit.Enabled = false;
            this.txtQuantityOfUnit.Location = new System.Drawing.Point(521, 44);
            this.txtQuantityOfUnit.Name = "txtQuantityOfUnit";
            this.txtQuantityOfUnit.Size = new System.Drawing.Size(240, 20);
            this.txtQuantityOfUnit.TabIndex = 6;
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Location = new System.Drawing.Point(403, 96);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(53, 13);
            this.lblUnitPrice.TabIndex = 5;
            this.lblUnitPrice.Text = "Unit Price";
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Enabled = false;
            this.txtUnitPrice.Location = new System.Drawing.Point(521, 93);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(240, 20);
            this.txtUnitPrice.TabIndex = 6;
            // 
            // lblUnitsInStock
            // 
            this.lblUnitsInStock.AutoSize = true;
            this.lblUnitsInStock.Location = new System.Drawing.Point(403, 140);
            this.lblUnitsInStock.Name = "lblUnitsInStock";
            this.lblUnitsInStock.Size = new System.Drawing.Size(74, 13);
            this.lblUnitsInStock.TabIndex = 5;
            this.lblUnitsInStock.Text = "Units In Stock";
            // 
            // txtUnitsInStock
            // 
            this.txtUnitsInStock.Enabled = false;
            this.txtUnitsInStock.Location = new System.Drawing.Point(521, 137);
            this.txtUnitsInStock.Name = "txtUnitsInStock";
            this.txtUnitsInStock.Size = new System.Drawing.Size(240, 20);
            this.txtUnitsInStock.TabIndex = 6;
            // 
            // lblUnitsOnOrder
            // 
            this.lblUnitsOnOrder.AutoSize = true;
            this.lblUnitsOnOrder.Location = new System.Drawing.Point(823, 47);
            this.lblUnitsOnOrder.Name = "lblUnitsOnOrder";
            this.lblUnitsOnOrder.Size = new System.Drawing.Size(77, 13);
            this.lblUnitsOnOrder.TabIndex = 5;
            this.lblUnitsOnOrder.Text = "Units On Order";
            // 
            // txtUnitsOnOrder
            // 
            this.txtUnitsOnOrder.Enabled = false;
            this.txtUnitsOnOrder.Location = new System.Drawing.Point(941, 44);
            this.txtUnitsOnOrder.Name = "txtUnitsOnOrder";
            this.txtUnitsOnOrder.Size = new System.Drawing.Size(240, 20);
            this.txtUnitsOnOrder.TabIndex = 6;
            // 
            // lblReorderLevel
            // 
            this.lblReorderLevel.AutoSize = true;
            this.lblReorderLevel.Location = new System.Drawing.Point(823, 96);
            this.lblReorderLevel.Name = "lblReorderLevel";
            this.lblReorderLevel.Size = new System.Drawing.Size(74, 13);
            this.lblReorderLevel.TabIndex = 5;
            this.lblReorderLevel.Text = "Reorder Level";
            // 
            // txtReorderLevel
            // 
            this.txtReorderLevel.Enabled = false;
            this.txtReorderLevel.Location = new System.Drawing.Point(941, 93);
            this.txtReorderLevel.Name = "txtReorderLevel";
            this.txtReorderLevel.Size = new System.Drawing.Size(240, 20);
            this.txtReorderLevel.TabIndex = 6;
            // 
            // chckDiscontinued
            // 
            this.chckDiscontinued.AutoSize = true;
            this.chckDiscontinued.Enabled = false;
            this.chckDiscontinued.Location = new System.Drawing.Point(826, 135);
            this.chckDiscontinued.Name = "chckDiscontinued";
            this.chckDiscontinued.Size = new System.Drawing.Size(88, 17);
            this.chckDiscontinued.TabIndex = 7;
            this.chckDiscontinued.Text = "Discontinued";
            this.chckDiscontinued.UseVisualStyleBackColor = true;
            // 
            // btnShowProductDetails
            // 
            this.btnShowProductDetails.Location = new System.Drawing.Point(205, 208);
            this.btnShowProductDetails.Name = "btnShowProductDetails";
            this.btnShowProductDetails.Size = new System.Drawing.Size(131, 56);
            this.btnShowProductDetails.TabIndex = 8;
            this.btnShowProductDetails.Text = "Show Product Details";
            this.btnShowProductDetails.UseVisualStyleBackColor = true;
            this.btnShowProductDetails.Click += new System.EventHandler(this.btnShowProductDetails_Click);
            // 
            // btnUpdateProduct
            // 
            this.btnUpdateProduct.Location = new System.Drawing.Point(572, 208);
            this.btnUpdateProduct.Name = "btnUpdateProduct";
            this.btnUpdateProduct.Size = new System.Drawing.Size(131, 56);
            this.btnUpdateProduct.TabIndex = 8;
            this.btnUpdateProduct.Text = "Update Product";
            this.btnUpdateProduct.UseVisualStyleBackColor = true;
            this.btnUpdateProduct.Click += new System.EventHandler(this.btnUpdateProduct_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(98, 21);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(212, 13);
            this.lblInfo.TabIndex = 9;
            this.lblInfo.Text = "Select the product you would like to update";
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.Location = new System.Drawing.Point(916, 208);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(131, 56);
            this.btnDeleteProduct.TabIndex = 8;
            this.btnDeleteProduct.Text = "Delete Product";
            this.btnDeleteProduct.UseVisualStyleBackColor = true;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // FormUpdateProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 322);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnDeleteProduct);
            this.Controls.Add(this.btnUpdateProduct);
            this.Controls.Add(this.btnShowProductDetails);
            this.Controls.Add(this.chckDiscontinued);
            this.Controls.Add(this.txtUnitsInStock);
            this.Controls.Add(this.txtUnitPrice);
            this.Controls.Add(this.lblUnitsInStock);
            this.Controls.Add(this.txtReorderLevel);
            this.Controls.Add(this.txtUnitsOnOrder);
            this.Controls.Add(this.txtQuantityOfUnit);
            this.Controls.Add(this.lblReorderLevel);
            this.Controls.Add(this.lblUnitsOnOrder);
            this.Controls.Add(this.lblUnitPrice);
            this.Controls.Add(this.lblQuantityOfUnit);
            this.Controls.Add(this.cmbCategories);
            this.Controls.Add(this.cmbSuppliers);
            this.Controls.Add(this.lblCategoryName);
            this.Controls.Add(this.lblSupplierName);
            this.Controls.Add(this.lblProducts);
            this.Controls.Add(this.cmbProductsList);
            this.Name = "FormUpdateProducts";
            this.Text = "FormUpdateProducts";
            this.Load += new System.EventHandler(this.FormUpdateProducts_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbProductsList;
        private System.Windows.Forms.Label lblProducts;
        private System.Windows.Forms.Label lblSupplierName;
        private System.Windows.Forms.Label lblCategoryName;
        private System.Windows.Forms.ComboBox cmbSuppliers;
        private System.Windows.Forms.ComboBox cmbCategories;
        private System.Windows.Forms.Label lblQuantityOfUnit;
        private System.Windows.Forms.TextBox txtQuantityOfUnit;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.Label lblUnitsInStock;
        private System.Windows.Forms.TextBox txtUnitsInStock;
        private System.Windows.Forms.Label lblUnitsOnOrder;
        private System.Windows.Forms.TextBox txtUnitsOnOrder;
        private System.Windows.Forms.Label lblReorderLevel;
        private System.Windows.Forms.TextBox txtReorderLevel;
        private System.Windows.Forms.CheckBox chckDiscontinued;
        private System.Windows.Forms.Button btnShowProductDetails;
        private System.Windows.Forms.Button btnUpdateProduct;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnDeleteProduct;
    }
}