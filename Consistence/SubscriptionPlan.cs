using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consistence
{
    public class SubscriptionPlan
    {
        public long Id { get; set; }
        public string Name { get; set; } = null!;
        public decimal Price { get; set; }
        public int DurationInMonths { get; set; }
        public string Description { get; set; } = null!;
        public bool IsActive { get; set; }
    }
}
