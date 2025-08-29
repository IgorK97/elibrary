using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Persistence.Models;

namespace Persistence.Configurations
{
    public class OrderItemConfiguration :IEntityTypeConfiguration<OrderItem>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<OrderItem> builder)
        {
            builder.HasKey(oi => oi.Id);

            builder.Property(oi => oi.ItemPrice)
                   .HasColumnType("decimal(18,2)")
                   .IsRequired();
            builder.ToTable(t => t.HasCheckConstraint("CK_OrderItem_ItemPrice", "ItemPrice >= 0"));
            //builder.HasOne(oi => oi.Order)
            //       .WithMany(o => o.OrderItems)
            //       .HasForeignKey(oi => oi.OrderId);
            //builder.HasOne(oi => oi.Book)
            //       .WithMany(b => b.OrderItems)
            //       .HasForeignKey(oi => oi.BookId);
        }
    }
}
