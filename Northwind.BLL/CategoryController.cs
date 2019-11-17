using Northwind.DAL;
using Northwind.Entities;
using Northwind.Helpers;
using System.Collections.Generic;

namespace Northwind.BLL
{
    public class CategoryController
    {
        CategoryManagement categoryManagement = new CategoryManagement();

        public List<Category> GetCategories()
        {
            List<Category> categories = categoryManagement.GetCategoryList();

            return categories;
        }

        public ReturnMessage AddCategory(Category category)
        {
            ReturnMessage message = new ReturnMessage();
            if (isCategoryNameInvalid(category))
            {
                message.Value = InvalidCategoryNameMessage();
                return message;
            }
            bool isCategoryContained = categoryManagement.IsCategoryContained(category);
            if (!isCategoryContained)
            {
                bool isAdded = categoryManagement.AddCategory(category);
                if (isAdded)
                {
                    message.isSuccessful = true;
                    message.Value = $"{category.CategoryName} is successfully added.";
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
        public ReturnMessage UpdateCategory(Category newCategory)
        {
            ReturnMessage message = new ReturnMessage();
            bool isUpdated = categoryManagement.UpdateCategory(newCategory);
            if (isUpdated)
            {
                message.Value = $"{newCategory.CategoryName} is successfully updated.";
                message.isSuccessful = true;
                return message;
            }
            else
            {
                message.Value = DatabaseErrorMessage();
                return message;
            }
        }     
        public ReturnMessage DeleteCategory(Category category)
        {
            ReturnMessage message = new ReturnMessage();
            string categoryName = category.CategoryName;
            bool isDeleted = categoryManagement.DeleteCategory(category);
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

        public Category GetCategoryById(int categoryId)
        {
            return categoryManagement.GetCategoryById(categoryId);
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
        string InvalidCategoryNameMessage()
        {
            return "Category name cannot have more than 15 characters or be empty.";
        }
        private string AlreadyExists()
        {
            return "Category already exists.";
        }
    }
}