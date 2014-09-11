using System.Data.Entity;

namespace ContractManager.Infrastructure.Data
{
    public class DatabaseInitializer : DropCreateDatabaseAlways<DatabaseContext>
    {
        protected override void Seed(DatabaseContext context)
        {
            SeedData.Create(context);
        }
    }
}