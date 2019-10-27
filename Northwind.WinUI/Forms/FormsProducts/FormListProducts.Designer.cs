namespace Northwind.WinUI.Forms
{
    partial class FormListProducts
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
            this.dataGridProducts = new System.Windows.Forms.DataGridView();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblSupplierName = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.cmbSuppliers = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCategories = new System.Windows.Forms.ComboBox();
            this.lblQuantityPerUnit = new System.Windows.Forms.Label();
            this.txtQuantityPerUnit = new System.Windows.Forms.TextBox();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.lblUnitsInStock = new System.Windows.Forms.Label();
            this.txtUnitsInStock = new System.Windows.Forms.TextBox();
            this.lblUnitsOnOrder = new System.Windows.Forms.Label();
            this.txtUnitsOnOrder = new System.Windows.Forms.TextBox();
            this.lblReorderLevel = new System.Windows.Forms.Label();
            this.txtReorderLevel = new System.Windows.Forms.TextBox();
            this.chckDiscontinued = new System.Windows.Forms.CheckBox();
            this.btnAddProduct = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridProducts
            // 
            this.dataGridProducts.AllowUserToAddRows = false;
            this.dataGridProducts.AllowUserToDeleteRows = false;
            this.dataGridProducts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridProducts.ColumnHeadersVisible = false;
            this.dataGridProducts.Location = new System.Drawing.Point(12, 93);
            this.dataGridProducts.Name = "dataGridProducts";
            this.dataGridProducts.ReadOnly = true;
            this.dataGridProducts.RowHeadersWidth = 100;
            this.dataGridProducts.Size = new System.Drawing.Size(1162, 424);
            this.dataGridProducts.TabIndex = 0;
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(9, 9);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(84, 13);
            this.lblProductName.TabIndex = 1;
            this.lblProductName.Text = "Product Name : ";
            // 
            // lblSupplierName
            // 
            this.lblSupplierName.AutoSize = true;
            this.lblSupplierName.Location = new System.Drawing.Point(9, 37);
            this.lblSupplierName.Name = "lblSupplierName";
            this.lblSupplierName.Size = new System.Drawing.Size(54, 13);
            this.lblSupplierName.TabIndex = 1;
            this.lblSupplierName.Text = "Supplier : ";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(100, 9);
            this.txtProductName.MaxLength = 40;
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(170, 20);
            this.txtProductName.TabIndex = 2;
            // 
            // cmbSuppliers
            // 
            this.cmbSuppliers.FormattingEnabled = true;
            this.cmbSuppliers.Location = new System.Drawing.Point(101, 37);
            this.cmbSuppliers.Name = "cmbSuppliers";
            this.cmbSuppliers.Size = new System.Drawing.Size(169, 21);
            this.cmbSuppliers.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(276, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Category : ";
            // 
            // cmbCategories
            // 
            this.cmbCategories.FormattingEnabled = true;
            this.cmbCategories.Location = new System.Drawing.Point(373, 34);
            this.cmbCategories.Name = "cmbCategories";
            this.cmbCategories.Size = new System.Drawing.Size(122, 21);
            this.cmbCategories.TabIndex = 3;
            // 
            // lblQuantityPerUnit
            // 
            this.lblQuantityPerUnit.AutoSize = true;
            this.lblQuantityPerUnit.Location = new System.Drawing.Point(276, 12);
            this.lblQuantityPerUnit.Name = "lblQuantityPerUnit";
            this.lblQuantityPerUnit.Size = new System.Drawing.Size(96, 13);
            this.lblQuantityPerUnit.TabIndex = 1;
            this.lblQuantityPerUnit.Text = "Quantity Per Unit : ";
            // 
            // txtQuantityPerUnit
            // 
            this.txtQuantityPerUnit.Location = new System.Drawing.Point(373, 9);
            this.txtQuantityPerUnit.MaxLength = 20;
            this.txtQuantityPerUnit.Name = "txtQuantityPerUnit";
            this.txtQuantityPerUnit.Size = new System.Drawing.Size(122, 20);
            this.txtQuantityPerUnit.TabIndex = 2;
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Location = new System.Drawing.Point(501, 12);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(62, 13);
            this.lblUnitPrice.TabIndex = 1;
            this.lblUnitPrice.Text = "Unit Price : ";
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new System.Drawing.Point(583, 9);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(116, 20);
            this.txtUnitPrice.TabIndex = 4;
            // 
            // lblUnitsInStock
            // 
            this.lblUnitsInStock.AutoSize = true;
            this.lblUnitsInStock.Location = new System.Drawing.Point(501, 37);
            this.lblUnitsInStock.Name = "lblUnitsInStock";
            this.lblUnitsInStock.Size = new System.Drawing.Size(80, 13);
            this.lblUnitsInStock.TabIndex = 1;
            this.lblUnitsInStock.Text = "Units In Stock :";
            // 
            // txtUnitsInStock
            // 
            this.txtUnitsInStock.Location = new System.Drawing.Point(583, 35);
            this.txtUnitsInStock.Name = "txtUnitsInStock";
            this.txtUnitsInStock.Size = new System.Drawing.Size(116, 20);
            this.txtUnitsInStock.TabIndex = 4;
            // 
            // lblUnitsOnOrder
            // 
            this.lblUnitsOnOrder.AutoSize = true;
            this.lblUnitsOnOrder.Location = new System.Drawing.Point(705, 9);
            this.lblUnitsOnOrder.Name = "lblUnitsOnOrder";
            this.lblUnitsOnOrder.Size = new System.Drawing.Size(83, 13);
            this.lblUnitsOnOrder.TabIndex = 1;
            this.lblUnitsOnOrder.Text = "Units On Order :";
            // 
            // txtUnitsOnOrder
            // 
            this.txtUnitsOnOrder.Location = new System.Drawing.Point(794, 9);
            this.txtUnitsOnOrder.Name = "txtUnitsOnOrder";
            this.txtUnitsOnOrder.Size = new System.Drawing.Size(116, 20);
            this.txtUnitsOnOrder.TabIndex = 4;
            // 
            // lblReorderLevel
            // 
            this.lblReorderLevel.AutoSize = true;
            this.lblReorderLevel.Location = new System.Drawing.Point(705, 37);
            this.lblReorderLevel.Name = "lblReorderLevel";
            this.lblReorderLevel.Size = new System.Drawing.Size(77, 13);
            this.lblReorderLevel.TabIndex = 1;
            this.lblReorderLevel.Text = "ReorderLevel :";
            // 
            // txtReorderLevel
            // 
            this.txtReorderLevel.Location = new System.Drawing.Point(794, 35);
            this.txtReorderLevel.Name = "txtReorderLevel";
            this.txtReorderLevel.Size = new System.Drawing.Size(116, 20);
            this.txtReorderLevel.TabIndex = 4;
            // 
            // chckDiscontinued
            // 
            this.chckDiscontinued.AutoSize = true;
            this.chckDiscontinued.Location = new System.Drawing.Point(934, 12);
            this.chckDiscontinued.Name = "chckDiscontinued";
            this.chckDiscontinued.Size = new System.Drawing.Size(88, 17);
            this.chckDiscontinued.TabIndex = 5;
            this.chckDiscontinued.Text = "Discontinued";
            this.chckDiscontinued.UseVisualStyleBackColor = true;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(1046, 9);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(120, 53);
            this.btnAddProduct.TabIndex = 6;
            this.btnAddProduct.Text = "Add New Product";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.BtnAddProduct_Click);
            // 
            // FormListProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 529);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.chckDiscontinued);
            this.Controls.Add(this.txtUnitsInStock);
            this.Controls.Add(this.txtReorderLevel);
            this.Controls.Add(this.txtUnitsOnOrder);
            this.Controls.Add(this.txtUnitPrice);
            this.Controls.Add(this.cmbCategories);
            this.Controls.Add(this.cmbSuppliers);
            this.Controls.Add(this.txtQuantityPerUnit);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.lblSupplierName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblUnitsInStock);
            this.Controls.Add(this.lblReorderLevel);
            this.Controls.Add(this.lblUnitsOnOrder);
            this.Controls.Add(this.lblUnitPrice);
            this.Controls.Add(this.lblQuantityPerUnit);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.dataGridProducts);
            this.Name = "FormListProducts";
            this.Text = "FormProducts";
            this.Load += new System.EventHandler(this.FormProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridProducts;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblSupplierName;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.ComboBox cmbSuppliers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCategories;
        private System.Windows.Forms.Label lblQuantityPerUnit;
        private System.Windows.Forms.TextBox txtQuantityPerUnit;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.Label lblUnitsInStock;
        private System.Windows.Forms.TextBox txtUnitsInStock;
        private System.Windows.Forms.Label lblUnitsOnOrder;
        private System.Windows.Forms.TextBox txtUnitsOnOrder;
        private System.Windows.Forms.Label lblReorderLevel;
        private System.Windows.Forms.TextBox txtReorderLevel;
        private System.Windows.Forms.CheckBox chckDiscontinued;
        private System.Windows.Forms.Button btnAddProduct;
    }
}