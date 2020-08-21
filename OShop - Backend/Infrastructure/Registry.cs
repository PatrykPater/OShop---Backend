using Microsoft.Extensions.DependencyInjection;
using OShop___Backend.Infrastructure.Inferfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OShop___Backend.Infrastructure
{
    public static class Registry
    {
        public static void RegisterApiServices(this IServiceCollection services)
        {
            services.AddScoped<ILogger, Logger>();
        }
    }
}
