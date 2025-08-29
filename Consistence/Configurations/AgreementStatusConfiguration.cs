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
    public class AgreementStatusConfiguration : IEntityTypeConfiguration<AgreementStatus>
    {
        public void Configure(EntityTypeBuilder<AgreementStatus> builder)
        {
            builder.HasKey(ags => ags.Id);

            builder.Property(ags => ags.Name).HasMaxLength(50);

            builder.HasMany(ags => ags.Agreements)
                   .WithOne(a => a.Status)
                   .HasForeignKey(a => a.StatusId);
        }
    }
}
