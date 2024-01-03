using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using preparefortest.Models;

namespace preparefortest.Controllers;

public class PillionController : Controller
{
    private readonly ILogger<PillionController> _logger;

    public PillionController(ILogger<PillionController> logger)
    {
        _logger = logger;
    }

    public IActionResult Pillion_details()
    {
        return View();
    }


    
}
