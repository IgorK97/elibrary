using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Persistence.Models;

namespace Persistence.Configurations
{
    public class ReviewConfiguration :IEntityTypeConfiguration<Review>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Review> builder)
        {
            builder.HasKey(r => r.Id);

            builder.Property(r => r.Comment)
                   .IsRequired()
                   .HasMaxLength(5000);

            builder.Property(r => r.Rating)
                   .IsRequired()
                   .HasColumnType("decimal(3,1)");

            builder.HasOne(r => r.Status)
                     .WithMany(rs => rs.Reviews)
                     .HasForeignKey(r => r.StatusId);

            //builder.HasOne(r => r.ModeratedBy)
            //       .WithMany(u => u.ManagedReviews)
            //       .HasForeignKey(r => r.ModeratedById);

            builder.HasOne(r => r.DeletedBy)
                     .WithMany()
                     .HasForeignKey(r => r.DeletedById)
                     .OnDelete(DeleteBehavior.Restrict);

            

            //builder.HasOne(r => r.User)
            //       .WithMany(u => u.ReaderReviews)
            //       .HasForeignKey(r => r.UserId);

            //builder.HasOne(r => r.Book)
            //       .WithMany(b => b.Reviews)
            //       .HasForeignKey(r => r.BookId);

            builder.ToTable(t=>t.HasCheckConstraint("CK_Review_Rating", "Rating >= 0 AND Rating <= 5"));
        }
    }
}
