using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consistence
{
    public class GenreCreation
    {
        public int GenreId { get; set; }
        public long CreationId { get; set; }
        public Genre Genre { get; set; } = null!;
        public Creation Creation { get; set; } = null!;
    }
}
