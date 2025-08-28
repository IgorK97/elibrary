using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consistence
{
    public class SubscriptionItem
    {
        public long Id { get; set; }
        public long SubscriptionId { get; set; }
        public long BookId { get; set; }
        public DateTime AddedDate { get; set; }
        public DateTime? RemovedDate { get; set; }
    }
}
