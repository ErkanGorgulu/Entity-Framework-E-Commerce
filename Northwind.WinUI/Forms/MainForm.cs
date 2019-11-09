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

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProductTable formProductTable = new FormProductTable();
            formProductTable.MdiParent = this;
            formProductTable.Show();
        }

        private void categoryToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FormCategoryTable formCategoryTable = new FormCategoryTable();
            formCategoryTable.MdiParent = this;
            formCategoryTable.Show();
        }
    }
}
