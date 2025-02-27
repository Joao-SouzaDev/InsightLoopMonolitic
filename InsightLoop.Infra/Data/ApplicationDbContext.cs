using InsightLoop.Domain.Entities;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace InsightLoop.Infra.Data
{
    public class ApplicationDbContext : IdentityDbContext<Usuario,UsuarioAcesso,int>
    {
        public DbSet<Product> Products { get; set; }    
        public DbSet<ProductOwner> ProductOwners { get; set; }
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
