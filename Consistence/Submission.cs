using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consistence
{
    public class Submission
    {
        public long Id { get; set; }
        public string Title { get; set; } = null!;
        public long? SubmittedWithUserId { get; set; }
        public long? SubmittedWithPublisherId { get; set; }
        public long SubmittedByManagerId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ReviewedAt { get; set; }
        public DateTime? SubmittedAt { get; set; }
        public int StatusId { get; set; }
        public string? DocumentsPath { get; set; }
        public string? Description { get; set; }
        public string? RejectionReason { get; set; }
        public long? CreationId { get; set; }
        public Creation? Creation { get; set; }
        public long? BookId { get; set; }
        public Book? Book { get; set; }
        public ApplicationUser? SubmittedWithUser { get; set; } = null!;
        public Publisher? SubmittedWithPublisher { get; set; } = null!;
        public ApplicationUser SubmittedByManager { get; set; } = null!;
        public SubmissionStatus SubmissionStatus { get; set; } = null!;
    }
}
