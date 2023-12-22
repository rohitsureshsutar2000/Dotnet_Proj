using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using player;
using RohitProject.Models;

namespace RohitProject.Controllers;

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

    public IActionResult Privacy()
    {
        Player p =new Player();
        p.Name="rohit";
        p.Id="FL's-->BigBe";
        p.Kd=4;
        p.Img="/img/download.jfif";

        Player p2 =new Player();
        p2.Name="souraj";
        p2.Id="FL's-->Max";
        p2.Kd=4;
        p2.Img="/img/download.jfif";

        Player p3 =new Player();
        p3.Name="rutvik";
        p3.Id="FL's-->Ghosti";
        p3.Kd=4;
        p3.Img="/img/download.jfif";

        Player [] p4=new Player[3];
        p4[0]=p;
        p4[1]=p2;
        p4[2]=p3;

        ViewData["ProBro"]=p4;
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
