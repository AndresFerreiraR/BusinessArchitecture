namespace Pacagroup.Ecommerce.Persistence
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Identity.Client;
    using Pacagroup.Ecommerce.Application.Interface.Persistence;
    using Pacagroup.Ecommerce.Persistence.Context;
    using Pacagroup.Ecommerce.Persistence.Interceptors;
    using Pacagroup.Ecommerce.Persistence.Repositories;
    using static Microsoft.EntityFrameworkCore.DbLoggerCategory;


    public static class ConfigureServices
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddSingleton<DapperContext>();
            services.AddScoped<AuditableEntitySaveChangesInterceptor>();
            services.AddDbContext<ApplicationDbContext>(opt =>
            {
                opt.UseSqlServer(configuration.GetConnectionString("NorthwindConnection"),
                    builder => builder.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName));
            });
            services.AddScoped<ICustomersRepository, CustomersRepository>();
            services.AddScoped<IUsersRepository, UsersRepository>();
            services.AddScoped<ICategoriesRepository, CategoriesRepository>();
            services.AddScoped<IDiscountRepository, DiscountRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            return services;
        }
    }
}
