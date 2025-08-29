using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consistence.Models
{
    public class SubscriptionItem
    {
        public long Id { get; set; }
        public long UserSubscriptionId { get; set; }
        public long BookId { get; set; }
        public DateTime AddedDate { get; set; }
        //public DateTime? RemovedDate { get; set; }
        public UserSubscription UserSubscription { get; set; } = null!;
        public Book Book { get; set; } = null!;
    }
}
