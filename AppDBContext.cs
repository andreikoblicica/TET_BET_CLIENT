using Microsoft.EntityFrameworkCore;
using TET_BET.Models;

namespace TET_BET
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {
        }

        public DbSet<DBUser> DBUser { get; set; }
    }
}