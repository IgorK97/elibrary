using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Persistence.Models;

namespace Persistence.Configurations
{
    public class ContributorRoleConfiguration : IEntityTypeConfiguration<ContributorRole>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<ContributorRole> builder)
        {
            builder.HasKey(cr => cr.Id);
            builder.Property(cr => cr.Name)
                   .IsRequired()
                   .HasMaxLength(100);
            //builder.HasMany(cr => cr.ContributorBooks)
            //       .WithOne(cb => cb.Role)
            //       .HasForeignKey(cb => cb.RoleId);
        }
    }
}
