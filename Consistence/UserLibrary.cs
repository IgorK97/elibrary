using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consistence
{
    public class UserLibrary
    {
        public long UserId { get; set; }
        public int BookId { get; set; }
        public int AccessTypeId { get; set; }
        public long? TagId { get; set; }
        public ApplicationUser User { get; set; } = null!;
        public Book Book { get; set; } = null!;
        public AccessType AccessType { get; set; } = null!;
        public Tag? Tag { get; set; }
    }
}
