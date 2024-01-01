using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using projMVC.Models;
using dbmanagerUtil;
using BOJ;
namespace projMVC.Controllers;


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
    public IActionResult Login()
    {
        return View();
    }
    public IActionResult Registration()
    {
        return View();
    }
    
    [HttpPost]
    public IActionResult Registration(string Name,string Email,string Mobile, string Address , string Username,string Password )
    {
        bool flag=false;
        string s= BDmanager.Registration(Name,Email,Mobile,Address,Username,Password);
        ViewData["Data added!!!"]=s;
        if(s!=null){
            
            
        }
        else
        {
            ViewData["Data added!!!"]="Plz register";
        }
        
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
