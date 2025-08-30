using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Models
{
    public class ContributorBook
    {
        public long BookId { get; set; }
        public Book Book { get; set; } = null!;
        public long ContributorId { get; set; }
        public Contributor Contributor { get; set; } = null!;
        public int RoleId { get; set; }
        public ContributorRole Role { get; set; } = null!;
    }
}
