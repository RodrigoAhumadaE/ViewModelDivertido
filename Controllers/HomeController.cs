using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ViewModelDivertido.Models;

namespace ViewModelDivertido.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger){
        _logger = logger;
    }

    [HttpGet("")]
    public IActionResult Index(){
        string mensaje = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Velit numquam inventore id cum tenetur, maiores fugiat";
        mensaje += " illo quia sint esse voluptates nobis blanditiis et distinctio sed sunt eum doloribus voluptas dignissimos corporis atque";
        mensaje += " mollitia. Nemo architecto neque debitis qui ea consequatur et deserunt facilis accusamus iure quod maxime, eum dolor!";
        return View("Index", mensaje);
    }

    [HttpGet("privacy")]
    public IActionResult Privacy(){
        return View("privacy");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error(){
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
