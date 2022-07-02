using Microsoft.AspNetCore.Mvc;
using PizzaAplication.Models;
using PizzaAplication.Models.Domain;
using PizzaAplication.Models.ViewModels;
using PizzaAplication.Models.Mapper;
using System.Diagnostics;

namespace PizzaAplication.Controllers
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

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult SeeUsers()
        {
            List<User> appUsers = StaticDb.Users;
            List<UserViewModel> appUserVMs = appUsers.ToUserViewModels();
            
            return View(appUserVMs);
        }
    }
}