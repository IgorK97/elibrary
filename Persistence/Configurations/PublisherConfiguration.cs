using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Persistence.Models;

namespace Persistence.Configurations
{
    public class PublisherConfiguration :IEntityTypeConfiguration<Publisher>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Publisher> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Name)
                   .IsRequired()
                   .HasMaxLength(200);
            builder.Property(p => p.Address)
                   .HasMaxLength(500);
            builder.Property(p => p.Email)
                   .HasMaxLength(100);
            //builder.HasMany(p => p.Books)
            //       .WithOne(b => b.Publisher)
            //       .HasForeignKey(b => b.PublisherId);
        }
    }
}
