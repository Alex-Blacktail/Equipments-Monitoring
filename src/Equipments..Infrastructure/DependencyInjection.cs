using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Equipments.Application.Interfaces;
using System;

namespace Equipments.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddEquipmentsDbContext(this IServiceCollection services, IConfiguration config)
        {
            var connectionString = config.GetConnectionString("Default");

            services.AddDbContext<EquipmentsManagmentContext>(options =>
            {
                options.UseNpgsql(connectionString);
            });

            services.AddScoped<IEquipmentsDbContext>(provider => 
            {
                var context = provider.GetService<EquipmentsManagmentContext>();
                try
                {
                    DbInitializer.Initialize(context);
                }
                catch(Exception ex)
                {
                }

                return context;
            });

            return services;
        }
    }
}
