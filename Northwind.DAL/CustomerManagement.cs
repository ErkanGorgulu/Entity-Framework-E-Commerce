using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DAL
{
    public class CustomerManagement
    {
        NorthwindEntities northwind = new NorthwindEntities();
        public List<Customer> GetCustomers()
        {
            return northwind.Set<Customer>().ToList();
        }
        public Customer GetCustomerById(string customerID)
        {
            return northwind.Set<Customer>().FirstOrDefault(customer => customer.CustomerID == customerID);
        }
    }
}
