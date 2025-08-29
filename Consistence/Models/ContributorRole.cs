using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consistence.Models
{
    public class ContributorRole
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public ICollection<ContributorBook> ContributorBooks { get; set; } = [];
    }
}
