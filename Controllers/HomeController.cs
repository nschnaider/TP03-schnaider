using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP03_schnaider.Models;

namespace TP03_schnaider.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        Empresa.inicializarDisco();
        Dictionary<string, Disco> discos = Empresa.discos;
        ViewBag.Empresa = discos;
        return View();
    }
    public IActionResult MostrarDiscos(string id){
        if (Empresa.discos.ContainsKey(id)){
          ViewBag.disco= Empresa.discos[id];
        }
        return View("InfoDisco");
    }
}
