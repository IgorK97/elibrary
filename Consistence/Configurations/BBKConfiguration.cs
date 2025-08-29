using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Persistence.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations
{
    public class BBKConfiguration : IEntityTypeConfiguration<BBK>
    {
        public void Configure(EntityTypeBuilder<BBK> builder)
        {
            builder.HasKey(bbk => bbk.Id);

            builder.Property(bbk => bbk.Code)
                   .IsRequired()
                   .HasMaxLength(20);

            builder.Property(bbk => bbk.Description)
                   .HasMaxLength(500);

            //builder.HasMany(bbk => bbk.Books)
            //       .WithOne(b => b.BBK)
            //       .HasForeignKey(b => b.BBKId);
        }
    }
}
