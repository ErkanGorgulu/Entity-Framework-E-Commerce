﻿using Northwind.BLL;
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
            FetchCategoryList();
        }     
        
        private void btnUpdateCategory_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            category.CategoryId = Convert.ToInt32(cmbCategoryList.SelectedValue);
            category.CategoryName = txtCategoryName.Text;
            category.CategoryDescription = txtCategoryDescription.Text;
            ReturnMessage message = categoryController.UpdateCategory(category);
            MessageBox.Show(message.Value);
                // after updating refresh category list and clear textboxes
            FetchCategoryList();
            ClearTextBoxes();            
        }        

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            category.CategoryId = Convert.ToInt32(cmbCategoryList.SelectedValue);
            category.CategoryName = cmbCategoryList.GetItemText(cmbCategoryList.SelectedItem);
            ReturnMessage message = categoryController.DeleteCategory(category);
            MessageBox.Show(message.Value);
                // after updating refresh category list and clear textboxes
            FetchCategoryList();
            ClearTextBoxes();            
        }

        private void cmbCategoryList_SelectionChangeCommitted(object sender, EventArgs e)
        {
            foreach (var item in categories)
            {
                if (item.CategoryId == Convert.ToInt32(cmbCategoryList.SelectedValue))
                {
                    txtCategoryName.Text = item.CategoryName;
                    txtCategoryDescription.Text = item.CategoryDescription;
                }
            }
        }
        private void FetchCategoryList()
        {
            cmbCategoryList.DataSource = null;
            categories = categoryController.GetCategories();
            cmbCategoryList.DataSource = categories;
            cmbCategoryList.DisplayMember = "CategoryName";
            cmbCategoryList.ValueMember = "CategoryId";
        }
        private void ClearTextBoxes()
        {
            foreach (Control control in grpCategoryUpdateOrDelete.Controls)
            {
                if (control is TextBox)
                {
                    TextBox textBox = control as TextBox;
                    textBox.Text = string.Empty;
                }
            }
        }
    }
    }

