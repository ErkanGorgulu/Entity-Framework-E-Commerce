using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Northwind.Entities;
using Northwind.Helpers;

namespace Northwind.DAL
{
    public class ProductManagement
    {
        //SqlConnection sqlConnection;
        //public ProductManagement()
        //{
        //    sqlConnection = new SqlConnection(Northwind.Helpers.ConnectionTools.ConnectionString);
        //}
        NorthwindEntities northwind = new NorthwindEntities();
        ReturnMessage message = new ReturnMessage();
        //getProducts
        public List<Product> GetProducts()
        {
            List<Product> products = northwind.Set<Product>().ToList();
            var categories = northwind.Set<Category>().ToList();
            var suppliers = northwind.Set<Supplier>().ToList();
            foreach (Product product in products)
            {
                //get the supplier name to display on the form
                var supplier = suppliers.FirstOrDefault(sup => sup.SupplierID == product.SupplierID);
                product.SupplierName = supplier.CompanyName;
                //get the category name to display on the form
                var category = categories.FirstOrDefault(cat => cat.CategoryID == product.CategoryID);
                product.CategoryName = category.CategoryName;
            }
            return products;

            #region ADO.NET option

            //List<Product> productsList = new List<Product>();
            //string sqlQuery = "EXEC SP_GetProducts";
            //#region With Select Query
            ///* 
            // * sqlQuery = "SELECT
            //                 P.ProductID
            //                 ,P.ProductName
            //                 ,S.CompanyName AS [SupplierName]
            //                 ,C.CategoryName
            //                 ,P.QuantityPerUnit
            //                 ,P.UnitPrice
            //                 ,P.UnitsInStock
            //                 ,P.UnitsOnOrder
            //                 ,P.ReorderLevel
            //                 ,P.Discontinued
            //                  FROM
            //                   Products AS [P]
            //                    INNER JOIN Suppliers AS [S] ON S.SupplierID = P.SupplierID
            //                    INNER JOIN Categories AS [C] ON P.CategoryID = C.CategoryID"
            // */
            //#endregion

            //SqlCommand sqlCommand = new SqlCommand(sqlQuery,sqlConnection);
            //sqlCommand.CommandText = "SP_GetProducts";
            //sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            //if(sqlConnection.State == System.Data.ConnectionState.Closed)
            //{
            //    sqlConnection.Open();
            //}
            //SqlDataReader sql = sqlCommand.ExecuteReader();
            //if(sql.HasRows)
            //{
            //    while (sql.Read())
            //    {
            //        Product products = new Product
            //        {
            //            ProductID = Convert.ToInt32(sql["ProductID"]),
            //            ProductName = sql["ProductName"].ToString(),
            //            SupplierName = sql["SupplierName"].ToString(),
            //            CategoryName = sql["CategoryName"].ToString(),
            //            QuantityPerUnit = sql["QuantityPerUnit"].ToString(),
            //            UnitPrice = Convert.ToDecimal(sql["UnitPrice"]),
            //            UnitsInStock = Convert.ToInt16(sql["UnitsInStock"]),
            //            UnitsOnOrder = Convert.ToInt16(sql["UnitsOnOrder"]),
            //            ReorderLevel = Convert.ToInt16(sql["ReorderLevel"]),
            //            Discontinued = Convert.ToByte(sql["Discontinued"]) == 1 ? true : false,
            //            CategoryID = Convert.ToInt32(sql["CategoryID"]),
            //            SupplierID = Convert.ToInt32(sql["SupplierID"])
            //        };
            //        productsList.Add(products);
            //    }
            //}
            //sqlConnection.Close();
            //return productsList;
            #endregion
        }

