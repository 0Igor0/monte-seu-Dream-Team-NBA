using Microsoft.AspNetCore.Mvc;
using NBA.Models;
using NBA.Services;

namespace NBA.Controllers
{
    public class HomeController : Controller
    {
        private readonly PlayerServices _player;//Crio a injeção de depêndencia do arquivo Player services

        public HomeController()
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