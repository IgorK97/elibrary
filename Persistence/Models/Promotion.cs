using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Models
{
    public class Promotion
    {
        public long Id { get; set; }
        public long BookId { get; set; }
        public Book Book { get; set; } = null!;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public long ManagerId { get; set; }
        public ApplicationUser Manager { get; set; } = null!;
        public decimal DiscountAmount { get; set; }
        public bool IsActive { get; set; }
    }
}
