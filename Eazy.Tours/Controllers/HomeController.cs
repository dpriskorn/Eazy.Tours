using Eazy.Tours.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Eazy.Tours.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IDbRepository _repo;

        public HomeController(ILogger<HomeController> logger, IDbRepository repo)
        {
            _logger = logger;
            _repo = repo;
        }

        public IActionResult Index()
        {
            //checking if user is showing - delete later
            var user = _repo.GetUserById(1);
            return View();
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