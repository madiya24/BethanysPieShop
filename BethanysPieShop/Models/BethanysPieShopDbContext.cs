using System;
using Microsoft.EntityFrameworkCore;

namespace BethanysPieShop.Models;

public class BethanysPieShopDbContext : DbContext
{
    public BethanysPieShopDbContext(DbContextOptions<BethanysPieShopDbContext> options) : base(options)
    {
    } //This is the constructor for the BethanysPieShopDbContext class. It takes a parameter of type DbContextOptions<BethanysPieShopDbContext> and passes it to the base class constructor

    public DbSet<Category> Categories { get; set; } //DbSet is a property that represents a collection of entities in the database. It allows you to perform CRUD (Create, Read, Update, Delete) operations on the corresponding table in the database. In this case, we have two DbSet properties: Categories and Pies, which represent the Category and Pie entities respectively.
    public DbSet<Pie> Pies { get; set; }
}
