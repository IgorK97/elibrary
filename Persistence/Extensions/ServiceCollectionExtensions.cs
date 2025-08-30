using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Persistence.Models;

namespace Persistence.Extensions
{
    public static class ServiceCollectionExtensions
    {
        //public static void AddInfrastructurePersistence(this IServiceCollection services, IConfiguration configuration)
        //{
        //    // Add your infrastructure and persistence services here
        //    // For example, you might add DbContext, repositories, etc.
        //    services.AddDbContext<ELibraryDbContext>(options =>
        //    options.UseNpgsql(configuration.GetConnectionString("DefaultConnection"))
        //    .UseSnakeCaseNamingConvention());

        //}

        public static void AddAppDbContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ELibraryDbContext>(options =>
                options.UseNpgsql(
                    configuration.GetConnectionString("DefaultConnection"),
                    b => b.MigrationsAssembly(typeof(ELibraryDbContext).Assembly.FullName))
                .UseSnakeCaseNamingConvention());
        }
        public static void AddIdentityAuth(this IServiceCollection services)
        {

            services.AddIdentity<ApplicationUser, IdentityRole<long>>()
                .AddEntityFrameworkStores<ELibraryDbContext>()
                .AddDefaultTokenProviders();

        }

        //public static void AddInfrastructurePersistenceServices(this IServiceCollection services)
        //{
        //    services.AddScoped<AuditableEntitySaveChangesInterceptor>();
        //    services.AddScoped(typeof(IRepositoryBase<>), typeof(RepositoryBase<>));
        //    services.AddScoped<IUnitOfWork, UnitOfWork>();
        //}

    }
}
