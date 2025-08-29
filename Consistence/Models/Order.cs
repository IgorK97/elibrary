using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consistence.Models
{
    public class Order
    {
        public long Id { get; set; }
        public long UserId { get; set; }
        public ApplicationUser User { get; set; } = null!;

        public DateTime? OrderDate { get; set; }
        public decimal TotalAmount { get; set; }
        public int StatusId { get; set; }
        public OrderStatus Status { get; set; } = null!;

        public ICollection<OrderItem> OrderItems { get; set; } = [];
    }
}
