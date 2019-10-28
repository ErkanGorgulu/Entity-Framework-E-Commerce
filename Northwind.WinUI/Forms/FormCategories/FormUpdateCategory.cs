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
    public partial class FormUpdateCategory : Form
    {
        public FormUpdateCategory()
        {
            InitializeComponent();
        }
        CategoryController categoryController = new CategoryController();
        List<Category> categories = new List<Category>();
        private void FormUpdateCategory_Load(object sender, EventArgs e)
        {
            
            categories = categoryController.GetCategories();
            cmbCategoryList.DataSource = categories;
            cmbCategoryList.DisplayMember = "CategoryName";
            cmbCategoryList.ValueMember = "CategoryId";
        }
        private void btnShowCategoryDetails_Click(object sender, EventArgs e)
        {
            foreach (var item in categories)
            {
                if(item.CategoryId == Convert.ToInt32(cmbCategoryList.SelectedValue))
                {
                    txtCategoryName.Text = item.CategoryName;
                    txtCategoryDescription.Text = item.CategoryDescription;
                }
            }
            
        }
        private void btnUpdateCategory_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            category.CategoryId = Convert.ToInt32(cmbCategoryList.SelectedValue);
            category.CategoryName = txtCategoryName.Text;
            category.CategoryDescription = txtCategoryDescription.Text;
            bool isUpdated = categoryController.UpdateCategory(category);
            if (isUpdated)
            {
                MessageBox.Show("Successfully Updated");
            }
        }


    }
}
