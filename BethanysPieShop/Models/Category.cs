using System;

namespace BethanysPieShop.Models;

public class Category
{
    public int CategoryId { get; set; }
    public string CategoryName { get; set; } = string.Empty;
    public string? Description { get; set; }
    public virtual List<Pie>? Pies { get; set; }  //create a list of pies in the category, we add a question mark because it can be null, and we add virtual to enable lazy loading
}
