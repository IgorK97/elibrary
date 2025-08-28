using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consistence
{
    public class PointsBucket
    {
        public long Id { get; set; }
        public long UserId { get; set; }
        public int PointsEarned { get; set; }
        public int PointsRemaining {get;set;}
        public DateTime EarnDate { get; set; }
        public DateTime ExpiryDate { get; set; }

    }
}
