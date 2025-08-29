using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Models
{
    public class SubmissionStatus
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public ICollection<Submission> Submissions { get; set; } = [];
    }
}
