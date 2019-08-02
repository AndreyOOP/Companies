using CompanyManagement.Database.Entities;
using System.Data.Entity;

namespace CompanyManagement.Database
{
    public class Context : DbContext
    {
        public Context(string nameOrConnectionString) : base(nameOrConnectionString)
        {
        }

        public DbSet<Company> Companies { get; set; }
    }
}
