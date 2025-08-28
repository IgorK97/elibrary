using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consistence
{
    public class Order
    {
        public long Id { get; set; }
        public long UserId { get; set; }
        public DateTime? OrderDate { get; set; }
        public decimal TotalAmount { get; set; }
        public int StatusId { get; set; }

        public bool PointsAreUsed { get; set; } = false;
    }
}
