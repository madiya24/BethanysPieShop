using System;

namespace BethanysPieShop.Models;

public interface IPieRepository // use an interface to define the contract for the repository, so we can implement it in different ways (e.g. in-memory, database, etc.)
{
    IEnumerable<Pie> AllPies{ get; }
     IEnumerable<Pie> PiesOfTheWeek { get; }
    Pie? GetPieById(int pieId); // give back a pie by its id, we add a question mark because it can be null if the pie is not found
}