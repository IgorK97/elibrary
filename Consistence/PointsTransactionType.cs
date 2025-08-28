using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consistence
{
    public class PointsTransactionType
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public ICollection<PointsTransaction> PointsTransactions { get; set; } = [];
    }
}
