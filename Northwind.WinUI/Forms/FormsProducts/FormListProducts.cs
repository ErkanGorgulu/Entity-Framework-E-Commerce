using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Northwind.BLL;
using Northwind.DAL;
using Northwind.Entities;
using Northwind.Helpers;

namespace Northwind.WinUI.Forms
{
    public partial class FormListProducts : Form
    {
        public FormListProducts()
        {
            InitializeComponent();
        }
        ProductController productController = new ProductController();
        private void FormProducts_Load(object sender, EventArgs e)
        {
            #region fill products table                       
            List<Product> productList = productController.GetProducts();
            dataGridProducts.DataSource = productList;
            dataGridProducts.Columns["CategoryId"].Visible = false;
            dataGridProducts.Columns["SupplierId"].Visible = false;
            #endregion

            #region fill category combobox

            //CategoryController categoryController = new CategoryController();
            //List<Category> categories = categoryController.GetCategories();
            //cmbCategories.DataSource = categories;
            //cmbCategories.ValueMember = "CategoryId";
            //cmbCategories.DisplayMember = "CategoryName";
            #endregion

            #region fill suppliers combobox

            //SqlConnection sqlConnection = new SqlConnection(ConnectionTools.ConnectionString);
            //string sqlQuery = "SELECT * FROM Suppliers";
            //SqlCommand sqlCommand = new SqlCommand(sqlQuery, sqlConnection);
            //if(sqlConnection.State == ConnectionState.Closed)
            //{
            //    sqlConnection.Open();
            //}
            //List<Suppliers> suppliersList = new List<Suppliers>();
            //SqlDataReader sqlData = sqlCommand.ExecuteReader();
            //if (sqlData.HasRows)
            //{
            //    while (sqlData.Read())
            //    {
            //        Suppliers suppliers = new Suppliers {
            //            SupplierId = Convert.ToInt32(sqlData["SupplierId"]),
            //            CompanyName = sqlData["CompanyName"].ToString()
            //        };
            //        suppliersList.Add(suppliers);
            //    }
            //}
            //cmbSuppliers.DataSource = suppliersList;
            //cmbSuppliers.ValueMember = "SupplierId";
            //cmbSuppliers.DisplayMember = "CompanyName";
            //sqlConnection.Close();
            #endregion

        }

        private void BtnAddProduct_Click(object sender, EventArgs e)
        {
            
        }
    }
}
