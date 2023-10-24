using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ViewModelDivertido.Models;

namespace ViewModelDivertido.Controllers;

public class HomeController : Controller
{
    public static List<Usuario> ListaUsuarios = new List<Usuario>(){
        new Usuario{
            Nombre = "Moose",
            Apellido = "Phillips"
        },
        new Usuario{
            Nombre = "Sarah",
            Apellido = ""
        },
        new Usuario{
            Nombre = "Jerry",
            Apellido = ""
        },
        new Usuario{
            Nombre = "Rene",
            Apellido = "Ricky"
        },
        new Usuario{
            Nombre = "Barbarah",
            Apellido = ""
        },
    };
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

    [HttpGet("numbers")]
    public IActionResult Numbers(){
        int[] numeros = new int[]{5, 12, 8, 25, 49, 82, 40, 21};
        return View("Numbers", numeros);
    }

    [HttpGet("users")]
    public IActionResult Users(){
        return View("Users", ListaUsuarios);
    }

    [HttpGet("user")]
    public IActionResult AUser(){
        Random rand = new Random();
        Usuario usuario = ListaUsuarios[rand.Next(ListaUsuarios.Count)];
        return View("User", usuario);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error(){
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
