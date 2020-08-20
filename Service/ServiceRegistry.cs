using Microsoft.Extensions.DependencyInjection;
using Service.Factories;
using Service.Factories.Interfaces;
using Service.Services;
using Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service
{
    public static class ServiceRegistry
    {
        public static void RegisterServiceLayer(this IServiceCollection services)
        {
            services.RegisterServices();
            services.RegisterFactories();
        }

        private static void RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<IProductService, ProductService>();
        }

        private static void RegisterFactories(this IServiceCollection services)
        {
            services.AddScoped<IProductDtoFactory, ProductDtoFactory>();
        }
    }
}
