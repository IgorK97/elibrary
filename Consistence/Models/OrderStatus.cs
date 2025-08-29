using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consistence.Models
{
    public class OrderStatus
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public ICollection<Order> Orders { get; set; } = [];
    }
}
