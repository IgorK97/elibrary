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
    public class AccessTypeConfiguration : IEntityTypeConfiguration<AccessType>
    {
        public void Configure(EntityTypeBuilder<AccessType> builder)
        {
            builder.HasKey(at => at.Id);

            builder.Property(at => at.Name).HasMaxLength(50);

            builder.Property(at=>at.Description).HasMaxLength(100);

            builder.HasMany(at => at.UserLibraryItems)
                   .WithOne(sp => sp.AccessType)
                   .HasForeignKey(sp => sp.AccessTypeId);
        }
    }
}
