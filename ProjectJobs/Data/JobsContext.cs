using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using ProjectJobs.Domain;

namespace ProjectJobs.Data
{
    public class JobsContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = ProjectJobs_EFCore");
        }

        public DbSet<Employee> Employees { get; set; } 
        public DbSet<Order> Orders { get; set; }

    }
}
