﻿namespace Batch4.Api.RestaurantManagementSystem.BL.RequestModels;

public  record CategoryRequest(string categoryName)
{
    public CategoryModel Change()
    {
        return new CategoryModel
        {
            CategoryName = categoryName.Trim().ToUpper(),
            CategoryCode = this.GenerateCode(categoryName)
        };
    }

    private string GenerateCode(string name)
    {
        string prefix = name.Trim().Substring(0, 3).ToUpper();

        Random rdn = new Random();
        string code = prefix + rdn.Next(100, 999).ToString();

        return code;
    }
}
