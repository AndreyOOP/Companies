using CompanyManagement.Database.Entities;
using System.Data.Entity;

namespace CompanyManagement.Database
{
    public class Context : DbContext
    {
        public DbSet<Company> Companies { get; set; }
    }
}
