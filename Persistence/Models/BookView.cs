using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Models
{
    public class BookView
    {
        public long Id { get; set; }
        public long UserId { get; set; }
        public ApplicationUser User { get; set; } = null!;
        public long BookId { get; set; }
        public Book Book { get; set; } = null!;
        public DateTime ViewedAt { get; set; }
        
        
    }
}
