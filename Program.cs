using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using TET_BET.Models;
using TET_BET.Repositories;
using TET_BET.Service;
using TET_BET.Service.User;

namespace TET_BET
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // asta da drumu la aplicatie, o comentam ca sa ne testam serviciile
            // CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder => { webBuilder.UseStartup<Startup>(); });
    }
}