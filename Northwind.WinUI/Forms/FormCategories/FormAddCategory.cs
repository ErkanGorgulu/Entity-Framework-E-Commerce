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
    public partial class FormAddCategory : Form
    {
        public FormAddCategory()
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

            bool isAdded = categoryController.AddCategory(category);

            if(isAdded)
            MessageBox.Show("Successfully Added");
        }
    }
}
