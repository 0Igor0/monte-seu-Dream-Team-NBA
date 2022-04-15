using Microsoft.AspNetCore.Mvc;
using NBA.Models;
using System.Diagnostics;
using NBA.Services;

namespace NBA.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly PlayerServices _player;
        private readonly PlayerServices _team;

        public HomeController(ILogger<HomeController> logger)
        {
            _player = new PlayerServices();
            _team = new PlayerServices();
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewData["Players"] = _player.Get();
            ViewData["Teams"] = _player.GetTeam();
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