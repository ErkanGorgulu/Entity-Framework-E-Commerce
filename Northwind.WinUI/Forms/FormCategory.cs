using Northwind.BLL;
using Northwind.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Northwind.WinUI.Forms
{
    public partial class FormCategory : Form
    {
        public FormCategory()
        {
            InitializeComponent();
        }

        CategoryController categoryController = new CategoryController();

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            Category category = new Category
            {
                CategoryName = txtCategoryName.Text,
                CategoryDescription = txtCategoryDescription.Text
            };

            var result = categoryController.AddCategory(category);

            //if(result) //......
            MessageBox.Show(result.ToString());
        }

        private void FormCategory_Load(object sender, EventArgs e)
        {
            dataGridCategories.DataSource = categoryController.GetCategories();
        }
    }
}