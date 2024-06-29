﻿using Batch4.Api.RestaurantManagementSystem.DA.Models;
using Batch4.Api.RestaurantManagementSystem.DA.Services.Category;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch4.Api.RestaurantManagementSystem.BL.Services.Category
{
    public class BL_Category
    {
        private readonly DA_Category _daCategory;

        public BL_Category(DA_Category daCategory)
        {
            _daCategory = daCategory;
        }

        public int CreateCategory(CategoryModel category)
        {
            var result = _daCategory.CreateCategory(category);
            return result;
        }

        public List<CategoryModel> GetAllCategories()
        {
            return _daCategory.GetAllCategories();
        }

        public CategoryModel GetCategoryById(int id)
        {
            var category = _daCategory.GetCategoryById(id);
            if (category == null) throw new InvalidDataException("no data found");
            return category;
        }

        public CategoryModel GetCategoryByCode(string code)
        {
            var category = _daCategory.GetCategoryByCode(code);
            if (category == null) throw new InvalidDataException("no data found");
            return category;
        }

        public int UpdateCategory(string code,  CategoryModel category)
        {
            var result = _daCategory.UpdateCategory(code, category);
            return result;
        }

        public int DeleteCategory(string code)
        {
            return _daCategory.DeleteCategory(code);
        }
    }

}
