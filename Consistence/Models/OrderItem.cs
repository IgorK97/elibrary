using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consistence.Models
{
    public class OrderItem
    {
        public int Id { get; set; }
        public long OrderId { get; set; }
        public long BookId { get; set; }
        public decimal UnitPrice { get; set; }
        public Order Order { get; set; } = null!;
        public Book Book { get; set; } = null!;
    }
}
