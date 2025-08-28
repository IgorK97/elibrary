using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consistence
{
    public class PointsTransactions
    {
        public long Id { get; set; }
        public long UserId { get; set; }
        public long OrderId { get; set; }
        public int TypeId { get; set; }
        public int PointsChanged { get; set; }
        public DateTime TransactionDate { get; set; }
        public DateTime? ExpirationDate { get; set; }

    }
}
