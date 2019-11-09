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
    public partial class FormProductTable : Form
    {
        public FormProductTable()
        {
            InitializeComponent();
        }
        ProductController productController = new ProductController();

        private void FormProductTable_Load(object sender, EventArgs e)
        {
            #region fill products table                       
            List<Product> productList = productController.GetProducts();
            dataGridProducts.DataSource = productList;
            dataGridProducts.Columns["CategoryId"].Visible = false;
            dataGridProducts.Columns["SupplierId"].Visible = false;
            #endregion

        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            FormAddProduct formAddProduct = new FormAddProduct();
            formAddProduct.ShowDialog();
        }

        private void btnUpdateOrDeleteProduct_Click(object sender, EventArgs e)
        {
            FormUpdateProducts formUpdateProducts = new FormUpdateProducts();
            formUpdateProducts.ShowDialog();
        }
    }
}
