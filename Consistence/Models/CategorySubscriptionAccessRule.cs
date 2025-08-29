using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class CategorySubscriptionAccessRule
    {
        public int SubscriptionAccessRuleId { get; set; }
        public SubscriptionAccessRule SubscriptionAccessRule { get; set; } = null!;
        public int CategoryId { get; set; }
        public Category Category { get; set; } = null!;

    }
}
