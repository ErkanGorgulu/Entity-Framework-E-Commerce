using Northwind.WinUI.Forms.FormCategories;
using Northwind.WinUI.Forms.FormEmployees;
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

        private void deleteProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDeleteProduct formProductDelete = new FormDeleteProduct();
            formProductDelete.MdiParent = this;
            formProductDelete.Show();
        }

        private void listCategoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormListCategory formCategory = new FormListCategory();
            formCategory.MdiParent = this;
            formCategory.Show();
        }

        private void addCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddCategory formAddCategory = new FormAddCategory();
            formAddCategory.MdiParent = this;
            formAddCategory.Show();
        }

        private void updateCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUpdateCategory formUpdateCategory = new FormUpdateCategory();
            formUpdateCategory.MdiParent = this;
            formUpdateCategory.Show();
        }

        private void deleteCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDeleteCategory formDeleteCategory = new FormDeleteCategory();
            formDeleteCategory.MdiParent = this;
            formDeleteCategory.Show();
        }

        private void listEmployeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormListEmployees formListEmployees = new FormListEmployees();
            formListEmployees.MdiParent = this;
            formListEmployees.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void addEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddEmployee formAddEmployee = new FormAddEmployee();
            formAddEmployee.MdiParent = this;
            formAddEmployee.Show();
        }

        private void updateEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUpdateEmployee formUpdateEmployee = new FormUpdateEmployee();
            formUpdateEmployee.MdiParent = this;
            formUpdateEmployee.Show();
        }

        private void deleteEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDeleteEmployee formDeleteEmployee = new FormDeleteEmployee();
            formDeleteEmployee.MdiParent = this;
            formDeleteEmployee.Show();
        }
    }
}
