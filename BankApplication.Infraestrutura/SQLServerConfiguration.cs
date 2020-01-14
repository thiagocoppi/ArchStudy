using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BankApplication.Infraestrutura
{
    public static class SQLServerConfiguration
    {
        public static IServiceCollection AdicionarSQLServer(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<BankContext>(options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            return services;
        }
    }
}