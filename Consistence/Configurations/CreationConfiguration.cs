using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Persistence.Models;

namespace Persistence.Configurations
{
    public class CreationConfiguration : IEntityTypeConfiguration<Creation>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Creation> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Title)
                   .IsRequired()
                   .HasMaxLength(200);

            builder.Property(c => c.Description)
                   .HasMaxLength(3000);

            builder.HasMany(c => c.Authors)
                   .WithMany(a => a.Creations)
                   .UsingEntity<AuthorCreation>(
                       j =>
                       {
                           j.HasKey(t => new { t.CreationId, t.AuthorId });
                       });

            builder.HasMany(c => c.Genres)
                   .WithMany(g => g.Creations)
                   .UsingEntity<GenreCreation>(
                       j =>
                       {
                           j.HasKey(t => new { t.CreationId, t.GenreId });
                       });
        }
    }
}
