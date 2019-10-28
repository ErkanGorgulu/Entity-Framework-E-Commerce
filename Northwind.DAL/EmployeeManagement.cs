using Northwind.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DAL
{
    public class EmployeeManagement
    {
        //List Employees
        //Add Employee
        //Update Employee
        //Delete Employee
        SqlConnection sqlConnection;
        public EmployeeManagement()
        {
            sqlConnection = new SqlConnection(Helpers.ConnectionTools.ConnectionString);
        }
        public List<Employee> GetEmployees()
        {
            string sqlQuery = @"SELECT
	                                E.EmployeeID
	                                ,E.LastName
	                                ,E.FirstName
	                                ,E.Title
	                                ,E.TitleOfCourtesy
	                                ,E.BirthDate
	                                ,E.HireDate
	                                ,E.Address
	                                ,E.City
	                                ,E.Region
	                                ,E.PostalCode
	                                ,E.Country
	                                ,E.HomePhone
	                                ,E.Extension
	                                ,E.Notes
	                                ,E.ReportsTo
	                                ,(SELECT ER.FirstName + ' ' + ER.LastName FROM Employees AS [ER] WHERE E.ReportsTo = ER.EmployeeID ) AS [ReportsTo]
		                                FROM 
			                                Employees AS [E]";
            SqlCommand sqlCommand = new SqlCommand(sqlQuery,sqlConnection);
            if(sqlConnection.State == System.Data.ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
            SqlDataReader dataReader = sqlCommand.ExecuteReader();
            List<Employee> employees = new List<Employee>();
            Employee employee = new Employee();
            if (dataReader.HasRows)
            {
                while (dataReader.Read())
                {
                    employee.EmployeeID = Convert.ToInt32(dataReader["EmployeeID"].ToString());
                    employee.FirstName = dataReader["FirstName"].ToString();
                    employee.LastName = dataReader["LastName"].ToString();
                    employee.Title = dataReader["Title"].ToString();
                    employee.TitleOfCourtesy = dataReader["TitleOfCourtesy"].ToString();
                    var dateFormat = Convert.ToString(dataReader["BirthDate"]);
                    //employee.BirthDate = (DateTime)(dataReader["BirthDate"].ToString());
                }
            }

            return employees;
        }
    }
}
