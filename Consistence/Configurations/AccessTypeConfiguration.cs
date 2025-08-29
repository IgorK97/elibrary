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
    public class AccessTypeConfiguration : IEntityTypeConfiguration<AccessType>
    {
        public void Configure(EntityTypeBuilder<AccessType> builder)
        {

        }
    }
}
