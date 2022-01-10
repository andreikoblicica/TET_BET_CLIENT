using System;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TET_BET.ControllersModels;
using TET_BET.ControllersModels.FootballEventBetsModel;
using TET_BET.ControllersModels.MainMenuModel;
using TET_BET.Models;
using TET_BET.Repositories;
using TET_BET.Service.Events;
using TET_BET.Service.User;

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
            return View(new LoginModel());
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
            Console.WriteLine("asdasdasdasdasdas");

            DBUser user = new DBUser();
            user.userEmail = loginModel.email;
            user.userPassword = loginModel.password;
            Login login = new Login();
            //login.SignInUser(user);
            try
            {
                loginModel.user = login.SignInUser(user);
            }
            catch (Exception e)
            {
                loginModel.wrongSignInMessage = true;
                return RedirectToAction("Index");
            }

            //return RedirectToAction("Index");
            return RedirectToAction("MainMenu", loginModel);
        }

        [HttpPost]
        public IActionResult SignUp(LoginModel loginModel)
        {
            // return RedirectToAction("Index");
            DBUser user = new DBUser();
            user.userEmail = loginModel.email;
            user.userPassword = loginModel.password;
            Login login = new Login();
            //Console.WriteLine(user.accountDetails.accountBalance);
            //login.SignUpUser(user);
            return RedirectToAction("MainMenu", login.SignUpUser(user));
        }

        public IActionResult MainMenu(DBUser user)
        {
            FootballEvent footballEvent = new FootballEvent();
            MainMenuModel model = new MainMenuModel();
            model.MatchInfos = footballEvent.GetMainFootballEventsBet();
            model.sportID = 1;
            model.countryID = 0;
            model.leagueID = 0;

            return View(model);
        }
    }
}