using Northwind.BLL;
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
    public partial class FormUpdateProducts : Form
    {
        public FormUpdateProducts()
        {
            InitializeComponent();
        }
        ProductController productController = new ProductController();
        CategoryController categoryController = new CategoryController();
        SqlConnection sqlConnection = new SqlConnection(Helpers.ConnectionTools.ConnectionString);
        
        private void FormUpdateProducts_Load(object sender, EventArgs e)
        {
            #region Fill Product List

            List<Products> productList = productController.GetProducts();
            cmbProductsList.DisplayMember = "ProductName";
            cmbProductsList.ValueMember = "ProductId";
            cmbProductsList.DataSource = productList;
            #endregion

            #region Fill Category List

            List<Category> categoriesList = categoryController.GetCategories();
            cmbCategories.DisplayMember = "CategoryName";
            cmbCategories.ValueMember = "CategoryId";
            cmbCategories.DataSource = categoriesList;
            #endregion

            #region Fill Supplier List

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

        private void btnShowProductDetails_Click(object sender, EventArgs e)
        {
            List<Products> productList = productController.GetProducts();
            //find the selected product
            foreach (var item in productList)
            {
                if(Convert.ToInt32(cmbProductsList.SelectedValue) == item.ProductId)
                {
                    cmbSuppliers.SelectedValue = item.SupplierId;
                    cmbCategories.SelectedValue = item.CategoryId;
                    txtQuantityOfUnit.Text = item.QuantityPerUnit;
                    txtUnitPrice.Text = item.UnitPrice.ToString();
                    txtUnitsInStock.Text = item.UnitsInStock.ToString();
                    txtUnitsOnOrder.Text = item.UnitsOnOrder.ToString();
                    txtReorderLevel.Text = item.ReorderLevel.ToString();
                    if (item.Discontinued)
                        chckDiscontinued.Checked = true;

                    //enabling all controls to permit the user to update
                    cmbSuppliers.Enabled = true;
                    cmbCategories.Enabled = true;
                    txtQuantityOfUnit.Enabled = true;
                    txtUnitPrice.Enabled = true;
                    txtUnitsInStock.Enabled = true;
                    txtUnitsOnOrder.Enabled = true;
                    txtReorderLevel.Enabled = true;
                    chckDiscontinued.Enabled = true;
                }
            }
        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            Products product = new Products();
            product.ProductId = Convert.ToInt32(cmbProductsList.SelectedValue);
            product.ProductName = cmbProductsList.DisplayMember;
            product.SupplierId = Convert.ToInt32(cmbSuppliers.SelectedValue);
            product.CategoryId = Convert.ToInt32(cmbCategories.SelectedValue);
            product.QuantityPerUnit = txtQuantityOfUnit.Text;
            product.UnitPrice = Convert.ToDecimal(txtUnitPrice.Text);
            product.UnitsInStock = Convert.ToInt32(txtUnitsInStock.Text);
            product.UnitsOnOrder = Convert.ToInt32(txtUnitsOnOrder.Text);
            product.ReorderLevel = Convert.ToInt32(txtReorderLevel.Text);
            product.Discontinued = chckDiscontinued.Checked;
            bool isUpdated = productController.UpdateProduct(product);
            if(isUpdated)
            MessageBox.Show("Updated");
        }
    }
}
