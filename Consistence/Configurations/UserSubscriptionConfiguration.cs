using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Persistence.Models;

namespace Persistence.Configurations
{
    public class UserSubscriptionConfiguration :IEntityTypeConfiguration<UserSubscription>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<UserSubscription> builder)
        {
            //builder.HasKey(us => us.Id);
            //builder.Property(us => us.StartDate)
            //       .IsRequired();
            //builder.Property(us => us.EndDate)
            //       .IsRequired();
            //builder.HasOne(us => us.User)
            //       .WithMany(u => u.UserSubscriptions)
            //       .HasForeignKey(us => us.UserId);
            builder.HasOne(us => us.SubscriptionPlan)
                   .WithMany(sp => sp.UserSubscriptions)
                   .HasForeignKey(us => us.SubscriptionPlanId);
            builder.HasOne(us => us.Status)
                     .WithMany(ss => ss.UserSubscriptions)
                     .HasForeignKey(us => us.StatusId);
        }
    }
}
