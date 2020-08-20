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

        //public static IServiceCollection RegisterContextService(this IServiceCollection services, string connectionString)
        //{
        //    services.AddDbContext<DBContext>(options => options.UseSqlServer(connectionString));
        //    return services;
        //}

        private static void RegisterContextService(this IServiceCollection services)
        {
            services.AddDbContext<DBContext>(options => options.UseSqlServer(ConfigSettings.ConnectionString));
        }

        private static void RegisterDependencies(this IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();
        }


        private static void SeedDB(this IServiceCollection services)
        {
            var context = services.BuildServiceProvider().CreateScope().ServiceProvider.GetRequiredService<DBContext>();
            context.Database.EnsureCreated();

            if (context.Products.Any())
                return;

            var products = new Product[]
            {
                new Product{ Name = "TEST", Price = 1.5m, ImageUrl = "url"},
            };

            foreach (var product in products)
            {
                context.Products.Add(product);
            }

            context.SaveChanges();
        }

    }
}
