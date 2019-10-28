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
    }
}
