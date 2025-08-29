using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Consistence
{
    public class ApplicationUser : IdentityUser<long>
    {
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Patronymic { get; set; } = null!;
        public DateTime CreatedAt { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime? DeletedAt { get; set; }
        public bool MarketingAgreement { get; set; } = false;
        public bool IsDeleted { get; set; } = false;
        //public int Points { get; set; } = 0;

    }
}
