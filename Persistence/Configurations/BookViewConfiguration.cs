using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Persistence.Models;

namespace Persistence.Configurations
{
    public class BookViewConfiguration :IEntityTypeConfiguration<BookView>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<BookView> builder)
        {
            builder.HasKey(bv => bv.Id);
            //builder.Property(bv => bv.ViewedAt)
            //       .IsRequired();
            //builder.HasOne(bv => bv.Book)
            //       .WithMany(b => b.BookViews)
            //       .HasForeignKey(bv => bv.BookId);
            //builder.HasOne(bv => bv.User)
            //       .WithMany(au => au.BookViews)
            //       .HasForeignKey(bv => bv.UserId);
        }
    }
}
