using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consistence
{
    public class UserCode
    {
        public long Id { get; set; }
        public long UserId { get; set; }
        public string Code { get; set; } = null!;
        public int TypeId { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public bool IsUsed { get; set; }
    }
}
