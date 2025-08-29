using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consistence.Models
{
    public class Contributor
    {
        public long Id { get; set; }
        public string FullName { get; set; } = null!;
        public string Description { get; set; } = null!;
        public long? UserId { get; set; }
        public ApplicationUser? User { get; set; }
        public ICollection<ContributorBook> ContributorBooks { get; set; } = [];
    }
}
