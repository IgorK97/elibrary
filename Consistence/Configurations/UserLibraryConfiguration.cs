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
    public class UserLibraryConfiguration :IEntityTypeConfiguration<UserLibrary>
    {
        public void Configure(EntityTypeBuilder<UserLibrary> builder)
        {
            builder.HasKey(ul => ul.Id);
            builder.HasIndex(ul=> new { ul.UserId, ul.BookId }).IsUnique();
            builder.HasOne(ul=>ul.User)
                   .WithMany(u=>u.UserLibraries)
                   .HasForeignKey(ul=>ul.UserId);

            builder.HasOne(ul=>ul.Book)
                     .WithMany(b=>b.UserLibraries)
                     .HasForeignKey(ul=>ul.BookId);

            builder.HasOne(ul=>ul.AccessType)
                        .WithMany(at=>at.UserLibraries)
                        .HasForeignKey(ul=>ul.AccessTypeId);
            builder.HasOne(ul=>ul.Tag)
                            .WithMany(t=>t.TaggedBooks)
                            .HasForeignKey(ul=>ul.TagId);

        }
    }
}
