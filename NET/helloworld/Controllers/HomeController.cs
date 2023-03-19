﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using helloworld.Models;
using System.IO;

namespace helloworld.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private IHostingEnviroment _env;

    public HomeController(ILogger<HomeController> logger, IHostingEnviroment env)
    {
        _logger = logger;
        _env = env;
    }

    public FileStreamResult PDF(){
        string FilePath = FilePath.Combine(_env.WebRootPath, "wwwroot/download/", "20Horas.pdf");
        string FilePathN = FilePath.Combine(_env.WebRootPath, "wwwroot/download/", "20Horas.pdf");
        if(System.IO.File.Exists(FilePath)){
            FileStream fs = new FileStream(FilePath, FileMode.Open);
            return File(fs, "aplication/pdf");
        }else{
            FileStream fs = new FileStream(FilePath, FileMode.Open);
            return File(fs, "aplication/pdf");
        }
    }

    public IActionResult Index()
    {
        return View();
    }

    public ViewResult Test(){
        return View();
    } 

    public string HelloWorld(string nombre)
    {
        return "Hello World! " + nombre;
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
