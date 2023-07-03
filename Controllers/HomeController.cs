using Microsoft.AspNetCore.Mvc;

namespace TPElecciones.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        ViewBag.ListaPartido = BD.ListaPartido();
        return View();
        //primer controller
    }
}


