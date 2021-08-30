using Microsoft.Extensions.DependencyInjection;

namespace Domain
{
    public static class DependencyInjection
    {
        public static IServiceCollection ConfigureFluentValidatorDomain(this IServiceCollection services)
        {
            return services;
        }
    }
}