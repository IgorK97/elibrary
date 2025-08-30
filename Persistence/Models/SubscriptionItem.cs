using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Models
{
    public class SubscriptionItem
    {
        public long Id { get; set; }
        public long UserSubscriptionId { get; set; }
        public UserSubscription UserSubscription { get; set; } = null!;
        public long BookId { get; set; }
        public Book Book { get; set; } = null!;
        public DateTime AddedDate { get; set; }
    }
}
