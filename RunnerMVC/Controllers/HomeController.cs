using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using RunnerMVC.Models;
using Microsoft.AspNetCore.OutputCaching;
using System.Reflection.Metadata.Ecma335;
namespace RunnerMVC.Controllers
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

        public IActionResult PaginaInicial()
        {
            //ViewData["Nombre"] = "Galileo Galvez Galvin";
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            ViewBag.Pakistan = 1986;
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        [HttpGet]
        public IActionResult H()
        {
            var xx = DateTime.Now.ToString("T");

            return Content(xx, "text/plain");
        }

        [HttpGet]
        public IActionResult UsingViewData()
        {
            ViewData["Welcome"] = "This an friendly message to you my dear frend";
            ViewData["Hour"] = DateTime.Now.ToString("HH:mm:ss");

            StudentDto _currentStudent = new StudentDto
            {
                CreatedAt = DateTime.Now,
                DateOfBirth = new DateTime(2020, 12, 29),
                Gender = 100,
                MiddleName = "Ganimedes",
                Name = "IsaacN Newton",
                NSS = "ABX12342"
            };

            ViewData["Student"] = _currentStudent;
            ViewData["CurrentThread"] = Thread.CurrentThread.Name;
            ViewData["CurrentThread"] = Thread.CurrentThread.Name;

            return View();
        }

        public IActionResult UsingViewBag()
        {

            ViewBag.Welcome = "I was invoked using ViewBag";
            return View();
        }

        public IActionResult TempUsingTempData()
        {
            TempData["Mensaje"] = "¡Carrera iniciada correctamente!";
            //return View();

            return RedirectToAction("EstadoCarrera");

        }


        public IActionResult EstadoCarrera()
        {

            var mensaje = TempData["Mensaje"] as string;

            ViewBag.Mensaje = mensaje;
            return View("UsingTempData");
        }
    }
}
