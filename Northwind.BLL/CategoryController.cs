using Northwind.DAL;
using Northwind.Entities;
using Northwind.Helpers;
using System.Collections.Generic;

namespace Northwind.BLL
{
    public class CategoryController
    {
        CategoryManagement categoryManagment = new CategoryManagement();

        public List<Category> GetCategories()
        {
            List<Category> categories = categoryManagment.GetCategoryList();

            return categories;
        }

        public ReturnMessage AddCategory(Category category)
        {
            ReturnMessage message = new ReturnMessage();
            if (isCategoryNameInvalid(category))
            {
                message.Value = InvalidCategoryName();
                return message;
            }
            else {
                bool isAdded = categoryManagment.AddCategory(category);
                if (isAdded) {
                message.Value = $"{category.CategoryName} is successfully added.";
                    return message;
                }
                else
                {
                    message.Value = DatabaseErrorMessage();
                    return message;
                }  
            }          
        }
        public ReturnMessage UpdateCategory(Category category)
        {
            ReturnMessage message = new ReturnMessage();
            if (isCategoryNameInvalid(category))
            {
                message.Value = InvalidCategoryName();
                return message;
            }
            else
            {
                bool isUpdated = categoryManagment.UpdateCategory(category);
                if(isUpdated)
                {
                    message.Value = $"{category.CategoryName} is successfully updated.";
                    return message;
                }
                else
                {
                    message.Value = DatabaseErrorMessage();
                    return message;
                }
            }
        }

        public ReturnMessage DeleteCategory(Category category)
        {
            ReturnMessage message = new ReturnMessage();
            string categoryName = category.CategoryName;
            bool isDeleted = categoryManagment.DeleteCategory(category);
            if (isDeleted)
            {
                message.Value = $"{categoryName} is successfully deleted.";
                return message;
            }
            else
            {
                message.Value = DatabaseErrorMessage();
                return message;
            }
            
        }
        bool isCategoryNameInvalid(Category category)
        {
            if (string.IsNullOrWhiteSpace(category.CategoryName) || category.CategoryName.Length > 15)
                return true;
            else
                return false;
        }
        string  DatabaseErrorMessage()
        {
            return "Something went wrong with database.";
        }
        string InvalidCategoryName()
        {
            return "Category name cannot have more than 15 characters or be empty.";
        }
    }
}