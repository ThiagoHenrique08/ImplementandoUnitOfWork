using Microsoft.EntityFrameworkCore;
using UnitOfWork.Infrastructure.Context;
using UnitOfWork.Infrastructure.Interfaces;
using UnitOfWork.Infrastructure.Repository;

namespace UnitOfWork.API.Extensions
{
    public static class DependencyInjectionExtensions
    {
        public static IServiceCollection AddContextService(this IServiceCollection services, IConfiguration configuration)
        {
          
            services.AddDbContext<AppDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("ConnectionString"));
                options.UseLazyLoadingProxies();
            }, ServiceLifetime.Scoped);

            return services;
        }
        public static IServiceCollection AddDomainService(this IServiceCollection services)
        {

            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWorkRepository>();
            services.AddScoped(typeof(IEFRepository<>), typeof(DAL<>));
            return services;
        }

    }

}
