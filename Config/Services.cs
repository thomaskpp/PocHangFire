using PocScheduler.Domain.Model;
using PocScheduler.Domain.Services;

namespace PocScheduler.Config
{
    public static class Services
    {
        public static IServiceCollection AddServicesImplementations(this IServiceCollection services)
        {
            services.AddTransient<IBaseService<OneModel>,OneService>();
            return services;
        }
    }
}