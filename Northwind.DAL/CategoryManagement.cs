//using Northwind.Entities;
using Northwind.Entities;
using Northwind.Helpers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

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

        public List<Category> GetCategoryList()
        {
            List<Category> categories = new List<Category>();

            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Categories", sqlConnection);

            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
            }

            SqlDataReader dr = sqlCommand.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Category category = new Category
                    {
                        CategoryId = Convert.ToInt32(dr["CategoryId"]),
                        CategoryName = dr["CategoryName"].ToString(),
                        CategoryDescription = dr["Description"].ToString()
                    };
                    categories.Add(category);
                }
            }
            sqlConnection.Close();
            return categories;
        }

        public bool AddCategory(Category category)
        {
            string addQuery = @"INSERT INTO Categories (CategoryName, Description) VALUES (@categoryname, @categorydescription)";

            SqlCommand sqlCommand = new SqlCommand(addQuery, sqlConnection);
            
            sqlCommand.Parameters.AddWithValue("@categoryname", category.CategoryName);
            sqlCommand.Parameters.AddWithValue("@categorydescription", category.CategoryDescription);

            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
            }

            bool isAdded = sqlCommand.ExecuteNonQuery() > 0 ? true : false;
            sqlConnection.Close();
            return isAdded;
        }

        public bool UpdateCategory(Category category)
        {
            string sqlQuery = "EXEC SP_UpdateCategory @categoryname, @description, @categoryid";
            SqlCommand sqlCommand = new SqlCommand(sqlQuery, sqlConnection);
            sqlCommand.CommandText = "SP_UpdateCategory";
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@categoryname", category.CategoryName);
            sqlCommand.Parameters.AddWithValue("@description", category.CategoryDescription);
            sqlCommand.Parameters.AddWithValue("@categoryid", category.CategoryId);
            if(sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
            bool isUpdated = sqlCommand.ExecuteNonQuery() > 0 ? true : false;
            sqlConnection.Close();
            return isUpdated;
        }

    }
}