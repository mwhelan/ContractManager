using System.Configuration;

namespace ContractManager.Infrastructure.Data
{
    public class DatabaseConfig
    {
        public static void InitializeDatabase()
        {
            var initializer = new DatabaseInitializer();
            var connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString;
            initializer.InitializeDatabase(new DatabaseContext(connectionString));
        }
    }
}