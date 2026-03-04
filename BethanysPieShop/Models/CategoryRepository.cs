using System;

namespace BethanysPieShop.Models;

public class CategoryRepository: ICategoryRepository
{
    private readonly BethanysPieShopDbContext _bethanysPieShopDbContext; 

    public CategoryRepository(BethanysPieShopDbContext bethanysPieShopDbContext)
    {
        _bethanysPieShopDbContext = bethanysPieShopDbContext;
    }

    public IEnumerable<Category> AllCategories => _bethanysPieShopDbContext.Categories.OrderBy(c => c.CategoryName); // This property returns a list of all categories in the database. It uses the Categories DbSet from the DbContext to query the database and convert the results to a list.
    
}
