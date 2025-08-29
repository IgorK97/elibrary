using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consistence.Models
{
  /// <summary>
  /// 
  /// </summary>
    public class AuthorCreation
    {
        public long CreationId { get; set; }
        public Creation Creation { get; set; } = null!;
        public long AuthorId { get; set; }
        public Contributor Author { get; set; } = null!;

    }
}
