using Northwind.BLL;
using Northwind.DAL;
using Northwind.Entities;
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
        SqlConnection sqlConnection = new SqlConnection(Helpers.ConnectionTools.ConnectionString);
        private void FormAddProduct_Load(object sender, EventArgs e)
        {
            #region fill category combobox

            CategoryController categoryController = new CategoryController();
            List<Category> categories = categoryController.GetCategories();
            cmbCategories.DataSource = categories;
            cmbCategories.ValueMember = "CategoryId";
            cmbCategories.DisplayMember = "CategoryName";
            #endregion

            #region fill suppliers combobox

            string sqlQuery = "SELECT * FROM Suppliers";
            SqlCommand sqlCommand = new SqlCommand(sqlQuery, sqlConnection);
            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
            List<Suppliers> suppliersList = new List<Suppliers>();
            SqlDataReader sqlData = sqlCommand.ExecuteReader();
            if (sqlData.HasRows)
            {
                while (sqlData.Read())
                {
                    Suppliers suppliers = new Suppliers
                    {
                        SupplierId = Convert.ToInt32(sqlData["SupplierId"]),
                        CompanyName = sqlData["CompanyName"].ToString()
                    };
                    suppliersList.Add(suppliers);
                }
            }
            cmbSuppliers.DataSource = suppliersList;
            cmbSuppliers.ValueMember = "SupplierId";
            cmbSuppliers.DisplayMember = "CompanyName";
            sqlConnection.Close();
            #endregion

        }
        private void BtnAddProduct_Click(object sender, EventArgs e)
        {
            Product products = new Product
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
            bool isAdded = productController.AddProduct(products);
            if (isAdded)
            {
                MessageBox.Show("Eklendi");
            }
        }


    }
}
