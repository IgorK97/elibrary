using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consistence
{
    public class Contributors
    {
        public long Id { get; set; }
        public string FullName { get; set; } = null!;
        public string Description { get; set; } = null!;
        public long? UserId { get; set; }
    }
}
