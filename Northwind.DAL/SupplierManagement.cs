using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DAL
{
    public class SupplierManagement
    {
        NorthwindEntities northwind = new NorthwindEntities();
        public List<Supplier> GetSuppliers()
        {
            var suppliers = northwind.Set<Supplier>().ToList();
            northwind.SaveChanges();
            return suppliers;
        }
    }
}
