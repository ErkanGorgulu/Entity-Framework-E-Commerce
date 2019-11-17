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
        NorthwindEntities northwind = new NorthwindEntities();
        public List<Employee> GetEmployees()
        {
            return northwind.Set<Employee>().ToList();
        }
    }
}
#region ADO.NET option

//List Employees
//Add Employee
//Update Employee
//Delete Employee
//SqlConnection sqlConnection;
//public EmployeeManagement()
//{
//    sqlConnection = new SqlConnection(Helpers.ConnectionTools.ConnectionString);
//}
//public List<Employee> GetEmployees()
//{
//    string sqlQuery = @"SELECT
//                         E.EmployeeID
//                         ,E.LastName
//                         ,E.FirstName
//                         ,E.Title
//                         ,E.TitleOfCourtesy
//                         ,E.BirthDate
//                         ,E.HireDate
//                         ,E.Address
//                         ,E.City
//                         ,E.Region
//                         ,E.PostalCode
//                         ,E.Country
//                         ,E.HomePhone
//                         ,E.Extension
//                         ,E.Notes
//                         ,E.ReportsTo
//                         ,(SELECT ER.FirstName + ' ' + ER.LastName FROM Employees AS [ER] WHERE E.ReportsTo = ER.EmployeeID ) AS [ReportsToText]
//                            ,E.FirstName + ' ' + E.LastName + ' - ' + E.Title AS [NameWithTitle]

//                          FROM 
//                           Employees AS [E]";
//    SqlCommand sqlCommand = new SqlCommand(sqlQuery,sqlConnection);
//    if(sqlConnection.State == System.Data.ConnectionState.Closed)
//    {
//        sqlConnection.Open();
//    }
//    SqlDataReader dataReader = sqlCommand.ExecuteReader();
//    List<Employee> employees = new List<Employee>();
//    if (dataReader.HasRows)
//    {
//        while (dataReader.Read())
//        {
//            Employee employee = new Employee();
//            employee.EmployeeID = Convert.ToInt32(dataReader["EmployeeID"].ToString());
//            employee.FirstName = dataReader["FirstName"].ToString();
//            employee.LastName = dataReader["LastName"].ToString();
//            employee.Title = dataReader["Title"].ToString();
//            employee.TitleOfCourtesy = dataReader["TitleOfCourtesy"].ToString();
//            var dateFormat = dataReader["BirthDate"];
//            employee.BirthDate = (DateTime)dateFormat;
//            dateFormat = dataReader["HireDate"];
//            employee.HireDate = (DateTime)dateFormat;
//            employee.Address = dataReader["Address"].ToString();
//            employee.City = dataReader["City"].ToString();
//            employee.Region = dataReader["Region"].ToString();
//            employee.PostalCode = dataReader["PostalCode"].ToString();
//            employee.Country = dataReader["Country"].ToString();
//            employee.HomePhone = dataReader["HomePhone"].ToString();
//            employee.Extension = dataReader["Extension"].ToString();
//            employee.Notes = dataReader["Notes"].ToString();
//            int reportsToValue;
//            Int32.TryParse(dataReader["ReportsTo"].ToString(),out reportsToValue);
//            employee.ReportsTo = reportsToValue;
//            //Index 16 is ReportsToText value for ReportsTo
//            employee.ReportsToText = dataReader[16].ToString();
//            employee.NameWithTitle = dataReader[17].ToString();
//            employees.Add(employee);
//        }
//    }
//    sqlConnection.Close();

//    return employees;
//}

