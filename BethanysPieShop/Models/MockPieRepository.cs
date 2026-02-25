using System;

namespace BethanysPieShop.Models;

public class MockPieRepository : IPieRepository

{
    private readonly ICategoryRepository _categoryRepository = new MoCkCategoryRepository();
    public IEnumerable<Pie> AllPies =>
        new List<Pie>
        {
            new Pie { PieId = 1, Name = "Strawberry Pie", Price = 12.95M, ShortDescription = "Our famous strawberry pies!", LongDescription = "Our famous strawberry pies are made with the finest ingredients and baked to perfection.", Category = _categoryRepository.AllCategories.ToList()[0], ImageUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/bethanyspieshop/fruitpies/strawberrypie.jpg", InStock=true, IsPieOfTheWeek=false, ImageThumbnailUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/bethanyspieshop/fruitpies/strawberrypiesmall.jpg"},
            new Pie { PieId = 2, Name = "Pumpkin Pie", Price = 12.95M, ShortDescription = "Our seasonal pumpkin pie!", LongDescription = "Our seasonal pumpkin pie is made with the finest ingredients and baked to perfection.", Category = _categoryRepository.AllCategories.ToList()[1],ImageUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/bethanyspieshop/seasonal/pumpkinpie.jpg", InStock=true, IsPieOfTheWeek=true, ImageThumbnailUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/bethanyspieshop/seasonal/pumpkinpiesmall.jpg"},
            new Pie { PieId = 3, Name = "Rhubarb Pie", Price = 15.95M, ShortDescription = "Our delicious rhubarb pie!", LongDescription = "Our delicious rhubarb pie is made with the finest ingredients and baked to perfection.", Category = _categoryRepository.AllCategories.ToList()[0],ImageUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/bethanyspieshop/fruitpies/rhubarbpie.jpg", InStock=true, IsPieOfTheWeek=true, ImageThumbnailUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/bethanyspieshop/fruitpies/rhubarbpiesmall.jpg"},
            new Pie { PieId = 4, Name = "Cheese Cake", Price = 18.95M, ShortDescription = "Our classic cheese cake!", LongDescription = "Our classic cheese cake is made with the finest ingredients and baked to perfection.", Category = _categoryRepository.AllCategories.ToList()[2],ImageUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/bethanyspieshop/cheesecakes/cheesecake.jpg", InStock=true, IsPieOfTheWeek=false, ImageThumbnailUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/bethanyspieshop/cheesecakes/cheesecakesmall.jpg"},
        };
    public IEnumerable<Pie> PiesOfTheWeek 
    {
        get
        {
            return AllPies.Where(p => p.IsPieOfTheWeek);
        }
    }

    public Pie? GetPieById(int pieId) => AllPies.FirstOrDefault(p => p.PieId == pieId);
    
    public IEnumerable<Pie>SearchPies(string searchQuery)
    {
       throw new NotImplementedException();
    }
}
