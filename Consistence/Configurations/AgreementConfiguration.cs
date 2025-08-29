using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Persistence.Models;

namespace Persistence.Configurations
{
    public class AgreementConfiguration : IEntityTypeConfiguration<Agreement>
    {
        public void Configure(EntityTypeBuilder<Agreement> builder)
        {
            builder.HasKey(a => a.Id);

            builder.HasOne(a => a.Manager)
                .WithMany(m => m.Agreements)
                .HasForeignKey(a => a.ManagerId);

            builder.HasOne(a => a.AgreedWithUser)
                .WithMany(u => u.Agreements)
                .HasForeignKey(a => a.AgreedWithUserId);

            builder.HasOne(a => a.AgreedWithPublisher)
                .WithMany(p => p.Agreements)
                .HasForeignKey(a => a.AgreedWithPublisherId);

            builder.HasOne(a => a.Book)
                .WithMany(b => b.Agreements)
                .HasForeignKey(a => a.BookId);

            builder.HasOne(a => a.Status)
                .WithMany(s => s.Agreements)
                .HasForeignKey(a => a.StatusId);

            builder.HasOne(a => a.License)
                .WithMany(l => l.Agreements)
                .HasForeignKey(a => a.LicenseId);

            builder.HasOne(a => a.Submission)
                .WithMany(s=>s.Agreements)
                .HasForeignKey(a => a.SubmissionId);

            builder.Property(a=>a.ContractPath)
                .HasMaxLength(500);

            builder.Property(a=>a.TerminationReason)
                .HasMaxLength(1000);

            builder.Property(a=>a.TerminationDocPath)
                .HasMaxLength(500);
        }
    }
}
