using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Persistence.Models;

namespace Persistence.Configurations
{
    public class SubmissionConfiguration :IEntityTypeConfiguration<Submission>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Submission> builder)
        {
            builder.HasKey(s => s.Id);
            builder.Property(s => s.Title)
                   .IsRequired()
                   .HasMaxLength(200);

            builder.HasOne(s => s.SubmittedByPublisher)
                   .WithMany(a => a.Submissions)
                   .HasForeignKey(s => s.SubmittedByPublisherId);

            builder.HasOne(s => s.Status)
                   .WithMany(u => u.Submissions)
                   .HasForeignKey(s => s.StatusId);
        }
    }
}
