using Microsoft.Extensions.DependencyInjection;

namespace BankApplication.DependencyInjection
{
    public static class InjectorExtensions
    {
        public static IServiceCollection AddDepedencyInjections(this IServiceCollection services)
        {
            return services;
        }
    }
}