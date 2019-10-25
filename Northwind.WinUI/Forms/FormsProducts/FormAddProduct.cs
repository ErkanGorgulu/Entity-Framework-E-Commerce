using Northwind.BLL;
using Northwind.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Northwind.WinUI.Forms.FormsProducts
{
    public partial class FormAddProduct : Form
    {
        public FormAddProduct()
        {
            InitializeComponent();
        }
        ProductController productController = new ProductController();
        private void BtnAddProduct_Click(object sender, EventArgs e)
        {
            Products products = new Products
            {

                ProductName = txtProductName.Text,
                SupplierId = Convert.ToInt32(cmbSuppliers.SelectedValue),
                CategoryId = Convert.ToInt32(cmbCategories.SelectedValue),
                QuantityPerUnit = txtQuantityPerUnit.Text,
                UnitPrice = Convert.ToDecimal(txtUnitPrice.Text),
                UnitsInStock = Convert.ToInt32(txtUnitsInStock.Text),
                UnitsOnOrder = Convert.ToInt32(txtUnitsOnOrder.Text),
                ReorderLevel = Convert.ToInt32(txtReorderLevel.Text),
                Discontinued = chckDiscontinued.Checked
            };
            bool isAdded = productController.AddProduct(products);
            if (isAdded)
            {
                MessageBox.Show("Eklendi");
            }
        }
    }
}
