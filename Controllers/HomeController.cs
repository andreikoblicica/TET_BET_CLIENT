using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TET_BET.ControllersModels;
using TET_BET.ControllersModels.FootballEventBetsModel;
using TET_BET.ControllersModels.MainMenuModel;
using TET_BET.Models;
using TET_BET.Service.Betting;
using TET_BET.Repositories;
using TET_BET.Service.Events;
using TET_BET.Service.User;
using TET_BET.Utilities;
using JsonSerializer = System.Text.Json.JsonSerializer;

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

        [HttpGet]
        public string AddBetOnTicketAndGetFootballEventBetIDInfoAjax(int footballEventBetID)
        {
            AddBetOnTicket(footballEventBetID);
            return JsonSerializer.Serialize(GetFootballEventBetIDInfo(footballEventBetID));
        }

        private void AddBetOnTicket(int footballEventBetID)
        {
            byte[] UserBettingTicketByteArray = HttpContext.Session.Get("UserBettingTicket");

            List<int> bettingTicketFootballEventBetsIDs;

            if (UserBettingTicketByteArray != null)
            {
                bettingTicketFootballEventBetsIDs = FinesseTools.ByteArrayToIntList(UserBettingTicketByteArray);
            }
            else
            {
                bettingTicketFootballEventBetsIDs = new List<int>();
            }

            bettingTicketFootballEventBetsIDs.Add(footballEventBetID);

            HttpContext.Session.Set("UserBettingTicket",
                bettingTicketFootballEventBetsIDs.SelectMany(BitConverter.GetBytes).ToArray());
        }

        private BettingTicketBetModel GetFootballEventBetIDInfo(int footballEventBetID)
        {
            BetActions betActions = new BetActions();
            return betActions.GetBettingTicketModelByFootballEventBetID(footballEventBetID);
        }

        public void DeleteBetFromTicketAjax(int footballEventBetID)
        {
            byte[] UserBettingTicketByteArray = HttpContext.Session.Get("UserBettingTicket");

            List<int> bettingTicketFootballEventBetsIDs;

            if (UserBettingTicketByteArray != null)
            {
                bettingTicketFootballEventBetsIDs = FinesseTools.ByteArrayToIntList(UserBettingTicketByteArray);
            }
            else
            {
                bettingTicketFootballEventBetsIDs = new List<int>();
            }

            bettingTicketFootballEventBetsIDs.Remove(footballEventBetID);

            HttpContext.Session.Set("UserBettingTicket",
                bettingTicketFootballEventBetsIDs.SelectMany(BitConverter.GetBytes).ToArray());
        }

        public void SubmitBettingTicketAjax(float bettingTicketSum)
        {
            byte[] UserBettingTicketByteArray = HttpContext.Session.Get("UserBettingTicket");

            List<int> bettingTicketFootballEventBetsIDs;

            if (UserBettingTicketByteArray != null)
            {
                bettingTicketFootballEventBetsIDs = FinesseTools.ByteArrayToIntList(UserBettingTicketByteArray);
            }
            else
            {
                bettingTicketFootballEventBetsIDs = new List<int>();
            }

            BettingTicketActions bettingTicketActions = new BettingTicketActions(null);
            BetActions betActions = new BetActions();
            UserActions userActions = new UserActions();

            DBBettingTicket dbBettingTicket = new DBBettingTicket();
            dbBettingTicket.bettingTicketBetsList = new List<DBUserBet>();
            dbBettingTicket.isWinner = false;
            dbBettingTicket.bettingTicketDate = DateTime.Now;
            dbBettingTicket.bettingTicketSum = bettingTicketSum;
            dbBettingTicket.isClosed = false;


            // int userID = Int32.Parse(HttpContext.Session.GetString("userID"));
            dbBettingTicket.accountDetailsID = userActions.GetAccountByUserID(3).accountDetailsID;
            
            bettingTicketFootballEventBetsIDs.ForEach(id =>
            {
                dbBettingTicket.bettingTicketBetsList.Add(new DBUserBet()
                {
                    isWinner = false,
                    footballEventBetID = betActions.GetFootballEventBetByID(id).footballEventBetID
                });
            });

            bettingTicketActions.CreateBettingTicket(dbBettingTicket);
        }
    }
}