using Northwind.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.BLL
{
    public class OrderDetailController
    {
        OrderDetailManagement orderDetailManagement = new OrderDetailManagement();
        public bool AddOrderDetail(Order_Detail order_Detail)
        {
            return orderDetailManagement.AddOrderDetail(order_Detail);
        }
    }
}
