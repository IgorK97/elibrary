using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Persistence.Models;

namespace Persistence.Configurations
{
    public class TagConfiguration :IEntityTypeConfiguration<Tag>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Tag> builder)
        {
            builder.HasKey(t => t.Id);
            builder.Property(t => t.Name)
                   .IsRequired()
                   .HasMaxLength(50);
            builder.HasIndex(t => new { t.Name, t.CreatedByUserId }).IsUnique().HasFilter("\"is_system\"=false");
            //builder.HasMany(t => t.TaggedBooks)
            //       .WithMany()
            //       .UsingEntity<UserLibrary>(

            //           j => j
            //               .HasOne(bt => bt.Tag)
            //               .WithMany(t => t.TaggedBooks)
            //               .HasForeignKey(bt => bt.TagId),
            //           j =>
            //           {
            //               j.HasKey(t => new { t.BookId, t.TagId });
            //           });
        }
    }
}
