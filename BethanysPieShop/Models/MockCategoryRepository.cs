using System;

namespace BethanysPieShop.Models;

public class MoCkCategoryRepository : ICategoryRepository
{
    public IEnumerable<Category> AllCategories => 
    new List<Category>
    {
        new Category { CategoryId = 1, CategoryName = "Fruit pies", Description = "All our fruit pies are made with the finest ingredients" },
        new Category { CategoryId = 2, CategoryName = "Cheese cakes", Description = "Our cheese cakes are made with the finest ingredients" },
        new Category { CategoryId = 3, CategoryName = "Seasonal pies", Description = "Our seasonal pies are made with the finest ingredients" }
    };
}