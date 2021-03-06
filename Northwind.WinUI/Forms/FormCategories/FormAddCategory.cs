﻿using Northwind.BLL;
using Northwind.DAL;
using Northwind.Entities;
using Northwind.Helpers;
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
                Description = txtCategoryDescription.Text
            };

            ReturnMessage message = categoryController.AddCategory(category);

            MessageBox.Show(message.Value);
            if (message.isSuccessful)
            {
                foreach (Control control in grpControls.Controls)
                {
                    if (control is TextBox)
                    {
                        TextBox textBox = control as TextBox;
                        textBox.Text = string.Empty;
                    }
                }
            }
            
        }

        private void FormAddCategory_Load(object sender, EventArgs e)
        {

        }
    }
}
