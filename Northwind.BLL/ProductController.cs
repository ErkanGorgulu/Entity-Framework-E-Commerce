using Northwind.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Northwind.DAL;
using Northwind.Helpers;

namespace Northwind.BLL
{
    public class ProductController
    {
              
        ProductManagement productManagement = new ProductManagement();

        ReturnMessage message = new ReturnMessage();
        public List<Product> GetProducts()
        {
            List<Product> products = productManagement.GetProducts();
            return products;
        }

        public ReturnMessage AddProduct(Product product)
        {
            int productNameMaxLength = 40;
            int quantityPerUnitMaxLength = 20;
            if (product.ProductName.Length > productNameMaxLength 
                || string.IsNullOrWhiteSpace(product.ProductName))
            {
                
                message.Value = ValueTooLongOrEmptyMessage(productNameMaxLength,"Product Name");
                return message;
            }            
            else if(product.QuantityPerUnit.Length > quantityPerUnitMaxLength 
                || string.IsNullOrWhiteSpace(product.QuantityPerUnit))
            {
                message.Value = ValueTooLongOrEmptyMessage(quantityPerUnitMaxLength, "Quantity Per Unit");
                return message;
            }
            else if (product.UnitPrice < 0 )
            {
                message.Value = InvalidNumber("Unit Price");
                return message;
            }
            else if (product.UnitsInStock < 0)
            {
                message.Value = InvalidNumber("Units In Stock");
                return message;
            }
            else if (product.UnitsOnOrder < 0)
            {
                message.Value = InvalidNumber("Units On Order");
                return message;
            }
            else if (product.ReorderLevel < 0)
            {
                message.Value = InvalidNumber("Reorder Level");
                return message;
            }
            bool isProductContained = productManagement.IsProductContained(product);
            if (!isProductContained)
            {
                bool isAdded = productManagement.AddProduct(product);
                if(isAdded)
                {
                    message.Value = $"{product.ProductName} is successfully added.";
                    message.isSuccessful = true;
                }
                else
                {
                    message.Value = DatabaseErrorMessage();
                }
                return message;
            }
            else
            {
                message.Value = AlreadyExists();
                return message;
            }       

        }
        private string AlreadyExists()
        {
            return "Product already exists.";
        }
        private string InvalidNumber(string property)
        {
            return $"Invalid number for {property}";
        }

        private string ValueTooLongOrEmptyMessage(int length, string property)
        {
            return $"{property} cannot be empty or contain more than {length} characters.";

        }
        string DatabaseErrorMessage()
        {
            return "Something went wrong with database.";
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
