using Microsoft.EntityFrameworkCore;

namespace TET_BET
{
    public class GenericRepositoryActions
    {
        public AppDBContext GetAppDBContext()
        {
            string connectionString = AppSettingsFetcher.GetConnectionString();
            
            var optionsBuilder = new DbContextOptionsBuilder<AppDBContext>();
            optionsBuilder.UseMySQL(connectionString);
            
            return new AppDBContext(optionsBuilder.Options);
        }
    }
}