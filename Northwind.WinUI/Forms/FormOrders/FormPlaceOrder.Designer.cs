namespace Northwind.WinUI.Forms.FormOrders
{
    partial class FormPlaceOrder
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
            this.lblProducts = new System.Windows.Forms.Label();
            this.lstAddedProducts = new System.Windows.Forms.ListBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.numericQuantity = new System.Windows.Forms.NumericUpDown();
            this.lblShowPrice = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.btnAddProductToList = new System.Windows.Forms.Button();
            this.dateOrderDate = new System.Windows.Forms.DateTimePicker();
            this.lblOrderDate = new System.Windows.Forms.Label();
            this.lblShoppingCart = new System.Windows.Forms.Label();
            this.groupProducts = new System.Windows.Forms.GroupBox();
            this.cmbDiscountList = new System.Windows.Forms.ComboBox();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblDiscountedTotalPrice = new System.Windows.Forms.Label();
            this.groupCustomerEmployee = new System.Windows.Forms.GroupBox();
            this.lblShipper = new System.Windows.Forms.Label();
            this.cmbShipperList = new System.Windows.Forms.ComboBox();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.cmbEmployeeList = new System.Windows.Forms.ComboBox();
            this.lblCustomers = new System.Windows.Forms.Label();
            this.cmbCustomerList = new System.Windows.Forms.ComboBox();
            this.groupDates = new System.Windows.Forms.GroupBox();
            this.lblRequiredDate = new System.Windows.Forms.Label();
            this.dateRequiredDate = new System.Windows.Forms.DateTimePicker();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericQuantity)).BeginInit();
            this.groupProducts.SuspendLayout();
            this.groupCustomerEmployee.SuspendLayout();
            this.groupDates.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbProductList
            // 
            this.cmbProductList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProductList.FormattingEnabled = true;
            this.cmbProductList.Location = new System.Drawing.Point(9, 35);
            this.cmbProductList.Name = "cmbProductList";
            this.cmbProductList.Size = new System.Drawing.Size(247, 21);
            this.cmbProductList.TabIndex = 0;
            this.cmbProductList.SelectionChangeCommitted += new System.EventHandler(this.cmbProductList_SelectionChangeCommitted);
            // 
            // lblProducts
            // 
            this.lblProducts.AutoSize = true;
            this.lblProducts.Location = new System.Drawing.Point(6, 16);
            this.lblProducts.Name = "lblProducts";
            this.lblProducts.Size = new System.Drawing.Size(49, 13);
            this.lblProducts.TabIndex = 1;
            this.lblProducts.Text = "Products";
            // 
            // lstAddedProducts
            // 
            this.lstAddedProducts.FormattingEnabled = true;
            this.lstAddedProducts.Location = new System.Drawing.Point(287, 35);
            this.lstAddedProducts.Name = "lstAddedProducts";
            this.lstAddedProducts.Size = new System.Drawing.Size(387, 134);
            this.lstAddedProducts.TabIndex = 2;
            this.lstAddedProducts.UseTabStops = false;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(9, 78);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(46, 13);
            this.lblQuantity.TabIndex = 1;
            this.lblQuantity.Text = "Quantity";
            // 
            // numericQuantity
            // 
            this.numericQuantity.Location = new System.Drawing.Point(92, 76);
            this.numericQuantity.Name = "numericQuantity";
            this.numericQuantity.Size = new System.Drawing.Size(164, 20);
            this.numericQuantity.TabIndex = 3;
            this.numericQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericQuantity.ValueChanged += new System.EventHandler(this.numericQuantity_ValueChanged);
            // 
            // lblShowPrice
            // 
            this.lblShowPrice.AutoSize = true;
            this.lblShowPrice.Location = new System.Drawing.Point(9, 116);
            this.lblShowPrice.Name = "lblShowPrice";
            this.lblShowPrice.Size = new System.Drawing.Size(31, 13);
            this.lblShowPrice.TabIndex = 1;
            this.lblShowPrice.Text = "Price";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.Location = new System.Drawing.Point(89, 116);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(25, 13);
            this.lblTotalPrice.TabIndex = 1;
            this.lblTotalPrice.Text = "0 $ ";
            // 
            // btnAddProductToList
            // 
            this.btnAddProductToList.Location = new System.Drawing.Point(159, 143);
            this.btnAddProductToList.Name = "btnAddProductToList";
            this.btnAddProductToList.Size = new System.Drawing.Size(97, 31);
            this.btnAddProductToList.TabIndex = 4;
            this.btnAddProductToList.Text = "Add To List";
            this.btnAddProductToList.UseVisualStyleBackColor = true;
            this.btnAddProductToList.Click += new System.EventHandler(this.btnAddProductToList_Click);
            // 
            // dateOrderDate
            // 
            this.dateOrderDate.Location = new System.Drawing.Point(70, 76);
            this.dateOrderDate.MinDate = new System.DateTime(2019, 11, 17, 18, 46, 4, 0);
            this.dateOrderDate.Name = "dateOrderDate";
            this.dateOrderDate.Size = new System.Drawing.Size(247, 20);
            this.dateOrderDate.TabIndex = 5;
            this.dateOrderDate.Value = new System.DateTime(2019, 11, 17, 18, 46, 4, 0);
            this.dateOrderDate.ValueChanged += new System.EventHandler(this.dateOrderDate_ValueChanged);
            // 
            // lblOrderDate
            // 
            this.lblOrderDate.AutoSize = true;
            this.lblOrderDate.Location = new System.Drawing.Point(70, 50);
            this.lblOrderDate.Name = "lblOrderDate";
            this.lblOrderDate.Size = new System.Drawing.Size(59, 13);
            this.lblOrderDate.TabIndex = 1;
            this.lblOrderDate.Text = "Order Date";
            // 
            // lblShoppingCart
            // 
            this.lblShoppingCart.AutoSize = true;
            this.lblShoppingCart.Location = new System.Drawing.Point(284, 16);
            this.lblShoppingCart.Name = "lblShoppingCart";
            this.lblShoppingCart.Size = new System.Drawing.Size(74, 13);
            this.lblShoppingCart.TabIndex = 1;
            this.lblShoppingCart.Text = "Shopping Cart";
            // 
            // groupProducts
            // 
            this.groupProducts.Controls.Add(this.cmbDiscountList);
            this.groupProducts.Controls.Add(this.lblProducts);
            this.groupProducts.Controls.Add(this.cmbProductList);
            this.groupProducts.Controls.Add(this.btnAddProductToList);
            this.groupProducts.Controls.Add(this.lstAddedProducts);
            this.groupProducts.Controls.Add(this.lblDiscount);
            this.groupProducts.Controls.Add(this.lblQuantity);
            this.groupProducts.Controls.Add(this.lblShoppingCart);
            this.groupProducts.Controls.Add(this.numericQuantity);
            this.groupProducts.Controls.Add(this.lblShowPrice);
            this.groupProducts.Controls.Add(this.lblDiscountedTotalPrice);
            this.groupProducts.Controls.Add(this.lblTotalPrice);
            this.groupProducts.Location = new System.Drawing.Point(25, 36);
            this.groupProducts.Name = "groupProducts";
            this.groupProducts.Size = new System.Drawing.Size(680, 189);
            this.groupProducts.TabIndex = 6;
            this.groupProducts.TabStop = false;
            // 
            // cmbDiscountList
            // 
            this.cmbDiscountList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDiscountList.FormattingEnabled = true;
            this.cmbDiscountList.Location = new System.Drawing.Point(92, 147);
            this.cmbDiscountList.Name = "cmbDiscountList";
            this.cmbDiscountList.Size = new System.Drawing.Size(49, 21);
            this.cmbDiscountList.TabIndex = 5;
            this.cmbDiscountList.SelectionChangeCommitted += new System.EventHandler(this.cmbDiscountList_SelectionChangeCommitted);
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Location = new System.Drawing.Point(9, 152);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(49, 13);
            this.lblDiscount.TabIndex = 1;
            this.lblDiscount.Text = "Discount";
            // 
            // lblDiscountedTotalPrice
            // 
            this.lblDiscountedTotalPrice.AutoSize = true;
            this.lblDiscountedTotalPrice.Location = new System.Drawing.Point(156, 116);
            this.lblDiscountedTotalPrice.Name = "lblDiscountedTotalPrice";
            this.lblDiscountedTotalPrice.Size = new System.Drawing.Size(0, 13);
            this.lblDiscountedTotalPrice.TabIndex = 1;
            // 
            // groupCustomerEmployee
            // 
            this.groupCustomerEmployee.Controls.Add(this.lblShipper);
            this.groupCustomerEmployee.Controls.Add(this.cmbShipperList);
            this.groupCustomerEmployee.Controls.Add(this.lblEmployee);
            this.groupCustomerEmployee.Controls.Add(this.cmbEmployeeList);
            this.groupCustomerEmployee.Controls.Add(this.lblCustomers);
            this.groupCustomerEmployee.Controls.Add(this.cmbCustomerList);
            this.groupCustomerEmployee.Location = new System.Drawing.Point(25, 247);
            this.groupCustomerEmployee.Name = "groupCustomerEmployee";
            this.groupCustomerEmployee.Size = new System.Drawing.Size(276, 201);
            this.groupCustomerEmployee.TabIndex = 7;
            this.groupCustomerEmployee.TabStop = false;
            // 
            // lblShipper
            // 
            this.lblShipper.AutoSize = true;
            this.lblShipper.Location = new System.Drawing.Point(6, 128);
            this.lblShipper.Name = "lblShipper";
            this.lblShipper.Size = new System.Drawing.Size(90, 13);
            this.lblShipper.TabIndex = 1;
            this.lblShipper.Text = "Shipper Company";
            // 
            // cmbShipperList
            // 
            this.cmbShipperList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbShipperList.FormattingEnabled = true;
            this.cmbShipperList.Location = new System.Drawing.Point(9, 147);
            this.cmbShipperList.Name = "cmbShipperList";
            this.cmbShipperList.Size = new System.Drawing.Size(247, 21);
            this.cmbShipperList.TabIndex = 0;
            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.Location = new System.Drawing.Point(6, 72);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(53, 13);
            this.lblEmployee.TabIndex = 1;
            this.lblEmployee.Text = "Employee";
            // 
            // cmbEmployeeList
            // 
            this.cmbEmployeeList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmployeeList.FormattingEnabled = true;
            this.cmbEmployeeList.Location = new System.Drawing.Point(9, 91);
            this.cmbEmployeeList.Name = "cmbEmployeeList";
            this.cmbEmployeeList.Size = new System.Drawing.Size(247, 21);
            this.cmbEmployeeList.TabIndex = 0;
            // 
            // lblCustomers
            // 
            this.lblCustomers.AutoSize = true;
            this.lblCustomers.Location = new System.Drawing.Point(6, 18);
            this.lblCustomers.Name = "lblCustomers";
            this.lblCustomers.Size = new System.Drawing.Size(56, 13);
            this.lblCustomers.TabIndex = 1;
            this.lblCustomers.Text = "Customers";
            // 
            // cmbCustomerList
            // 
            this.cmbCustomerList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCustomerList.FormattingEnabled = true;
            this.cmbCustomerList.Location = new System.Drawing.Point(9, 37);
            this.cmbCustomerList.Name = "cmbCustomerList";
            this.cmbCustomerList.Size = new System.Drawing.Size(247, 21);
            this.cmbCustomerList.TabIndex = 0;
            // 
            // groupDates
            // 
            this.groupDates.Controls.Add(this.lblRequiredDate);
            this.groupDates.Controls.Add(this.dateRequiredDate);
            this.groupDates.Controls.Add(this.lblOrderDate);
            this.groupDates.Controls.Add(this.dateOrderDate);
            this.groupDates.Location = new System.Drawing.Point(312, 247);
            this.groupDates.Name = "groupDates";
            this.groupDates.Size = new System.Drawing.Size(393, 201);
            this.groupDates.TabIndex = 8;
            this.groupDates.TabStop = false;
            // 
            // lblRequiredDate
            // 
            this.lblRequiredDate.AutoSize = true;
            this.lblRequiredDate.Location = new System.Drawing.Point(70, 104);
            this.lblRequiredDate.Name = "lblRequiredDate";
            this.lblRequiredDate.Size = new System.Drawing.Size(76, 13);
            this.lblRequiredDate.TabIndex = 1;
            this.lblRequiredDate.Text = "Required Date";
            // 
            // dateRequiredDate
            // 
            this.dateRequiredDate.Enabled = false;
            this.dateRequiredDate.Location = new System.Drawing.Point(70, 130);
            this.dateRequiredDate.MinDate = new System.DateTime(2019, 11, 17, 19, 3, 20, 0);
            this.dateRequiredDate.Name = "dateRequiredDate";
            this.dateRequiredDate.Size = new System.Drawing.Size(247, 20);
            this.dateRequiredDate.TabIndex = 5;
            this.dateRequiredDate.Value = new System.DateTime(2019, 11, 17, 19, 3, 20, 0);
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.Location = new System.Drawing.Point(227, 489);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(150, 47);
            this.btnPlaceOrder.TabIndex = 9;
            this.btnPlaceOrder.Text = "Place Order";
            this.btnPlaceOrder.UseVisualStyleBackColor = true;
            // 
            // FormPlaceOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 569);
            this.Controls.Add(this.btnPlaceOrder);
            this.Controls.Add(this.groupDates);
            this.Controls.Add(this.groupCustomerEmployee);
            this.Controls.Add(this.groupProducts);
            this.Name = "FormPlaceOrder";
            this.Text = "Place a New Order";
            this.Load += new System.EventHandler(this.FormPlaceOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericQuantity)).EndInit();
            this.groupProducts.ResumeLayout(false);
            this.groupProducts.PerformLayout();
            this.groupCustomerEmployee.ResumeLayout(false);
            this.groupCustomerEmployee.PerformLayout();
            this.groupDates.ResumeLayout(false);
            this.groupDates.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbProductList;
        private System.Windows.Forms.Label lblProducts;
        private System.Windows.Forms.ListBox lstAddedProducts;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.NumericUpDown numericQuantity;
        private System.Windows.Forms.Label lblShowPrice;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Button btnAddProductToList;
        private System.Windows.Forms.DateTimePicker dateOrderDate;
        private System.Windows.Forms.Label lblOrderDate;
        private System.Windows.Forms.Label lblShoppingCart;
        private System.Windows.Forms.GroupBox groupProducts;
        private System.Windows.Forms.GroupBox groupCustomerEmployee;
        private System.Windows.Forms.Label lblShipper;
        private System.Windows.Forms.ComboBox cmbShipperList;
        private System.Windows.Forms.Label lblEmployee;
        private System.Windows.Forms.ComboBox cmbEmployeeList;
        private System.Windows.Forms.Label lblCustomers;
        private System.Windows.Forms.ComboBox cmbCustomerList;
        private System.Windows.Forms.GroupBox groupDates;
        private System.Windows.Forms.Label lblRequiredDate;
        private System.Windows.Forms.DateTimePicker dateRequiredDate;
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.ComboBox cmbDiscountList;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblDiscountedTotalPrice;
    }
}