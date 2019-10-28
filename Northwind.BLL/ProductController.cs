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


        public List<Products> GetProducts()
        {
            List<Products> products = productManagement.GetProducts();
            return products;
        }

        public bool AddProduct(Products products)
        {
            bool isAdded = productManagement.AddProduct(products);
            return isAdded;
        }

        public bool UpdateProduct(Products products)
        {
            bool isUpdated = productManagement.UpdateProduct(products);
            return isUpdated;
        }

        public bool DeleteProduct(Products products)
        {
            bool isDeleted = productManagement.DeleteProduct(products);
            return isDeleted;
        }
    }
}
