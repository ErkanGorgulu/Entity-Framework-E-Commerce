using Northwind.DAL;
using Northwind.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.BLL
{
    public class EmployeeController
    {
        EmployeeManagement employeeManagement;
        public EmployeeController()
        {
            employeeManagement = new EmployeeManagement();
        }
        public List<Employee> GetEmployees()
        {
            List<Employee> employees = employeeManagement.GetEmployees();
            return employees;
        }

        public bool AddEmployee(Employee employee)
        {
            bool isAdded = employeeManagement.AddEmployee(employee);
            return isAdded;
        }

        public bool UpdateEmployee(Employee employee)
        {
            bool isUpdated = employeeManagement.UpdateEmployee(employee);
            return isUpdated;
        }

        public bool DeleteEmployee(Employee employee)
        {
            bool isDeleted = employeeManagement.DeleteEmployee(employee);
            return isDeleted;
        }
    }
}
