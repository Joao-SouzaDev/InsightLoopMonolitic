using InsightLoop.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InsightLoop.Infra.Data.Configuration
{
    class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasOne(prod => prod.ProductOwner)
               .WithMany(user => user.Products)
               .HasPrincipalKey(user => user.Id)
               .HasForeignKey(prod => prod.ProductOwnerId);
        }
    }
}
