using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consistence.Models
{
    public class BookView
    {
        public long Id { get; set; }
        public long UserId { get; set; }
        public long BookId { get; set; }
        public DateTime ViewedAt { get; set; }
        public ApplicationUser User { get; set; } = null!;
        public Book Book { get; set; } = null!;
    }
}
