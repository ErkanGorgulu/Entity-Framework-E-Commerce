//using Northwind.Entities;
using Northwind.Entities;
using Northwind.Helpers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace Northwind.DAL
{
    public class CategoryManagement
    {
        //SqlConnection sqlConnection = new SqlConnection();
        SqlConnection sqlConnection;

        public CategoryManagement()
        {
            if (sqlConnection == null)
            {
                sqlConnection = new SqlConnection(ConnectionTools.ConnectionString);
            }

            #region OTHER CONNECTIONS

            //sqlConnection = new SqlConnection()
            //{
            //    ConnectionString = Northwind.Helpers.ConnectionTools.ConnectionString;
            //};
            //sqlConnection = new SqlConnection(Northwind.Helpers.ConnectionTools.ConnectionString);

            #endregion
        }
        NorthwindEntities northwind = new NorthwindEntities();
        public List<Category> GetCategoryList()
        {
            List<Category> categories = northwind.Set<Category>().ToList();
            northwind.SaveChanges();
            return categories;
            #region Ado.net option

            //List<Category> categories = new List<Category>();

            //SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Categories", sqlConnection);

            //if (sqlConnection.State == ConnectionState.Closed)
            //{
            //    sqlConnection.Open();
            //}

            //SqlDataReader dr = sqlCommand.ExecuteReader();

            //if (dr.HasRows)
            //{
            //    while (dr.Read())
            //    {
            //        Category category = new Category
            //        {
            //            CategoryID = Convert.ToInt32(dr["CategoryId"]),
            //            CategoryName = dr["CategoryName"].ToString(),
            //            Description = dr["Description"].ToString()
            //        };
            //        categories.Add(category);
            //    }
            //}
            //sqlConnection.Close();
            //return categories;
            #endregion

        }

        public bool AddCategory(Category category)
        {
            northwind.Set<Category>().Add(category);
            var isAdded = northwind.SaveChanges();
            if(isAdded>0)
                return true;
            else
                return false;            
            #region ADO.NET option


            //string addQuery = @"INSERT INTO Categories (CategoryName, Description) VALUES (@categoryname, @categorydescription)";

            //SqlCommand sqlCommand = new SqlCommand(addQuery, sqlConnection);

            //sqlCommand.Parameters.AddWithValue("@categoryname", category.CategoryName);
            //sqlCommand.Parameters.AddWithValue("@categorydescription", category.Description);

            //if (sqlConnection.State == ConnectionState.Closed)
            //{
            //    sqlConnection.Open();
            //}

            //bool isAdded = sqlCommand.ExecuteNonQuery() > 0 ? true : false;
            //sqlConnection.Close();
            //return isAdded;
            #endregion

        }

        public bool UpdateCategory(Category category)
        {
            var updatedCategory = northwind.Set<Category>().FirstOrDefault<Category>(x => x.CategoryID == category.CategoryID);
            updatedCategory.CategoryName = category.CategoryName;
            updatedCategory.Description = category.Description;
            updatedCategory.Picture = category.Picture;
            int isUpdated = northwind.SaveChanges();
            if (isUpdated > 0)
                return true;
            else
                return false;
            #region ADO.NET option


            //string sqlQuery = "EXEC SP_UpdateCategory @categoryname, @description, @categoryid";
            //SqlCommand sqlCommand = new SqlCommand(sqlQuery, sqlConnection);
            //sqlCommand.CommandText = "SP_UpdateCategory";
            //sqlCommand.CommandType = CommandType.StoredProcedure;
            //sqlCommand.Parameters.AddWithValue("@categoryname", category.CategoryName);
            //sqlCommand.Parameters.AddWithValue("@description", category.Description);
            //sqlCommand.Parameters.AddWithValue("@categoryid", category.CategoryID);
            //if(sqlConnection.State == ConnectionState.Closed)
            //{
            //    sqlConnection.Open();
            //}
            //bool isUpdated = sqlCommand.ExecuteNonQuery() > 0 ? true : false;
            //sqlConnection.Close();
            //return isUpdated;
            #endregion
        }

        public bool DeleteCategory(Category category)
        {
            var deletedCategory = northwind.Set<Category>().Find(category.CategoryID);
            if(deletedCategory != null)
            {
                northwind.Set<Category>().Remove(deletedCategory);
            }
            int isDeleted = northwind.SaveChanges();
            if (isDeleted > 0)
                return true;
            else
                return false;
            #region ADO.NET option

            //string sqlQuery = "EXEC SP_DeleteCategory @categoryid";
            //SqlCommand sqlCommand = new SqlCommand(sqlQuery, sqlConnection);
            //sqlCommand.CommandText = "SP_DeleteCategory";
            //sqlCommand.CommandType = CommandType.StoredProcedure;
            //sqlCommand.Parameters.AddWithValue("categoryid", category.CategoryID);
            //if(sqlConnection.State == ConnectionState.Closed)
            //{
            //    sqlConnection.Open();
            //}
            //bool isDeleted = sqlCommand.ExecuteNonQuery() > 0 ? true : false;
            //sqlConnection.Close();
            //return isDeleted;
            #endregion

        }
        public bool IsCategoryContained(Category category)
        {
            var isCategoryContained = northwind.Set<Category>().FirstOrDefault(cat => cat.CategoryName == category.CategoryName);
            if (isCategoryContained == null)
                return false;
            else
                return true;
        }

    }
}