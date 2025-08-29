using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Persistence.Models;

namespace Persistence.Configurations
{
    public class ReviewStatusConfiguration :IEntityTypeConfiguration<ReviewStatus>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<ReviewStatus> builder)
        {
            builder.HasKey(rs => rs.Id);
            builder.Property(rs => rs.Name)
                   .IsRequired()
                   .HasMaxLength(100);

        }
    }
}
