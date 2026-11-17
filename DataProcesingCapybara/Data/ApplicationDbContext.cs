using DataProcesingCapybara.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataProcesingCapybara.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
