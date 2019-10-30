using Northwind.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Northwind.DAL;

namespace Northwind.BLL
{
    public class ProductController
    {
              
        ProductManagement productManagement = new ProductManagement();


        public List<Product> GetProducts()
        {
            List<Product> products = productManagement.GetProducts();
            return products;
        }

        public bool AddProduct(Product products)
        {
            bool isAdded = productManagement.AddProduct(products);
            return isAdded;
        }

        public bool UpdateProduct(Product products)
        {
            bool isUpdated = productManagement.UpdateProduct(products);
            return isUpdated;
        }

        public bool DeleteProduct(Product products)
        {
            bool isDeleted = productManagement.DeleteProduct(products);
            return isDeleted;
        }
    }
}
