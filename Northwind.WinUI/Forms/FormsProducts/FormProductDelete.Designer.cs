namespace Northwind.WinUI.Forms.FormsProducts
{
    partial class FormProductDelete
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
            this.cmbProductList = new System.Windows.Forms.ComboBox();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.lblSelectTheProduct = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbProductList
            // 
            this.cmbProductList.FormattingEnabled = true;
            this.cmbProductList.Location = new System.Drawing.Point(34, 70);
            this.cmbProductList.Name = "cmbProductList";
            this.cmbProductList.Size = new System.Drawing.Size(253, 21);
            this.cmbProductList.TabIndex = 0;
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.Location = new System.Drawing.Point(324, 69);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(126, 21);
            this.btnDeleteProduct.TabIndex = 1;
            this.btnDeleteProduct.Text = "Delete Product";
            this.btnDeleteProduct.UseVisualStyleBackColor = true;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // lblSelectTheProduct
            // 
            this.lblSelectTheProduct.AutoSize = true;
            this.lblSelectTheProduct.Location = new System.Drawing.Point(34, 29);
            this.lblSelectTheProduct.Name = "lblSelectTheProduct";
            this.lblSelectTheProduct.Size = new System.Drawing.Size(208, 13);
            this.lblSelectTheProduct.TabIndex = 2;
            this.lblSelectTheProduct.Text = "Select the product you would like to delete";
            // 
            // FormProductDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 134);
            this.Controls.Add(this.lblSelectTheProduct);
            this.Controls.Add(this.btnDeleteProduct);
            this.Controls.Add(this.cmbProductList);
            this.Name = "FormProductDelete";
            this.Text = "FormProductDelete";
            this.Load += new System.EventHandler(this.FormProductDelete_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbProductList;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.Label lblSelectTheProduct;
    }
}