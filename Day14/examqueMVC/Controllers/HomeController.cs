using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using examqueMVC.Models;

namespace examqueMVC.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Updatedata()
    {
        return View();
    }

    public IActionResult Insertdata()
    {
        return View();
    }
    public IActionResult Deletedata()
    {
        return View();
    }
    public IActionResult Showdata()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
