using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consistence
{
    public class SubscriptionPayment
    {
        public long UserSubcsriptionId { get; set; }
        public long PaymentId { get; set; }
        public Payment Payment { get; set; } = null!;
        public UserSubscription UserSubscription { get; set; } = null!;
    }
}
