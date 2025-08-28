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
        public long? AgreedWithUser { get; set; }
        public long? AgreedWithPublisher { get; set; }
        public long AgreedBy { get; set; }
        public long BookSubmissionId { get; set; }
        public int StatusId { get; set; }
        public int LicenseId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime SignedAt { get; set; }
        public string? ContractPath { get; set; }
        

    }
}
