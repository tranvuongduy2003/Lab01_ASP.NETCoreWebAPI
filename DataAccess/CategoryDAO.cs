﻿using BusinessObjects;

namespace DataAccess;

public class CategoryDAO
{
    public static List<Category> GetCategories()
    {
        var listCategories = new List<Category>();
        try
        {
            using (var context = new ApplicationDBContext())
            {
                listCategories = context.Categories.ToList();
            }
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }

        return listCategories;
    }
}