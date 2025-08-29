using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consistence
{
    public class SubscriptionAccessRule
    {
        public int Id { get; set; }
        public int SubscriptionPlanId { get; set; }
        public SubscriptionPlan SubscriptionPlan { get; set; } = null!;
        public ICollection<Category> AllowedCategories { get; set; } = [];
    }
}
