using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Persistence.Models;

namespace Persistence.Configurations
{
    public class ContributorConfiguration :IEntityTypeConfiguration<Contributor>
    {
        public void Configure(EntityTypeBuilder<Contributor> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.FullName)
                   .IsRequired()
                   .HasMaxLength(200);

            builder.Property(c=>c.Description)
                .HasMaxLength(3000);

            //builder.HasOne(c => c.User)
            //       .WithOne(au => au.Contributor)
            //       .HasForeignKey<Contributor>(c => c.UserId);

            //builder.HasMany(c => c.ContributorBooks)
            //       .WithOne(cb => cb.Contributor)
            //       .HasForeignKey(cb => cb.ContributorId);
        }
    }
}
