using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consistence.Models
{
    /// <summary>
    /// Represents the association between a genre and a creation.
    /// </summary>
    /// <remarks>This class establishes a many-to-many relationship between genres and creations, where each
    /// genre can be associated with multiple creations, and each creation can belong to multiple genres.</remarks>
    public class GenreCreation
    {
        public int GenreId { get; set; }
        public Genre Genre { get; set; } = null!;
        public long CreationId { get; set; }
        public Creation Creation { get; set; } = null!;
    }
}
