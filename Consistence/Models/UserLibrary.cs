using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Models
{
    public class UserLibrary
    {
        public long UserId { get; set; }
        public ApplicationUser User { get; set; } = null!;
        public long BookId { get; set; }
        public Book Book { get; set; } = null!;
        public int AccessTypeId { get; set; }
        public AccessType AccessType { get; set; } = null!;
        public long? TagId { get; set; }
        public Tag? Tag { get; set; }
    }
}
