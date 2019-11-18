using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DAL
{
    public class OrderDetailManagement
    {
        NorthwindEntities northwind = new NorthwindEntities();
        public bool AddOrderDetail(Order_Detail order_Detail)
        {
            northwind.Set<Order_Detail>().Add(order_Detail);
            int isAdded = northwind.SaveChanges();
            return isAdded > 0 ? true : false;
        }
    }
}
