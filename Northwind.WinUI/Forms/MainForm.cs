using Northwind.WinUI.Forms.FormsProducts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Northwind.WinUI.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void categoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCategory formCategory = new FormCategory();
            formCategory.MdiParent = this;
            formCategory.Show();
        }


        private void ListProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormListProducts formProducts = new FormListProducts();
            formProducts.MdiParent = this;
            formProducts.Show();
        }

        private void AddNewProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddProduct formAddProduct = new FormAddProduct();
            formAddProduct.MdiParent = this;
            formAddProduct.Show();
        }

        private void updateProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUpdateProducts formUpdateProducts = new FormUpdateProducts();
            formUpdateProducts.MdiParent = this;
            formUpdateProducts.Show();
        }
    }
}
