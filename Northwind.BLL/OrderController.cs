using Northwind.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.BLL
{
    public class OrderController
    {
        OrderManagement orderManagement = new OrderManagement();
        public List<Order> GetOrderList()
        {
            return orderManagement.GetOrderList();
        }
    }
}
