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
    public partial class FormUpdateProducts : Form
    {
        public FormUpdateProducts()
        {
            InitializeComponent();
        }
        ProductController productController = new ProductController();
        CategoryController categoryController = new CategoryController();
        SupplierController supplierController = new SupplierController();
        //SqlConnection sqlConnection = new SqlConnection(Helpers.ConnectionTools.ConnectionString);
        List<Product> productList = new List<Product>();

        private void FormUpdateProducts_Load(object sender, EventArgs e)
        {
            #region Fill Product List

            FillProductList();
            #endregion

            #region Fill Category List

            List<Category> categoriesList = categoryController.GetCategories();
            cmbCategories.DisplayMember = "CategoryName";
            cmbCategories.ValueMember = "CategoryId";
            cmbCategories.DataSource = categoriesList;
            #endregion

            #region Fill Supplier List ADO.NET option

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
            cmbSuppliers.DataSource = supplierController.GetSuppliers();
            cmbSuppliers.ValueMember = "SupplierId";
            cmbSuppliers.DisplayMember = "CompanyName";
        }


        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            decimal unitPrice;
            short unitsInStock, unitsOnOrder, reorderLevel;
            bool isUnitPriceValid = Decimal.TryParse(txtUnitPrice.Text, out unitPrice);
            if (!isUnitPriceValid)
                unitPrice = -1;
            bool isUnitsInStockValid = short.TryParse(txtUnitsInStock.Text, out unitsInStock);
            if (!isUnitsInStockValid)
                unitsInStock = -1;
            bool isUnitsOnOrderValid = short.TryParse(txtUnitsOnOrder.Text, out unitsOnOrder);
            if (!isUnitsOnOrderValid)
                unitsOnOrder = -1;
            bool isReorderLevelValid = short.TryParse(txtReorderLevel.Text, out reorderLevel);
            if (!isReorderLevelValid)
                reorderLevel = -1;


            Product product = productController.GetProductById(Convert.ToInt32(cmbProductsList.SelectedValue));

            product.SupplierID = Convert.ToInt32(cmbSuppliers.SelectedValue);
            product.CategoryID = Convert.ToInt32(cmbCategories.SelectedValue);
            product.QuantityPerUnit = txtQuantityOfUnit.Text;
            product.UnitPrice = unitPrice;
            product.UnitsInStock = unitsInStock;
            product.UnitsOnOrder = unitsOnOrder;
            product.ReorderLevel = reorderLevel;
            product.Discontinued = chckDiscontinued.Checked;
            ReturnMessage isUpdated = productController.UpdateProduct(product);
            MessageBox.Show(isUpdated.Value);
            if (isUpdated.isSuccessful)
            {
                DisableControls();
                //clear every textbox if updating is successful
                ClearTextBoxes();
            }
            }

        private void ClearTextBoxes()
        {
            foreach (Control control in Controls)
            {
                if (control is TextBox)
                    control.Text = string.Empty;
            }
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.ProductID = Convert.ToInt32(cmbProductsList.SelectedValue);
            product.ProductName = cmbProductsList.GetItemText(cmbProductsList.SelectedItem);
            ReturnMessage isDeleted = productController.DeleteProduct(product);
            
            MessageBox.Show(isDeleted.Value);
            if (isDeleted.isSuccessful)
            {
                ClearTextBoxes();
                FillProductList();
                DisableControls();
            }
            
        }
        //fetches product details when a product is selected from the ComboBox
        private void CmbProductsList_SelectionChangeCommitted(object sender, EventArgs e)
        {
            List<Product> productList = productController.GetProducts();
            //find the selected product
            foreach (var item in productList)
            {
                if (Convert.ToInt32(cmbProductsList.SelectedValue) == item.ProductID)
                {
                    cmbSuppliers.SelectedValue = item.SupplierID;
                    cmbCategories.SelectedValue = item.CategoryID;
                    txtQuantityOfUnit.Text = item.QuantityPerUnit;
                    txtUnitPrice.Text = item.UnitPrice.ToString();
                    txtUnitsInStock.Text = item.UnitsInStock.ToString();
                    txtUnitsOnOrder.Text = item.UnitsOnOrder.ToString();
                    txtReorderLevel.Text = item.ReorderLevel.ToString();
                    if (item.Discontinued)
                        chckDiscontinued.Checked = true;
                    else
                        chckDiscontinued.Checked = false;                    

                    //enabling all controls to permit the user to update
                    EnableControls();
                }
            }
        }        
        private void FillProductList()
        {
            cmbProductsList.DataSource = null;
            productList = productController.GetProducts();
            cmbProductsList.DataSource = productList;
            cmbProductsList.DisplayMember = "ProductName";
            cmbProductsList.ValueMember = "ProductId";            
        }        
        private void EnableControls()
        {
            cmbSuppliers.Enabled = true;
            cmbCategories.Enabled = true;
            txtQuantityOfUnit.Enabled = true;
            txtUnitPrice.Enabled = true;
            txtUnitsInStock.Enabled = true;
            txtUnitsOnOrder.Enabled = true;
            txtReorderLevel.Enabled = true;
            chckDiscontinued.Enabled = true;
        }
        private void DisableControls()
        {
            cmbSuppliers.Enabled = false;
            cmbCategories.Enabled = false;
            txtQuantityOfUnit.Enabled = false;
            txtUnitPrice.Enabled = false;
            txtUnitsInStock.Enabled = false;
            txtUnitsOnOrder.Enabled = false;
            txtReorderLevel.Enabled = false;
            chckDiscontinued.Enabled = false;
        }

    }
}
