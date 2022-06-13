using Microsoft.AspNetCore.Mvc;
using NBA.Models;
using NBA.Services;

namespace NBA.Controllers
{
    public class MatchController : Controller
    {
        private readonly PlayerServices _player;

        public MatchController()
        {
            _player = new PlayerServices();//crio uma instancia de player services par poder usar seus métodos
        }
        public IActionResult Index()
        {

            Team NewTeam()
            {
                return _player.GetOneTeam();
            }
            ViewData["oneTeam"] = ViewData["Teams"] = _player.GetOneTeam();

            ViewData["Teams"] = _player.GetTeam();

            return View();
        }
    }
}
