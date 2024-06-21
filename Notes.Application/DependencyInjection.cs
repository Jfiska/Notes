using MediatR;
using System.Reflection;
using Microsoft.Extensions.DependencyInjection;

namespace Notes.Application
{
    internal static class DependencyInjection
    {
        public static IServiceCollection AddAplication(this IServiceCollection services)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());
            return services;
        }
    }
}
