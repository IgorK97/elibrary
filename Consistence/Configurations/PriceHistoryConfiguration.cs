using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Persistence.Models;

namespace Persistence.Configurations
{
    public class PriceHistoryConfiguration :IEntityTypeConfiguration<PriceHistory>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<PriceHistory> builder)
        {
            builder.HasKey(ph => ph.Id);
            builder.Property(ph => ph.OldPrice)
                   .HasColumnType("decimal(18,2)")
                   .IsRequired();
            builder.Property(ph => ph.NewPrice)
                   .HasColumnType("decimal(18,2)")
                   .IsRequired();

            //builder.HasOne(ph => ph.Manager)
            //       .WithMany(au => au.PriceHistories)
            //       .HasForeignKey(ph => ph.ManagerId);
            //builder.HasOne(ph => ph.Book)
            //       .WithMany(b => b.PriceHistories)
            //       .HasForeignKey(ph => ph.BookId);
        }
    }
}
