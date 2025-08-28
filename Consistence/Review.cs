using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consistence
{
    public class Review
    {
        public long Id { get; set; }
        public long BookId { get; set; }
        public long UserId { get; set; }
        public int Rating { get; set; }
        public string? Comment { get; set; }
        //public int StateId { get; set; } //+moderatedby, deletedby
        public DateTime CreatedAt { get; set; }
        public DateTime? PublishedAt { get; set; }
        public DateTime? LastUpdatedAt { get; set; }
        public bool IsDelited { get; set; }
        public Book Book { get; set; } = null!;
        public ApplicationUser User { get; set; } = null!;

    }
}
