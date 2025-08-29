using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consistence
{
    public class CategorySubscriptionAccessRule
    {
        public int SubscriptionAccessRuleId { get; set; }
        public int CategoryId { get; set; }
        public SubscriptionAccessRule SubscriptionAccessRule { get; set; } = null!;
        public Category Category { get; set; } = null!;
    }
}
