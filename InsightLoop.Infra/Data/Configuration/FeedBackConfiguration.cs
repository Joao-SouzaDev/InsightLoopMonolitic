using InsightLoop.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsightLoop.Infra.Data.Configuration
{
    class FeedBackConfiguration : IEntityTypeConfiguration<Feedback>
    {
        public void Configure(EntityTypeBuilder<Feedback> builder)
        {
            builder.HasOne(feed =>  feed.FeedbackOwner)
                .WithMany(feedOwner => feedOwner.Feedbacks)
                .HasPrincipalKey(feed => feed.Id)
                .HasForeignKey(feedOwner => feedOwner.FeedbackOwner);
        }
    }
}
