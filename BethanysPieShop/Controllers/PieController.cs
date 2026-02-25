using System;
using BethanysPieShop.Models;
using BethanysPieShop.ViewModels;
using Microsoft.AspNetCore.Mvc;
namespace BethanysPieShop.Controllers;

public class PieController : Controller
{
    private readonly IPieRepository _pieRepository; // we declare private fields for the dependencies of the controller, so we can use them in the controller actions
    private readonly ICategoryRepository _categoryRepository;

    public PieController(IPieRepository pieRepository, ICategoryRepository categoryRepository) // we use constructor injection to inject the dependencies of the controller, so we can use them in the controller actions
    {
        _pieRepository = pieRepository; // we assign the injected dependencies to the private fields of the controller, so we can use them in the controller actions
        _categoryRepository = categoryRepository;
    }

    public IActionResult List() // we create a controller action that will handle the requests to the /Pie/List URL, so we can display the list of pies in the view
    {
       // ViewBag.CurrentCategory = "Cheese cakes"; // we set the CurrentCategory property of the ViewBag to the name of the category that we want to display in the view, so we can display it in the view
         //return View(_pieRepository.AllPies); // we return the view for the List action, and we pass the list of pies from the repository to the view, so we can display them in the view
         PieListViewModel pieListViewModel = new PieListViewModel(_pieRepository.AllPies, "Cheese cakes"); // we create an instance of the PieListViewModel class, and we pass the list of pies from the repository and the name of the category to the constructor of the view model, so we can use them in the view
         return View(pieListViewModel); // we return the view for the List action, and we pass the PieListViewModel instance to the view, so we can display it in the view
    }
}