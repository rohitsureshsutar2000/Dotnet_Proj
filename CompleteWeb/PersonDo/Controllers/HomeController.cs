using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PersonDo.Models;
using System.Collections.Generic;
using BOJ;
using BLL;
// using System.ComponentModel.DataValidation;

namespace PersonDo.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult form()
    {
        return View();
    }

    [HttpPost]
    public IActionResult form(string username,string password)
    {
        List<RiderLogin> lst=new List<RiderLogin>();
        lst=BLLservice.GetAlldetails();
        foreach (RiderLogin item in lst)
        {
            if(username==item.Username && password==item.Password)
            {
                    return this.RedirectToAction("ShowData");
            }
        }
        
        // Console.WriteLine(username+" "+password);
        
        return View();
    }

    public IActionResult ShowData()
    {

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
