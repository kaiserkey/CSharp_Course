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
        ViewData["Frutas"] = Frutas;

        return View();
    }

    public IActionResult Usuario()
    {
        List<Usuario> Usuario = new List<Usuario>(){
            new Usuario(){
                Nombre = "Jose",
                Apellido = "Gomez",
                Usuario = "josegomez",
                Correo = "josegomez@gmail.com"
            },
            new Usuario(){
                Nombre = "Maria",
                Apellido = "Gomez",
                Usuario = "mariagomez",
                Correo = "mariagomez@gmail.com"
            },
            new Usuario(){
                Nombre = "Pedro",
                Apellido = "Gomez",
                Usuario = "pedrogomez",
                Correo = "pedrogomez
            }
        };
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
