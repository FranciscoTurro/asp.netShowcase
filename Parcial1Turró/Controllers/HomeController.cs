using Microsoft.AspNetCore.Mvc;
using Parcial1Turró.Models;
using System.Diagnostics;

namespace Parcial1Turró.Controllers
{
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

        public IActionResult Formulario()
        {
            return View();
        }

        public IActionResult Imagenes()
        {
            var imagenes = ObtenerImagenes();
            return View(imagenes);
        }

        public IActionResult Contacto()
        {
            return View();
        }

        public IActionResult Respuesta()
        {
            return View();
        }

        private List<string> ObtenerImagenes()
        {
            return new List<string>
            {
                "~/img/img1.jpg",
                "~/img/img2.jpg",
                "~/img/img3.jpg",
                "~/img/img4.jpg"
            };
        }


        [HttpPost]
        public IActionResult RedireccionRespuesta()
        {
            return RedirectToAction("Respuesta");
        }

        public IActionResult Consultas()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}