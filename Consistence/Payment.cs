using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consistence
{
    public class Payment
    {
        public long Id { get; set; }
        public long OrderId { get; set; }
        public DateTime PaymentDate { get; set; }
        public decimal Amount { get; set; }
        public int PaymentMethodId { get; set; }
        public int StatusId { get; set; }
    }
}
