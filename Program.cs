using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using TET_BET.Models;
using TET_BET.Repositories;

namespace TET_BET
{
    public class Program
    {
        public static void Main(string[] args)
        {
             CreateHostBuilder(args).Build().Run();

            // UserRepository userRepository = new UserRepository();
            // userRepository.InsertNewUser(new DBUser
            // {
            //     userEmail = "tudor@tetbet.com",
            //     userPassword = "1234"
            // });

            // TransactionRepository transactionRepository = new TransactionRepository();
            // transactionRepository.insert(new DBTransaction
            // {
            //     accountDetailsID = 3,
            //     transactionSum = (float) 100.2,
            //     transactionDate = DateTime.Now
            // });
            
            
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder => { webBuilder.UseStartup<Startup>(); });
    }
}