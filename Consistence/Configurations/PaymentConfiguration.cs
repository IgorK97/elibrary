using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Persistence.Models;

namespace Persistence.Configurations
{
    public class PaymentConfiguration :IEntityTypeConfiguration<Payment>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Payment> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Amount)
                   .HasColumnType("decimal(18,2)")
                   .IsRequired();

            builder.Property(p => p.Status)
                   .IsRequired()
                   .HasMaxLength(50);

            //builder.HasOne(p => p.Order)
            //       .WithMany(o => o.Payments)
            //       .HasForeignKey(p => p.OrderId);

            builder.HasOne(p=>p.PaymentMethod)
                   .WithMany(pm=>pm.Payments)
                   .HasForeignKey(p=>p.PaymentMethodId);
            builder.ToTable(t => t.HasCheckConstraint("CK_Payment_Amount", "Amount >= 0"));
        }
    }
}
