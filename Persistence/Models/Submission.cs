using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Models
{
    public class Submission
    {
        public long Id { get; set; }
        public string Title { get; set; } = null!;
        public long? SubmittedByUserId { get; set; }
        public ApplicationUser? SubmittedByUser { get; set; } = null!;
        public long? SubmittedByPublisherId { get; set; }
        public Publisher? SubmittedByPublisher { get; set; } = null!;
        public long ManagerId { get; set; }
        public ApplicationUser Manager { get; set; } = null!;
        public DateTime CreatedAt { get; set; }
        public DateTime ReviewedAt { get; set; }
        public DateTime? SubmittedAt { get; set; }
        public int StatusId { get; set; }
        public SubmissionStatus Status { get; set; } = null!;
        public string? DocumentsPath { get; set; }
        public string? Description { get; set; }
        public string? RejectionReason { get; set; }
        public long? CreationId { get; set; }
        public Creation? Creation { get; set; }
        public long? BookId { get; set; }
        public Book? Book { get; set; }
        public ICollection<Agreement> Agreements { get; set; } = [];
    }
}
