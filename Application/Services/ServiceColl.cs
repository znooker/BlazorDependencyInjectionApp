
using Microsoft.Extensions.DependencyInjection;

namespace Application.Services
{
    public static class ServiceColl
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<ITestService, TestService>();

            return services;
        }
    }
}
