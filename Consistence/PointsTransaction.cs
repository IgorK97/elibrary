using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consistence
{
    public class PointsTransaction
    {
        public long Id { get; set; }
        public long UserId { get; set; }
        public ApplicationUser User { get; set; } = null!;
        public int PointBucketId { get; set; }
        public PointsBucket PointBucket { get; set; } = null!;
        public DateTime TransactionDate { get; set; }
        public int PointsChanged { get; set; }
        public int ChangeTypeId { get; set; } //Earned, Used, Expired
        public PointsTransactionType PointsTransactionType { get; set; } = null!;
    }
}
