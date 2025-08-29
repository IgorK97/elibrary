using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consistence.Models
{
    public class SubscriptionPlan
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public decimal Price { get; set; }
        public int DurationInMonths { get; set; }
        public string Description { get; set; } = null!;
        public bool IsActive { get; set; }
        public ICollection<UserSubscription> UserSubscriptions { get; set; } = [];
    }
}
