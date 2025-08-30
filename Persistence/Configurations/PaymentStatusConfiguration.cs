using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Persistence.Models;

namespace Persistence.Configurations
{
    public class PaymentStatusConfiguration :IEntityTypeConfiguration<PaymentStatus>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<PaymentStatus> builder)
        {
            builder.HasKey(ps => ps.Id);
            builder.Property(ps => ps.Name)
                   .IsRequired()
                   .HasMaxLength(100);

        }
    }
}