//        public bool AddEmployee(Employee employee)
//        {
//            string sqlQuery = @"INSERT INTO Employees (FirstName,LastName,Title,TitleOfCourtesy,BirthDate,HireDate,Address,City,Region,PostalCode,Country,HomePhone,Extension,Notes,ReportsTo)
//	            VALUES (@firstname,@lastname,@title,@titleofcourtesy,@birthdate,@hiredate,@address,@city,@region,@postalcode,@country,@homephone,@extension,@notes,@reportsto)";
//            SqlCommand sqlCommand = new SqlCommand(sqlQuery, sqlConnection);
//            sqlCommand.Parameters.AddWithValue("@firstname", employee.FirstName);
//            sqlCommand.Parameters.AddWithValue("@lastname", employee.LastName);
//            sqlCommand.Parameters.AddWithValue("@title", employee.Title);
//            sqlCommand.Parameters.AddWithValue("@titleofcourtesy", employee.TitleOfCourtesy);
//            sqlCommand.Parameters.AddWithValue("@birthdate", employee.BirthDate);
//            sqlCommand.Parameters.AddWithValue("@hiredate", employee.HireDate);
//            sqlCommand.Parameters.AddWithValue("@address", employee.Address);
//            sqlCommand.Parameters.AddWithValue("@city", employee.City);
//            sqlCommand.Parameters.AddWithValue("@region", employee.Region);
//            sqlCommand.Parameters.AddWithValue("@postalcode", employee.PostalCode);
//            sqlCommand.Parameters.AddWithValue("@country", employee.Country);
//            sqlCommand.Parameters.AddWithValue("@homephone", employee.HomePhone);
//            sqlCommand.Parameters.AddWithValue("@extension", employee.Extension);
//            sqlCommand.Parameters.AddWithValue("@notes", employee.Notes);
//            sqlCommand.Parameters.AddWithValue("@reportsto", employee.ReportsTo);

//            if(sqlConnection.State == System.Data.ConnectionState.Closed)
//            {
//                sqlConnection.Open();
//            }

//            bool isAdded = sqlCommand.ExecuteNonQuery() > 0 ? true : false;
//            sqlConnection.Close();
//            return isAdded;
//        }

//        public bool UpdateEmployee(Employee employee)
//        {
//            string sqlQuery = @"UPDATE Employees
//            SET FirstName = @firstname, LastName = @lastname, Title = @title, TitleOfCourtesy = @titleofcourtesy, BirthDate = @birthdate, HireDate = @hiredate, Address = @address,City =  @city,
//            Region = @region,PostalCode = @postalcode,Country =  @country,HomePhone = @homephone,Extension =  @extension,Notes = @notes,ReportsTo = @reportsto
//            WHERE EmployeeID = @employeeid";
//            SqlCommand sqlCommand = new SqlCommand(sqlQuery, sqlConnection);
//            sqlCommand.Parameters.AddWithValue("@employeeid", employee.EmployeeID);
//            sqlCommand.Parameters.AddWithValue("@firstname", employee.FirstName);
//            sqlCommand.Parameters.AddWithValue("@lastname", employee.LastName);
//            sqlCommand.Parameters.AddWithValue("@title", employee.Title);
//            sqlCommand.Parameters.AddWithValue("@titleofcourtesy", employee.TitleOfCourtesy);
//            sqlCommand.Parameters.AddWithValue("@birthdate", employee.BirthDate);
//            sqlCommand.Parameters.AddWithValue("@hiredate", employee.HireDate);
//            sqlCommand.Parameters.AddWithValue("@address", employee.Address);
//            sqlCommand.Parameters.AddWithValue("@city", employee.City);
//            sqlCommand.Parameters.AddWithValue("@region", employee.Region);
//            sqlCommand.Parameters.AddWithValue("@postalcode", employee.PostalCode);
//            sqlCommand.Parameters.AddWithValue("@country", employee.Country);
//            sqlCommand.Parameters.AddWithValue("@homephone", employee.HomePhone);
//            sqlCommand.Parameters.AddWithValue("@extension", employee.Extension);
//            sqlCommand.Parameters.AddWithValue("@notes", employee.Notes);
//            sqlCommand.Parameters.AddWithValue("@reportsto", employee.ReportsTo);

//            if (sqlConnection.State == System.Data.ConnectionState.Closed)
//            {
//                sqlConnection.Open();
//            }

//            bool isUpdated = sqlCommand.ExecuteNonQuery() > 0 ? true : false;
//            sqlConnection.Close();
//            return isUpdated;
//        }

//        public bool DeleteEmployee(Employee employee)
//        {
//            string sqlQuery = @"DELETE FROM Employees WHERE EmployeeID = @employeeid";
//            SqlCommand sqlCommand = new SqlCommand(sqlQuery, sqlConnection);
//            sqlCommand.Parameters.AddWithValue("@employeeid", employee.EmployeeID);
//            if(sqlConnection.State == System.Data.ConnectionState.Closed)
//            {
//                sqlConnection.Open();
//            }

//            bool isDeleted = sqlCommand.ExecuteNonQuery() > 0 ? true : false;
//            return isDeleted;
//        }
//    }
//}
#endregion

