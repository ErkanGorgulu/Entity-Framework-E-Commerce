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

namespace Northwind.WinUI.Forms.FormCategories
{
    public partial class FormDeleteCategory : Form
    {
        public FormDeleteCategory()
        {
            InitializeComponent();
        }
        CategoryController categoryController = new CategoryController();
        private void FormDeleteCategory_Load(object sender, EventArgs e)
        {
            List<Category> categories = categoryController.GetCategories();
            cmbCategoryList.DataSource = categories;
            cmbCategoryList.ValueMember = "CategoryId";
            cmbCategoryList.DisplayMember = "CategoryName";
        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            category.CategoryId = Convert.ToInt32(cmbCategoryList.SelectedValue);
            bool isDeleted = categoryController.DeleteCategory(category);
            if (isDeleted)
            {
                string message = string.Format("{0} Successfully Deleted", cmbCategoryList.GetItemText(cmbCategoryList.SelectedItem));
                MessageBox.Show(message);
            }
        }
    }
}
