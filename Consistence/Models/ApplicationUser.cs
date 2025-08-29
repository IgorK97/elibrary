using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Persistence.Models
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
        public Contributor? Contributor { get; set; }
        public ICollection<Order> Orders { get; set; } = [];
        public ICollection<Submission> Submissions { get; set; } = [];
        public ICollection<Agreement> Agreements { get; set; } = [];
        public ICollection<BookView> BookViews { get; set; } = [];
        public ICollection<PriceHistory> PriceHistories { get; set; } = [];
        public ICollection<Promotion> Promotions { get; set; } = [];
        public ICollection<Review> Reviews { get; set; } = [];
        public ICollection<Tag> Tags { get; set; } = [];
        public ICollection<UserCode> UserCodes { get; set; } = [];
        public ICollection<UserLibrary> UserLibraryItems { get; set; } = [];
        public ICollection<UserSubscription> UserSubscriptions { get; set; } = [];

    }
}
