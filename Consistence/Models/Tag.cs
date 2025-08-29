using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consistence.Models
{
    public class Tag
    {
        public long Id { get; set; }
        public string Name { get; set; } = null!;
        public bool IsSystem { get; set; }
        public long? CreatedByUserId { get; set; }
        public ApplicationUser? CreatedByUser { get; set; }
        public bool IsDeleted { get; set; }
        public ICollection<UserLibrary> TaggedBooks { get; set; } = [];
    }
}
