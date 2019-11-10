using Northwind.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.BLL
{
    public class SupplierController
    {        
        SupplierManagement supplierManagement = new SupplierManagement();
        public List<Supplier> GetSuppliers()
        {
            var suppliers = supplierManagement.GetSuppliers();
            
            return suppliers;
        }
    }
}
