using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Consistence.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Consistence
{
    public class ELibraryDbContext 
        : IdentityDbContext<ApplicationUser, IdentityRole<long>, long>
    {
        public DbSet<AccessType> AccessTypes { get; set; }
        public DbSet<Agreement> Agreements { get; set; }
        public DbSet<AgreementStatus> AgreementStatuses { get; set; }
        public DbSet<AuthorCreation> AuthorsCreationsJoin { get; set; }
        public DbSet<BBK> BBKs { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<BookView> BookViews { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<CategoryBook> CategoriesBooksJoin { get; set; }
        public DbSet<CategorySubscriptionAccessRule> CategoriesSubscriptionAccessRulesJoin { get; set; }
        public DbSet<CodeType> CodeTypes { get; set; }
        public DbSet<Contributor> Contributors { get; set; }
        public DbSet<ContributorBook> ContributorsBooksJoin { get; set; }
        public DbSet<ContributorRole> ContributorRoles { get; set; }
        public DbSet<Creation> Creations { get; set; }
        public DbSet<CreationBook> CreationsBooksJoin { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<GenreCreation> GenresCreationsJoin { get; set; }
        public DbSet<License> Licenses { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<OrderStatus> OrderStatus { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<PaymentMethod> PaymentMethods { get; set; }
        public DbSet<PaymentStatus> PaymentStatuses { get; set; }
        public DbSet<PriceHistory> PriceHistory { get; set; }
        public DbSet<Promotion> Promotions { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<ReviewStatus> ReviewsStatuses { get; set; }
        public DbSet<Submission> Submissions { get; set; }
        public DbSet<SubmissionStatus> SubmissionStatuses { get; set; }
        public DbSet<SubscriptionAccessRule> SubscriptionAccessRules { get; set; }
        public DbSet<SubscriptionItem> SubscriptionItems { get; set; }
        public DbSet<SubscriptionPlan> SubscriptionPlans { get; set; }
        public DbSet<SubscriptionStatus> SubscriptionStatuses { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<UDK> UDKs { get; set; }
        public DbSet<UserCode> UserCodes { get; set; }
        public DbSet<UserLibrary> UserLibraries { get; set; }
        public DbSet<UserSubscription> UserSubscriptions { get; set; }
        public ELibraryDbContext(DbContextOptions<ELibraryDbContext> options)
        {

        }
    }
}
