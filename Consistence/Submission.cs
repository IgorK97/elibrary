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
        public long SubmittedWith { get; set; }
        public long SubmittedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime SubmittedAt { get; set; }
        public int StatusId { get; set; }
        public string? ManuscriptPath { get; set; }
        public string? Notes { get; set; }
    }
}
