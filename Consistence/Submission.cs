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
        public long SubmittedWithUserId { get; set; }
        public long SubmittedByManagerId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime SubmittedAt { get; set; }
        public int StatusId { get; set; }
        public string? DocumentsPath { get; set; }
        public string? Notes { get; set; }
        public ApplicationUser SubmittedWithUser { get; set; } = null!;
        public ApplicationUser SubmittedByManager { get; set; } = null!;
        public SubmissionStatus SubmissionStatus { get; set; } = null!;
    }
}
