using InsightLoop.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InsightLoop.Infra.Data.Configuration
{
    class FeedBackOwnerConfiguration : IEntityTypeConfiguration<FeedBackOwner>
    {
        public void Configure(EntityTypeBuilder<FeedBackOwner> builder)
        {
            builder.HasOne(feedOwner => feedOwner.User)
                .WithOne()
                .HasForeignKey<FeedBackOwner>(feedOwner => feedOwner.UserId);
        }
    }
}
