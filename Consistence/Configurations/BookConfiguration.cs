using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Persistence.Models;

namespace Persistence.Configurations
{
    public class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Book> builder)
        {
            builder.HasKey(b => b.Id);

            builder.Property(b => b.Title)
                   .IsRequired()
                   .HasMaxLength(200);

            builder.Property(b => b.ISBN)
                   .IsRequired()
                   .HasMaxLength(20);

            builder.Property(b => b.Description)
                   .HasMaxLength(3000);

            builder.Property(b => b.Price)
                   .HasColumnType("decimal(18,2)")
                   .IsRequired();

            builder.HasOne(b => b.BBK)
                   .WithMany(bbk => bbk.Books)
                   .HasForeignKey(b => b.BBKId);

            builder.HasOne(b => b.Publisher)
                     .WithMany(p => p.Books)
                     .HasForeignKey(b => b.PublisherId);

            builder.HasOne(b => b.UDK)
                     .WithMany(udk => udk.Books)
                     .HasForeignKey(b => b.UDKId);

            builder.HasMany(b => b.Contributors)
                   .WithMany(c => c.Books)
                   .UsingEntity<ContributorBook>(
                       j => j
                           .HasOne(cb => cb.Contributor)
                           .WithMany(c => c.ContributorBooks)
                           .HasForeignKey(cb => cb.ContributorId),
                       j => j
                           .HasOne(cb => cb.Book)
                           .WithMany(b => b.ContributorBooks)
                           .HasForeignKey(cb => cb.BookId),
                      
                       j =>
                       {
                           j.HasKey(t => new { t.BookId, t.ContributorId });
                           j.HasOne(cb=>cb.Role)
                            .WithMany(r=>r.ContributorBooks)
                            .HasForeignKey(cb=>cb.RoleId);
                       });

            builder.HasMany(b => b.Creations)
                .WithMany(c => c.Books)
                .UsingEntity<CreationBook>(
                j =>
                {
                    j.HasKey(t=> new { t.BookId, t.CreationId });
                });

            builder.HasMany(b => b.Categories)
                .WithMany(c => c.Books)
                .UsingEntity<CategoryBook>(
                j =>
                {
                    j.HasKey(t => new { t.BookId, t.CategoryId });
                });

            builder.HasMany(b => b.Agreements)
                   .WithOne(a => a.Book)
                   .HasForeignKey(a => a.BookId);

            builder.HasMany(b => b.Submissions)
                   .WithOne(s => s.Book)
                   .HasForeignKey(s => s.BookId);

            builder.HasMany(b => b.Reviews)
                   .WithOne(r => r.Book)
                   .HasForeignKey(r => r.BookId);

            builder.HasMany(b => b.OrderItems)
                   .WithOne(o => o.Book)
                   .HasForeignKey(o => o.BookId);

            builder.HasMany(b => b.BookViews)
                   .WithOne(bv => bv.Book)
                   .HasForeignKey(bv => bv.BookId);

            builder.HasMany(b => b.PriceHistories)
                   .WithOne(ph => ph.Book)
                   .HasForeignKey(ph => ph.BookId);


        }
    }
}
