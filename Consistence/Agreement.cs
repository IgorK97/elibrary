using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consistence
{
    public class Agreement
    {
        public long Id { get; set; }
        public long? AgreedWithUserId { get; set; }
        public ApplicationUser? AgreedWithUser { get; set; }
        public long? AgreedWithPublisherId { get; set; }
        public Publisher? AgreedWithPublisher { get; set; }
        public long AgreedByManagerId { get; set; }
        public ApplicationUser AgreedByManager { get; set; } = null!;
        public long? SubmissionId { get; set; }
        public Submission? BookSubmission { get; set; }
        public int StatusId { get; set; }
        public AgreementStatus Status { get; set; } = null!;
        public int LicenseId { get; set; }
        public License License { get; set; } = null!;
        public DateTime CreatedAt { get; set; }
        public DateTime SignedAt { get; set; }
        public string? ContractPath { get; set; }
        

    }
}
