using Northwind.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.BLL
{
    public class CustomerController
    {
        CustomerManagement customerManagement = new CustomerManagement();

        public List<Customer> GetCustomers()
        {
            return customerManagement.GetCustomers();
        }

    }
}
