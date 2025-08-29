using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consistence.Models
{
    public class ContributorBook
    {
        public long BookId { get; set; }
        public long ContributorId { get; set; }
        public int RoleId { get; set; }
        public Book Book { get; set; } = null!;
        public Contributor Contributor { get; set; } = null!;
        public ContributorRole Role { get; set; } = null!;
    }
}
