using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Persistence.Models;

namespace Persistence.Configurations
{
    public class SubscriptionAccessRuleConfiguration :IEntityTypeConfiguration<SubscriptionAccessRule>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<SubscriptionAccessRule> builder)
        {
            builder.HasKey(sar => sar.Id);
            builder.HasOne(sar => sar.SubscriptionPlan)
                   .WithMany()
                   .HasForeignKey(sar => sar.SubscriptionPlanId);

            builder.HasMany(sar => sar.AllowedCategories)
                .WithMany()
                .UsingEntity<CategorySubscriptionAccessRule>();
        }
    }
}
