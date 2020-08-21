using Data.Repositories;
using Data.Repositories.Interfaces;
using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;

namespace Data.Infrastructure
{
    public static class DataRegistry
    {
        public static void RegisterDataLayer(this IServiceCollection services)
        {
            services.RegisterContextService();
            services.RegisterDependencies();
        }

        private static void RegisterContextService(this IServiceCollection services)
        {
            services.AddDbContext<DBContext>(options => options.UseSqlServer(ConfigSettings.ConnectionString));
        }

        private static void RegisterDependencies(this IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IShoppingCartRepository, ShoppingCartRepository>();
        }
    }
}
