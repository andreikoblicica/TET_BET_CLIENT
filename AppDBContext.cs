using Microsoft.EntityFrameworkCore;
using TET_BET.Models;

namespace TET_BET
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {
        }

        public static AppDBContext GetContext()
        {
            string connectionstring =
                "server = localhost; port = 3306; user = Citadin2; password = Aaladin2000-; database = TET_BET";

            var optionsBuilder = new DbContextOptionsBuilder<AppDBContext>();
            optionsBuilder.UseMySQL(connectionstring);

            return new AppDBContext(optionsBuilder.Options);
        }

        public DbSet<DBAccountDetails> DBAccountDetails { get; set; }
        public DbSet<DBBet> DBBet { get; set; }
        public DbSet<DBBettingEventStatus> DBBettingEventStatus { get; set; }
        public DbSet<DBBettingTicket> DBBettingTicket { get; set; }
        public DbSet<DBBetType> DBBetType { get; set; }
        public DbSet<DBEventt> DBEventt { get; set; }
        public DbSet<DBSport> DBSport { get; set; }
        public DbSet<DBFootballEvent> DBFootballEvent { get; set; }
        public DbSet<DBTransaction> DBTransaction { get; set; }
        public DbSet<DBUser> DBUser { get; set; }
        public DbSet<DBUserBet> DBUserBet { get; set; }
        public DbSet<DBCountry> DBCountry { get; set; }
        public DbSet<DBFootballLeague> DBFootballLeague { get; set; }
        public DbSet<DBFootballEventBet> DBFootballEventBet { get; set; }
        public DbSet<DBAppConfigs> DBAppConfigs { get; set; }
    }
}