using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consistence.Models
{
    public class ReviewStatus
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public ICollection<Review> Reviews { get; set; } = [];
    }
}
