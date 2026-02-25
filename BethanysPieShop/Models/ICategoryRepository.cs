using System;

namespace BethanysPieShop.Models;

public interface ICategoryRepository
{
    IEnumerable<Category> AllCategories { get; } // IENUMERABLE is a collection of categories, we use it because it is more efficient than a list when we only need to read the data, and we add a getter to make it read-only
}
