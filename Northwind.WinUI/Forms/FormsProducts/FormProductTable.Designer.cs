namespace Northwind.WinUI.Forms.FormsProducts
{
    partial class FormProductTable
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
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnUpdateOrDeleteProduct = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridProducts
            // 
            this.dataGridProducts.AllowUserToAddRows = false;
            this.dataGridProducts.AllowUserToDeleteRows = false;
            this.dataGridProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridProducts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridProducts.Location = new System.Drawing.Point(12, 82);
            this.dataGridProducts.Name = "dataGridProducts";
            this.dataGridProducts.ReadOnly = true;
            this.dataGridProducts.RowHeadersVisible = false;
            this.dataGridProducts.RowHeadersWidth = 100;
            this.dataGridProducts.Size = new System.Drawing.Size(1132, 616);
            this.dataGridProducts.TabIndex = 1;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(817, 17);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(149, 46);
            this.btnAddProduct.TabIndex = 2;
            this.btnAddProduct.Text = "Add New Product";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // btnUpdateOrDeleteProduct
            // 
            this.btnUpdateOrDeleteProduct.Location = new System.Drawing.Point(995, 17);
            this.btnUpdateOrDeleteProduct.Name = "btnUpdateOrDeleteProduct";
            this.btnUpdateOrDeleteProduct.Size = new System.Drawing.Size(149, 46);
            this.btnUpdateOrDeleteProduct.TabIndex = 2;
            this.btnUpdateOrDeleteProduct.Text = "Update or Delete Product";
            this.btnUpdateOrDeleteProduct.UseVisualStyleBackColor = true;
            this.btnUpdateOrDeleteProduct.Click += new System.EventHandler(this.btnUpdateOrDeleteProduct_Click);
            // 
            // FormProductTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 710);
            this.Controls.Add(this.btnUpdateOrDeleteProduct);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.dataGridProducts);
            this.Name = "FormProductTable";
            this.Text = "FormProductTable";
            this.Load += new System.EventHandler(this.FormProductTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridProducts;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnUpdateOrDeleteProduct;
    }
}