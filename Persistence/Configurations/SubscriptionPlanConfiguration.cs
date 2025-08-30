using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Persistence.Models;

namespace Persistence.Configurations
{
    public class SubscriptionPlanConfiguration :IEntityTypeConfiguration<SubscriptionPlan>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<SubscriptionPlan> builder)
        {
            builder.HasKey(sp => sp.Id);
            builder.Property(sp => sp.Name)
                   .IsRequired()
                   .HasMaxLength(100);
            builder.Property(sp => sp.Description)
                   .HasMaxLength(1000);
            builder.Property(sp => sp.Price)
                   .HasColumnType("decimal(18,2)")
                   .IsRequired();
            builder.Property(sp => sp.DurationInMonths)
                   .IsRequired();
            builder.HasMany(builder => builder.UserSubscriptions)
                   .WithOne(sp => sp.SubscriptionPlan)
                   .HasForeignKey(sp => sp.SubscriptionPlanId);
            builder.ToTable(t => t.HasCheckConstraint("ck_subscription_plan_price", "price >= 0"));
            builder.ToTable(t => t.HasCheckConstraint("ck_subscription_plan_duration_in_months", "duration_in_months >= 1 AND duration_in_months <= 12"));
        }
    }
}
