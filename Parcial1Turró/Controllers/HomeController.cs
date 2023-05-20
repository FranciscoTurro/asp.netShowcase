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
            return View();
        }

        public IActionResult Contacto()
        {
            return View();
        }

        public IActionResult Respuesta()
        {
            return View();
        }

        [HttpPost]
        public IActionResult RedireccionRespuesta()
        {
            return RedirectToAction("Respuesta");
        }

        public IActionResult Consultas()
        {
            var clientes = ObtenerClientes();
            return View(clientes);
        }

        private List<Cliente> ObtenerClientes()
        {
            return new List<Cliente>
            {
                new Cliente
                {
                    email = "pepito@gmail.com",
                    razonSocial = 11111111,
                    direccion = "Calle 1400",
                    localidad = "Rosario",
                    pais = "Argentina"
                },
                new Cliente
                {
                    email = "jorgito@gmail.com",
                    razonSocial = 22222222,
                    direccion = "Calle 2112",
                    localidad = "Brasilia",
                    pais = "Brasil"
                },
                new Cliente
                {
                    email = "rodrigo@gmail.com",
                    razonSocial = 33333333,
                    direccion = "Calle 2478",
                    localidad = "Toronto",
                    pais = "Canada"
                },
                new Cliente
                {
                    email = "florentino@gmail.com",
                    razonSocial = 44444444,
                    direccion = "Calle 9876",
                    localidad = "Madrid",
                    pais = "España"
                }
            };
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}