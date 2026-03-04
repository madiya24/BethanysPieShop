using System;
using Microsoft.EntityFrameworkCore;

namespace BethanysPieShop.Models;

public class PieRepository: IPieRepository
{
    private readonly BethanysPieShopDbContext _bethanysPieShopDbContext; // This is a private field that holds a reference to the BethanysPieShopDbContext. It is used to interact with the database.

    public PieRepository(BethanysPieShopDbContext bethanysPieShopDbContext) // using dependency injection to inject an instance of BethanysPieShopDbContext into the PieRepository class. This allows us to use the DbContext to perform database operations in the repository.
    {
        _bethanysPieShopDbContext = bethanysPieShopDbContext;
    }

    public IEnumerable<Pie> AllPies
    {
        get
        {
            return _bethanysPieShopDbContext.Pies.Include(c => c.Category); // This property returns a list of all pies in the database. It uses the Pies DbSet from the DbContext to query the database and convert the results to a list.
        }
    }

    public IEnumerable<Pie> PiesOfTheWeek
    {
        get
        {
            return _bethanysPieShopDbContext.Pies.Include(c => c.Category).Where(p => p.IsPieOfTheWeek); // This property returns a list of pies that are marked as "Pie of the Week". It uses the Pies DbSet from the DbContext to query the database, filters the results using a Where clause, and converts the results to a list.
        }
    }

    public Pie? GetPieById(int pieId)
    {
        return _bethanysPieShopDbContext.Pies.FirstOrDefault(p => p.PieId == pieId); // This method takes an integer parameter (pieId) and returns a single Pie object that matches the given ID. It uses the Pies DbSet from the DbContext to query the database, filters the results using a FirstOrDefault clause, and returns the matching Pie object or null if no match is found.
    }
}
