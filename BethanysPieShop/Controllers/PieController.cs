using System;
using BethanysPieShop.Models;
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
         return View(_pieRepository.AllPies); // we return the view for the List action, and we pass the list of pies from the repository to the view, so we can display them in the view
    }
}