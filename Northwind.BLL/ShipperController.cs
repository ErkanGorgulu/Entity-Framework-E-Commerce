using Northwind.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.BLL
{
    public class ShipperController
    {
        ShipperManagement shipperManagement = new ShipperManagement();
        public List<Shipper> GetShippers()
        {
            return shipperManagement.GetShippers();
        }
    }
}
