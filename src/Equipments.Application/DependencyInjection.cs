using Microsoft.Extensions.DependencyInjection;
using MediatR;
using System.Reflection;

namespace Equipments.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplicationMediatr(this IServiceCollection services)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());
            return services;
        }
    }
}
