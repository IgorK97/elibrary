using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consistence
{
    public class AuthorCreation
    {
        public long CreationId { get; set; }
        public long AuthorId { get; set; }
        public Creation Creation { get; set; } = null!;
        public Contributor Author { get; set; } = null!;
    }
}
