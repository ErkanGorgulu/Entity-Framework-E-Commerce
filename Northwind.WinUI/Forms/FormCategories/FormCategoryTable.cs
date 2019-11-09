using Northwind.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Northwind.WinUI.Forms.FormCategories
{
    public partial class FormCategoryTable : Form
    {
        public FormCategoryTable()
        {
            InitializeComponent();
        }
        CategoryController categoryController = new CategoryController();
        private void FormCategoryTable_Load(object sender, EventArgs e)
        {
            dataGridCategories.DataSource = categoryController.GetCategories();
        }

        private void btnAddNewCategory_Click(object sender, EventArgs e)
        {
            FormAddCategory formAddCategory = new FormAddCategory();
            formAddCategory.ShowDialog();
        }

        private void btnUpdateOrDeleteCategory_Click(object sender, EventArgs e)
        {
            FormUpdateCategory formUpdateCategory = new FormUpdateCategory();
            formUpdateCategory.ShowDialog();
        }
    }
}
