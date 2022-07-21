using Microsoft.Extensions.DependencyInjection;
using MediatR;
using System.Reflection;

namespace Equipments.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddMediatr(this IServiceCollection services)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());
            return services;
        }
    }
}
