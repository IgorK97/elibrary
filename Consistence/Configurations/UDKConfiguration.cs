using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Persistence.Models;

namespace Persistence.Configurations
{
    public class UDKConfiguration :IEntityTypeConfiguration<UDK>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<UDK> builder)
        {
            builder.HasKey(udk => udk.Id);
            builder.Property(udk => udk.Code)
                   .IsRequired()
                   .HasMaxLength(20);
            builder.Property(udk => udk.Description)
                   .HasMaxLength(500);
            //builder.HasMany(udk => udk.Books)
            //       .WithOne(b => b.UDK)
            //       .HasForeignKey(b => b.UDKId);
        }
    }
}
