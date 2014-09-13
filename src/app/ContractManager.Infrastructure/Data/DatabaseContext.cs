using System.Collections.Generic;
using System.Data.Entity;
using ContractManager.Domain.Model;

namespace ContractManager.Infrastructure.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() 
            : base("DatabaseConnectionString") { }

        public DatabaseContext(string connectionString) 
            : base(connectionString) { }

        public IDbSet<Job> Jobs { get; set; }
        public IDbSet<Agent> Agents { get; set; }
        public IDbSet<Agency> Agency { get; set; }
    }
}
