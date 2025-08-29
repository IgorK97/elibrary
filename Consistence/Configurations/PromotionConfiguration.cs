using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Persistence.Models;

namespace Persistence.Configurations
{
    public class PromotionConfiguration :IEntityTypeConfiguration<Promotion>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Promotion> builder)
        {
            builder.HasKey(p => p.Id);


        }
    }
}
