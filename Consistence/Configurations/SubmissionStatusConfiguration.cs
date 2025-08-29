using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Persistence.Models;

namespace Persistence.Configurations
{
    public class SubmissionStatusConfiguration :IEntityTypeConfiguration<SubmissionStatus>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<SubmissionStatus> builder)
        {
            builder.HasKey(ss => ss.Id);
            builder.Property(ss => ss.Name)
                   .IsRequired()
                   .HasMaxLength(100);

        }
    }
}
