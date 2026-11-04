using Microsoft.EntityFrameworkCore;
using SmartBudgetTracker.Models;

namespace SmartBudgetTracker.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Transaction> Transactions { get; set; }
    }
}
