using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consistence
{
    public class BBK
    {
        public long Id { get; set; }
        public string Code { get; set; } = null!;
        public string Description { get; set; } = null!;
        public ICollection<Book> Books { get; set; } = [];
    }
}
