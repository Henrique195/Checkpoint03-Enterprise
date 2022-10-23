using Checkpoint03_Enterprise.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Checkpoint03_Enterprise.Controllers
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
            PacienteModel model = new PacienteModel();

            model.Name = "claudio";
            model.Email = "claudio@hotmail.com";
            model.Password = "senha";
            model.StreetName = "voluntarios";
            model.StreetNumber = 25;
            model.Neighborhood = "Santana";
            model.City = "Sao paulo";
            model.Country = "Brasil";

            return View(model);
        }

        public IActionResult Privacy()
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