using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Nuova_cartella.Models;

namespace Nuova_cartella.Controllers;

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
        return View();
    }
    [HttpPost]
    public IActionResult Prenota(Prenotazione prenotazione)
    {
        ViewData["Nome"] = prenotazione.nome;
        ViewData["Email"] = prenotazione.email;
        return View("Prenota", prenotazione);
    }
    [HttpGet]
    public IActionResult Prenota()
    {
        return View();
    }
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
