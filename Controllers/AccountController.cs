using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TET_BET.ControllersModels.AccountModel;
using TET_BET.Models;
using TET_BET.Service.User;

namespace TET_BET.Controllers
{
    public class AccountController: Controller
    {
       
        public IActionResult Account()
        {
            Account account = new Account();
            AccountModel model = new AccountModel();
            model.accountBalance = account.getBalanceByAccountDetailsID(3);
            model.transactionsList = account.getTransactionsByAccountDetailsID(3);
            model.bettingTicketsList = account.getBettingTicketsByAccountDetailsID(3);
            return View(model);
        }
    }
}