using Northwind.BLL;
using Northwind.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Northwind.WinUI.Forms
{
    public partial class FormListCategory : Form
    {
        public FormListCategory()
        {
            InitializeComponent();
        }

        CategoryController categoryController = new CategoryController();

        private void FormCategory_Load(object sender, EventArgs e)
        {
            dataGridCategories.DataSource = categoryController.GetCategories();
        }
    }
}