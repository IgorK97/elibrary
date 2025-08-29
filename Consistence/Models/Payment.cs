using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Models
{
    public class Payment
    {
        public long Id { get; set; }
        public long PaymentId { get; set; } //from provider
        //public long OrderId { get; set; }
        public DateTime PaymentDate { get; set; }
        public DateTime? CancellationDate { get; set; }
        public decimal Amount { get; set; }
        public int PaymentMethodId { get; set; }
        public PaymentMethod PaymentMethod { get; set; } = null!;

        public int StatusId { get; set; }
        public PaymentStatus Status { get; set; } = null!;

        public long? OrderId { get; set; }
        public Order? Order { get; set; }
        public long? UserSubscriptionId { get; set; }
        public UserSubscription? UserSubscription { get; set; }
    }
}
