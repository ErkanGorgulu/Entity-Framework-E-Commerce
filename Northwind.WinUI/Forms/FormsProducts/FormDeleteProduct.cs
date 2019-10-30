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
    public partial class FormDeleteProduct : Form
    {
        public FormDeleteProduct()
        {
            InitializeComponent();
        }
        ProductController productController = new ProductController();
        private void FormProductDelete_Load(object sender, EventArgs e)
        {
            List<Product> productList = productController.GetProducts();
            cmbProductList.DataSource = productList;
            cmbProductList.DisplayMember = "ProductName";
            cmbProductList.ValueMember = "ProductId";
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            Product products = new Product();
            products.ProductId = Convert.ToInt32(cmbProductList.SelectedValue);
            bool isDeleted = productController.DeleteProduct(products);
            if (isDeleted)
            {
                MessageBox.Show("Successfully Deleted");
            }
        }
    }
}
