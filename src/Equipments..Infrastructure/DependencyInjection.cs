using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Equipments.Application.Interfaces;

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
            services.AddScoped<IEquipmentsDbContext>(provider => provider.GetService<EquipmentsManagmentContext>());
            return services;
        }
    }
}
