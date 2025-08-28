using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consistence
{
    public class OrderPayment
    {
        public long OrderId { get; set; }
        public long PaymentId { get; set; }
        public Order Order { get; set; } = null!;
        public Payment Payment { get; set; } = null!;
    }
}
