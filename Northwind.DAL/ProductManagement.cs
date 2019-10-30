using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Northwind.Entities;

namespace Northwind.DAL
{
    public class ProductManagement
    {
        SqlConnection sqlConnection;
        public ProductManagement()
        {
            sqlConnection = new SqlConnection(Northwind.Helpers.ConnectionTools.ConnectionString);
        }

        //getProducts
        public List<Product> GetProducts()
        {
            List<Product> productsList = new List<Product>();
            string sqlQuery = "EXEC SP_GetProducts";
            #region With Select Query
            /* 
             * sqlQuery = "SELECT
	                            P.ProductID
	                            ,P.ProductName
	                            ,S.CompanyName AS [SupplierName]
	                            ,C.CategoryName
	                            ,P.QuantityPerUnit
	                            ,P.UnitPrice
	                            ,P.UnitsInStock
	                            ,P.UnitsOnOrder
	                            ,P.ReorderLevel
	                            ,P.Discontinued
		                            FROM
			                            Products AS [P]
				                            INNER JOIN Suppliers AS [S] ON S.SupplierID = P.SupplierID
				                            INNER JOIN Categories AS [C] ON P.CategoryID = C.CategoryID"
             */
            #endregion

            SqlCommand sqlCommand = new SqlCommand(sqlQuery,sqlConnection);
            sqlCommand.CommandText = "SP_GetProducts";
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            if(sqlConnection.State == System.Data.ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
            SqlDataReader sql = sqlCommand.ExecuteReader();
            if(sql.HasRows)
            {
                while (sql.Read())
                {
                    Product products = new Product
                    {
                        ProductId = Convert.ToInt32(sql["ProductID"]),
                        ProductName = sql["ProductName"].ToString(),
                        SupplierName = sql["SupplierName"].ToString(),
                        CategoryName = sql["CategoryName"].ToString(),
                        QuantityPerUnit = sql["QuantityPerUnit"].ToString(),
                        UnitPrice = Convert.ToDecimal(sql["UnitPrice"]),
                        UnitsInStock = Convert.ToInt32(sql["UnitsInStock"]),
                        UnitsOnOrder = Convert.ToInt32(sql["UnitsOnOrder"]),
                        ReorderLevel = Convert.ToInt32(sql["ReorderLevel"]),
                        Discontinued = Convert.ToByte(sql["Discontinued"]) == 1 ? true : false,
                        CategoryId = Convert.ToInt32(sql["CategoryID"]),
                        SupplierId = Convert.ToInt32(sql["SupplierID"])
                    };
                    productsList.Add(products);
                }
            }
            sqlConnection.Close();
            return productsList;
        }

        //addproduct
        public bool AddProduct(Product products)
        {
            string sqlQuery = "INSERT INTO Products (ProductName,SupplierID,CategoryID,QuantityPerUnit,UnitPrice,UnitsInStock,UnitsOnOrder,ReorderLevel,Discontinued) VALUES(@productname, @supplierid, @categoryid, @quantityperunit, @unitprice, @unitsinstock, @unitsonorder, @reorderlevel, @discontinued)";
            SqlCommand sqlCommand = new SqlCommand(sqlQuery, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@productname", products.ProductName);
            sqlCommand.Parameters.AddWithValue("@supplierid", products.SupplierId);
            sqlCommand.Parameters.AddWithValue("@categoryid", products.CategoryId);
            sqlCommand.Parameters.AddWithValue("@quantityperunit", products.QuantityPerUnit);
            sqlCommand.Parameters.AddWithValue("@unitprice", products.UnitPrice);
            sqlCommand.Parameters.AddWithValue("@unitsinstock", products.UnitsInStock);
            sqlCommand.Parameters.AddWithValue("@unitsonorder", products.UnitsOnOrder);
            sqlCommand.Parameters.AddWithValue("@reorderlevel", products.ReorderLevel);
            if(products.Discontinued)
                sqlCommand.Parameters.AddWithValue("@discontinued", 1);
            else
                sqlCommand.Parameters.AddWithValue("@discontinued", 0);
            if(sqlConnection.State == System.Data.ConnectionState.Closed)
            {
                sqlConnection.Open();
            }

            bool isAdded = sqlCommand.ExecuteNonQuery() > 0 ? true : false;

            return isAdded;
        }

        //updateproduct
        public bool UpdateProduct(Product products)
        {
            string sqlQuery = "EXEC SP_UpdateProduct @productname, @supplierId, @categoryid, @quantityperunit, @unitprice, @unitsinstock, @unitsonorder, @reorderlevel, @discontinued, @productid";
            SqlCommand sqlCommand = new SqlCommand(sqlQuery, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@productid", products.ProductId);
            sqlCommand.Parameters.AddWithValue("@productname", products.ProductName);
            sqlCommand.Parameters.AddWithValue("@supplierid", products.SupplierId);
            sqlCommand.Parameters.AddWithValue("@categoryid", products.CategoryId);
            sqlCommand.Parameters.AddWithValue("@quantityperunit", products.QuantityPerUnit);
            sqlCommand.Parameters.AddWithValue("@unitprice", products.UnitPrice);
            sqlCommand.Parameters.AddWithValue("@unitsinstock", products.UnitsInStock);
            sqlCommand.Parameters.AddWithValue("@unitsonorder", products.UnitsOnOrder);
            sqlCommand.Parameters.AddWithValue("@reorderlevel", products.ReorderLevel);
            if (products.Discontinued)
                sqlCommand.Parameters.AddWithValue("@discontinued", 1);
            else
                sqlCommand.Parameters.AddWithValue("@discontinued", 0);
            if (sqlConnection.State == System.Data.ConnectionState.Closed)
            {
                sqlConnection.Open();
            }

            bool isUpdated = sqlCommand.ExecuteNonQuery() > 0 ? true : false;

            return isUpdated;
        }

        //deleteproduct
        public bool DeleteProduct(Product products)
        {
            string sqlQuery = "EXEC SP_DeleteProduct @productid";
            SqlCommand sqlCommand = new SqlCommand(sqlQuery, sqlConnection);
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCommand.CommandText = "SP_DeleteProduct";
            sqlCommand.Parameters.AddWithValue("@productid", products.ProductId);
            if(sqlConnection.State == System.Data.ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
            bool isDeleted = sqlCommand.ExecuteNonQuery() > 0 ? true : false;
            sqlConnection.Close();
            return isDeleted;
        }
    }
}
