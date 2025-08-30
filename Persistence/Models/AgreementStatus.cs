using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Models
{
    public class AgreementStatus
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public ICollection<Agreement> Agreements { get; set; } = [];
    }
}
