using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consistence
{
    public class Creation
    {
        public long Id { get; set; }
        public string Title { get; set; } = null!;
        //public string Slug { get; set; }
        public string Description { get; set; } = null!;
        public DateTime? WrittenAt { get; set; }
    }
}
