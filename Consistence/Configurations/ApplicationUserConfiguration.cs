using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Persistence.Models;

namespace Persistence.Configurations
{
    public class ApplicationUserConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<ApplicationUser> builder)
        {
            builder.HasKey(au => au.Id);

            builder.Property(au => au.FirstName).HasMaxLength(100);
            builder.Property(au => au.LastName).HasMaxLength(100);
            builder.Property(au=>au.Patronymic).HasMaxLength(100);

            builder.HasMany(au => au.ManagerAgreements)
                   .WithOne(a => a.Manager)
                   .HasForeignKey(a => a.ManagerId);

            builder.HasMany(au => au.ManagerSubmissions)
                     .WithOne(s => s.Manager)
                     .HasForeignKey(s => s.ManagerId);

            builder.HasMany(au => au.ContributorAgreements)
                     .WithOne(a => a.AgreedWithUser)
                     .HasForeignKey(a => a.AgreedWithUserId);

            builder.HasMany(au => au.ContributorSubmissions)
                        .WithOne(s => s.SubmittedByUser)
                        .HasForeignKey(s => s.SubmittedByUserId);

            builder.HasMany(au => au.ReaderReviews)
                   .WithOne(r => r.User)
                   .HasForeignKey(r => r.UserId);

            builder.HasMany(au => au.ManagedReviews)
                   .WithOne(r => r.User)
                   .HasForeignKey(r => r.UserId);

            builder.HasMany(au => au.Orders)
                   .WithOne(o => o.User)
                   .HasForeignKey(o => o.UserId);

            builder.HasOne(au => au.Contributor)
                   .WithOne(c => c.User)
                   .HasForeignKey<Contributor>(c => c.UserId);

            builder.HasMany(au => au.BookViews)
                     .WithOne(bv => bv.User)
                     .HasForeignKey(bv => bv.UserId);

            builder.HasMany(au => au.PriceHistories)
                        .WithOne(ph => ph.Manager)
                        .HasForeignKey(ph => ph.ManagerId);

            builder.HasMany(au => au.Promotions)
                        .WithOne(p => p.Manager)
                        .HasForeignKey(p => p.ManagerId);

            builder.HasMany(au => au.Tags)
                        .WithOne(t => t.CreatedByUser)
                        .HasForeignKey(t => t.CreatedByUserId);

            builder.HasMany(au => au.UserCodes)
                        .WithOne(uc => uc.User)
                        .HasForeignKey(uc => uc.UserId);

            builder.HasMany(au => au.UserLibraries)
                        .WithOne(ul => ul.User)
                        .HasForeignKey(ul => ul.UserId);

            builder.HasMany(au => au.UserSubscriptions)
                        .WithOne(us => us.User)
                        .HasForeignKey(us => us.UserId);

        }
    }
}
