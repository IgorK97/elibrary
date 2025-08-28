using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consistence
{
    public class Genre
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public ICollection<Creation> Creations { get; set; } = [];
    }
}
