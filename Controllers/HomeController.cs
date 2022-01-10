using System;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TET_BET.ControllersModels;
using TET_BET.ControllersModels.MainMenuModel;
using TET_BET.Models;
using TET_BET.Service.Events;

namespace TET_BET.Controllers
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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }

        [HttpPost]
        public IActionResult SignIn(LoginModel loginModel)
        {
            Console.WriteLine(loginModel.email);
            Console.WriteLine(loginModel.password);
            // return RedirectToAction("Index");
            return RedirectToAction("MainMenu");
        }

        public IActionResult MainMenu()
        {
            FootballEvent footballEvent = new FootballEvent();
            MainMenuModel model = new MainMenuModel();
            model.MatchInfos = footballEvent.GetMainFootballEventsBet();
            
            return View(model);
        }
    }
}