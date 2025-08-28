using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consistence
{
    public class UserSubscription
    {
        public int Id { get; set; }
        public long UserId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int SubscriptionPlanId { get; set; }
        public int StatusId { get; set; }
        public int RebillId { get; set; }
        public ApplicationUser User { get; set; } = null!;
        public SubscriptionPlan SubscriptionPlan { get; set; } = null!;
        public SubscriptionStatus Status { get; set; } = null!;
    }
}
