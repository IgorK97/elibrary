using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Persistence.Models;

namespace Persistence.Configurations
{
    public class LicenseConfiguration :IEntityTypeConfiguration<License>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<License> builder)
        {
            builder.HasKey(l => l.Id);
            builder.Property(l => l.Name)
                   .HasMaxLength(50);

            builder.Property(l => l.Description)
                   .HasMaxLength(1000);
        }
    }
}
