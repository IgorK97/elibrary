using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consistence.Models
{
    public class UserCode
    {
        public long Id { get; set; }
        public long UserId { get; set; }
        public ApplicationUser User { get; set; } = null!;
        public string Code { get; set; } = null!;
        public int CodeTypeId { get; set; }
        public CodeType CodeType { get; set; } = null!;
        public DateTime CreatedAt { get; set; }
        public DateTime ExpirationDate { get; set; }
        public bool IsUsed { get; set; }
    }
}
