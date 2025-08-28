using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consistence
{
    public class Tag
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool IsSystem { get; set; }
        public long? CreatedBy { get; set; }
    }
}
