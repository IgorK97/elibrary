using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Persistence.Models;

namespace Persistence.Configurations
{
    public class UserCodeConfiguration : IEntityTypeConfiguration<UserCode>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<UserCode> builder)
        {
            builder.HasKey(uc => uc.Id);
            builder.Property(uc => uc.Code)
                   .IsRequired()
                   .HasMaxLength(50);
            builder.HasOne(uc=>uc.CodeType)
                   .WithMany(ct => ct.UserCodes)
                   .HasForeignKey(uc => uc.CodeTypeId);

            builder.HasIndex(uc => uc.Code)
                .IsUnique()
                .HasFilter("\"is_used\"=false");

            //builder.HasOne(uc => uc.User)
            //       .WithMany(u => u.UserCodes)
            //       .HasForeignKey(uc => uc.UserId);
        }
    }
}
