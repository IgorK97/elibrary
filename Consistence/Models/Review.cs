using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Models
{
    public class Review
    {
        public long Id { get; set; }
        public long BookId { get; set; }
        public Book Book { get; set; } = null!;
        public long UserId { get; set; }
        public ApplicationUser User { get; set; } = null!;
        public decimal Rating { get; set; }
        public string? Comment { get; set; }
        public long? ModeratedById { get; set; }
        public ApplicationUser? ModeratedBy { get; set; }
        //public int StateId { get; set; } //+moderatedby, deletedby
        public DateTime CreatedAt { get; set; }
        public DateTime? ModeratedAt { get; set; }
        public string? Rejectionreason { get; set; }
        public DateTime? PublishedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public bool IsDelited { get; set; }
        public long? DeletedById { get; set; }
        public ApplicationUser? DeletedBy { get; set; }
        public bool DeletedBySystem { get; set; }
        public int StatusId { get; set; }
        public ReviewStatus Status { get; set; } = null!;

    }
}
