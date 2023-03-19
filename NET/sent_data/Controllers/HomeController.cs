using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using sent_data.Models;

namespace sent_data.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        ViewBag.Nombre = "Daniel";
        ViewData["Apellido"] = "Gonzalez";
        TempData["Usuario"] = "kaiserkey";
        List<string> Frutas = new List<string>(){
            "Manzana",
            "Pera",
            "Sandia",
            "Melon",
            "Piña"
        };
        ViewBag.Frutas = Frutas;
        TempData["Frutas"] = Frutas;
        ViewData["Fr"]
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
