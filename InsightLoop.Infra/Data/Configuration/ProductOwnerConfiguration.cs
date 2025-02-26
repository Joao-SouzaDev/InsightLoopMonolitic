using InsightLoop.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InsightLoop.Infra.Data.Configuration
{
    class ProductOwnerConfiguration : IEntityTypeConfiguration<ProductOwner>
    {
        public void Configure(EntityTypeBuilder<ProductOwner> builder)
        {

        }
    }
}