        //addproduct
        public bool AddProduct(Product product)
        {
            northwind.Set<Product>().Add(product);
            var isAdded = northwind.SaveChanges();
            if (isAdded > 0)
                return true;
            else
                return false;

            #region ADO.NET option

            //string sqlQuery = "INSERT INTO Products (ProductName,SupplierID,CategoryID,QuantityPerUnit,UnitPrice,UnitsInStock,UnitsOnOrder,ReorderLevel,Discontinued) VALUES(@productname, @supplierid, @categoryid, @quantityperunit, @unitprice, @unitsinstock, @unitsonorder, @reorderlevel, @discontinued)";
            //SqlCommand sqlCommand = new SqlCommand(sqlQuery, sqlConnection);
            //sqlCommand.Parameters.AddWithValue("@productname", product.ProductName);
            //sqlCommand.Parameters.AddWithValue("@supplierid", product.SupplierID);
            //sqlCommand.Parameters.AddWithValue("@categoryid", product.CategoryID);
            //sqlCommand.Parameters.AddWithValue("@quantityperunit", product.QuantityPerUnit);
            //sqlCommand.Parameters.AddWithValue("@unitprice", product.UnitPrice);
            //sqlCommand.Parameters.AddWithValue("@unitsinstock", product.UnitsInStock);
            //sqlCommand.Parameters.AddWithValue("@unitsonorder", product.UnitsOnOrder);
            //sqlCommand.Parameters.AddWithValue("@reorderlevel", product.ReorderLevel);
            //if(product.Discontinued)
            //    sqlCommand.Parameters.AddWithValue("@discontinued", 1);
            //else
            //    sqlCommand.Parameters.AddWithValue("@discontinued", 0);
            //if(sqlConnection.State == System.Data.ConnectionState.Closed)
            //{
            //    sqlConnection.Open();
            //}

            //bool isAdded = sqlCommand.ExecuteNonQuery() > 0 ? true : false;

            //return isAdded;
            #endregion

        }

        //updateproduct
        public bool UpdateProduct(Product product)
        {
            return false;
            //string sqlQuery = "EXEC SP_UpdateProduct @productname, @supplierId, @categoryid, @quantityperunit, @unitprice, @unitsinstock, @unitsonorder, @reorderlevel, @discontinued, @productid";
            //SqlCommand sqlCommand = new SqlCommand(sqlQuery, sqlConnection);
            //sqlCommand.Parameters.AddWithValue("@productid", product.ProductID);
            //sqlCommand.Parameters.AddWithValue("@productname", product.ProductName);
            //sqlCommand.Parameters.AddWithValue("@supplierid", product.SupplierID);
            //sqlCommand.Parameters.AddWithValue("@categoryid", product.CategoryID);
            //sqlCommand.Parameters.AddWithValue("@quantityperunit", product.QuantityPerUnit);
            //sqlCommand.Parameters.AddWithValue("@unitprice", product.UnitPrice);
            //sqlCommand.Parameters.AddWithValue("@unitsinstock", product.UnitsInStock);
            //sqlCommand.Parameters.AddWithValue("@unitsonorder", product.UnitsOnOrder);
            //sqlCommand.Parameters.AddWithValue("@reorderlevel", product.ReorderLevel);
            //if (product.Discontinued)
            //    sqlCommand.Parameters.AddWithValue("@discontinued", 1);
            //else
            //    sqlCommand.Parameters.AddWithValue("@discontinued", 0);
            //if (sqlConnection.State == System.Data.ConnectionState.Closed)
            //{
            //    sqlConnection.Open();
            //}

            //bool isUpdated = sqlCommand.ExecuteNonQuery() > 0 ? true : false;

            //return isUpdated;
        }

        //deleteproduct
        public bool DeleteProduct(Product product)
        {
            return false;
            //string sqlQuery = "EXEC SP_DeleteProduct @productid";
            //SqlCommand sqlCommand = new SqlCommand(sqlQuery, sqlConnection);
            //sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            //sqlCommand.CommandText = "SP_DeleteProduct";
            //sqlCommand.Parameters.AddWithValue("@productid", product.ProductID);
            //if(sqlConnection.State == System.Data.ConnectionState.Closed)
            //{
            //    sqlConnection.Open();
            //}
            //bool isDeleted = sqlCommand.ExecuteNonQuery() > 0 ? true : false;
            //sqlConnection.Close();
            //return isDeleted;
        }
        public bool IsProductContained(Product product)
        {
            var isProductContained = northwind.Set<Product>().FirstOrDefault(prod => prod.ProductName == product.ProductName);
            if (isProductContained == null)
                return false;
            else
                return true;
        }
    }
}
