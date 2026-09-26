using Microsoft.EntityFrameworkCore;
using TravelLearning.Core.Models;


namespace TravelLearning.Infrastructure
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext (options)
    {
        public DbSet<Contract> Contracts => Set<Contract>();
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
        }
    }
}
