using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consistence.Models
{
    public class Agreement
    {
        public long Id { get; set; }
        public long? AgreedWithUserId { get; set; }
        public ApplicationUser? AgreedWithUser { get; set; }
        public long? AgreedWithPublisherId { get; set; }
        public Publisher? AgreedWithPublisher { get; set; }
        public long ManagerId { get; set; }
        public ApplicationUser Manager { get; set; } = null!;
        public long? SubmissionId { get; set; }
        public Submission? Submission { get; set; }
        public int StatusId { get; set; }
        public AgreementStatus Status { get; set; } = null!;
        public int LicenseId { get; set; }
        public License License { get; set; } = null!;
        public long BookId { get; set; }
        public Book Book { get; set; } = null!;
        public DateTime CreatedAt { get; set; }
        public DateTime? SignedAt { get; set; }
        public DateTime EffectiveFrom { get; set; }
        public DateTime? EffectiveTo { get; set; }
        public DateTime? TerminatedAt { get; set; }
        public string? ContractPath { get; set; }
        public string? TerminationReason { get; set; }
        public string? TerminationDocPath { get; set; }
    }
}
