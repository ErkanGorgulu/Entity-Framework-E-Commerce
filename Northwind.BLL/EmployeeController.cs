﻿using Northwind.DAL;
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
    }
}
