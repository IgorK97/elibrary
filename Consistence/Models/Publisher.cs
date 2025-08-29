using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consistence.Models
{
    public class Publisher
    {
        public long Id { get; set; }
        public string Name { get; set; } = null!;
        public string Address { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string? Website { get; set; }
        public ICollection<Book> Books { get; set; } = [];
        public ICollection<Agreement> Agreements { get; set; } = [];
        public ICollection<Submission> Submissions { get; set; } = [];
    }
}
