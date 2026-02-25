using System;

namespace BethanysPieShop.Models;

public class Pie
{
    public int PieId { get; set; }
    public string Name { get; set; } = string.Empty; // we can set a default value for a property, so it will not be null
    public string? ShortDescription { get; set; }
    public string? LongDescription { get; set; }
    public decimal Price { get; set; }
    public string? ImageUrl { get; set; } // we add a question mark on a properties that do not required the value to be set, so it can be null
    public string? ImageThumbnailUrl { get; set; }
    public bool IsPieOfTheWeek { get; set; }
    public bool InStock { get; set; }
    public int CategoryId { get; set; }
    public virtual Category Category { get; set; } = default!;
}
