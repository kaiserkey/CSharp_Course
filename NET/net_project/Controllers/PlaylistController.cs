using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using net_project.Models;

namespace net_project.Controllers;

public class PlaylistController : Controller
{
    private readonly ILogger<PlaylistController> _logger;

    public PlaylistController(ILogger<PlaylistController> logger)
    {
        _logger = logger;
    }

    public IActionResult Playli()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
