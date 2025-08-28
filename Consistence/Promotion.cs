using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consistence
{
    public class Promotion
    {
        public long Id { get; set; }
        public long BookId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public long CreatedByUserId { get; set; }
        public decimal DiscountAmount { get; set; }
        public bool IsActive { get; set; }
        public Book Book { get; set; } = null!;
        public ApplicationUser CreatedByUser { get; set; } = null!; 
    }
}
