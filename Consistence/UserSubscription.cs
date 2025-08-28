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
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int SubscriptionTypeId { get; set; }
        public int StatusId { get; set; }

    }
}
