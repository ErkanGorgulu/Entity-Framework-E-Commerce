using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DAL
{
    public class OrderManagement
    {
        NorthwindEntities northwind = new NorthwindEntities();
        public List<Order> GetOrderList()
        {
            var orderList = northwind.Set<Order>().ToList();
            foreach (Order order in orderList)
            {
                var customer = northwind.Set<Customer>().FirstOrDefault(c => c.CustomerID == order.CustomerID);
                order.CustomerCompany = customer.CompanyName;
                var employee = northwind.Set<Employee>().FirstOrDefault(e => e.EmployeeID == order.EmployeeID);
                order.EmployeeName = $"{employee.FirstName} {employee.LastName}";
                var shipVia = northwind.Set<Shipper>().FirstOrDefault(s => s.ShipperID == order.ShipVia);
                order.ShipperCompany = shipVia.CompanyName;
            }
            return orderList;
        }

        public Order AddOrder(Order order)
        {
            northwind.Set<Order>().Add(order);
            northwind.SaveChanges();
            return order;
        }
    }
}
