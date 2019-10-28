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
            if (dataReader.HasRows)
            {
                while (dataReader.Read())
                {
                    Employee employee = new Employee();
                    employee.EmployeeID = Convert.ToInt32(dataReader["EmployeeID"].ToString());
                    employee.FirstName = dataReader["FirstName"].ToString();
                    employee.LastName = dataReader["LastName"].ToString();
                    employee.Title = dataReader["Title"].ToString();
                    employee.TitleOfCourtesy = dataReader["TitleOfCourtesy"].ToString();
                    var dateFormat = dataReader["BirthDate"];
                    employee.BirthDate = (DateTime)dateFormat;
                    dateFormat = dataReader["HireDate"];
                    employee.HireDate = (DateTime)dateFormat;
                    employee.Adress = dataReader["Address"].ToString();
                    employee.City = dataReader["City"].ToString();
                    employee.Region = dataReader["Region"].ToString();
                    employee.PostalCode = dataReader["PostalCode"].ToString();
                    employee.Country = dataReader["Country"].ToString();
                    employee.HomePhone = dataReader["HomePhone"].ToString();
                    employee.Extension = dataReader["Extension"].ToString();
                    employee.Notes = dataReader["Notes"].ToString();
                    int reportsToValue;
                    Int32.TryParse(dataReader["ReportsTo"].ToString(),out reportsToValue);
                    employee.ReportsTo = reportsToValue;
                    //Index 16 is ReportsToText value for ReportsTo
                    employee.ReportsToText = dataReader[16].ToString();
                    employees.Add(employee);
                }
            }
            sqlConnection.Close();

            return employees;
        }
    }
}
