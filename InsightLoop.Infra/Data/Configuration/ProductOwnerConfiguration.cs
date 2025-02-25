using InsightLoop.Domain.Entities;
using InsightLoop.Infra.Data.Security;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsightLoop.Infra.Data.Configuration
{
    class ProductOwnerConfiguration : IEntityTypeConfiguration<ProductOwner>
    {
        public void Configure(EntityTypeBuilder<ProductOwner> builder)
        {
            builder.HasOne(prodOwner => prodOwner.User)
                .WithOne()
                .HasForeignKey<ProductOwner>(prodOwner => prodOwner.UserId);
        }
    }
}
