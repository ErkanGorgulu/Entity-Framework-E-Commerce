using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DAL
{
    public class ShipperManagement
    {
        NorthwindEntities northwind = new NorthwindEntities();
        public List<Shipper> GetShippers()
        {
            return northwind.Set<Shipper>().ToList();
        }
    }
}
