using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using nombre_proyecto_mvc.Models;
using Models.ViewModel;

namespace nombre_proyecto_mvc.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    

    public IActionResult HolaMundo()
    {
        Persona p = new Persona();
        p.Nombre = "Lucas";
        return View(p);

        
    }

   

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
