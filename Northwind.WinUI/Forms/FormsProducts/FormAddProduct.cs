using Northwind.BLL;
using Northwind.DAL;
using Northwind.Entities;
using Northwind.Helpers;
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

namespace Northwind.WinUI.Forms.FormsProducts
{
    public partial class FormAddProduct : Form
    {
        public FormAddProduct()
        {
            InitializeComponent();
        }
        ProductController productController = new ProductController();
        CategoryController categoryController = new CategoryController();
        SupplierController supplierController = new SupplierController();
        //SqlConnection sqlConnection = new SqlConnection(Helpers.ConnectionTools.ConnectionString);
        private void FormAddProduct_Load(object sender, EventArgs e)
        {
            //fetch category list            
            List<Category> categories = categoryController.GetCategories();
            cmbCategories.DataSource = categories;
            cmbCategories.ValueMember = "CategoryID";
            cmbCategories.DisplayMember = "CategoryName";
            //fetch supplier list
            List<Supplier> suppliersList = supplierController.GetSuppliers();
            cmbSuppliers.DataSource = suppliersList;
            cmbSuppliers.ValueMember = "SupplierID";
            cmbSuppliers.DisplayMember = "CompanyName";

            #region ADO.NET option for supplier list

            //string sqlQuery = "SELECT * FROM Suppliers";
            //SqlCommand sqlCommand = new SqlCommand(sqlQuery, sqlConnection);
            //if (sqlConnection.State == ConnectionState.Closed)
            //{
            //    sqlConnection.Open();
            //}
            //List<Suppliers> suppliersList = new List<Suppliers>();
            //SqlDataReader sqlData = sqlCommand.ExecuteReader();
            //if (sqlData.HasRows)
            //{
            //    while (sqlData.Read())
            //    {
            //        Suppliers suppliers = new Suppliers
            //        {
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
            try
            {
                decimal tempDecimal = 0;
                tempDecimal = Convert.ToDecimal(txtUnitPrice.Text);
                Int16 tempShort = 0;
                tempShort = Convert.ToInt16(txtUnitsInStock.Text);
                tempShort = Convert.ToInt16(txtUnitsOnOrder.Text);
                tempShort = Convert.ToInt16(txtReorderLevel.Text);
                Product product = new Product
                {
                    ProductName = txtProductName.Text,
                    SupplierID = Convert.ToInt32(cmbSuppliers.SelectedValue),
                    CategoryID = Convert.ToInt32(cmbCategories.SelectedValue),
                    QuantityPerUnit = txtQuantityPerUnit.Text,
                    UnitPrice = Convert.ToDecimal(txtUnitPrice.Text),
                    UnitsInStock = Convert.ToInt16(txtUnitsInStock.Text),
                    UnitsOnOrder = Convert.ToInt16(txtUnitsOnOrder.Text),
                    ReorderLevel = Convert.ToInt16(txtReorderLevel.Text),
                    Discontinued = chckDiscontinued.Checked
                };
                ReturnMessage message = productController.AddProduct(product);
                MessageBox.Show(message.Value);
                foreach (Control control in Controls)
                {
                    if (control is TextBox)
                        control.Text = string.Empty;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid numbers for Unit Price, Units In Stock, Units On Order, Reorder Level.");
            }         
            
        }


    }
}
