using InsightLoop.Domain.Entities;
using InsightLoop.Infra.Data.Security;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace InsightLoop.Infra.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }    
        public DbSet<ProductOwner> ProductOwners { get; set; }
        public DbSet<ApplicationUser> User { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
