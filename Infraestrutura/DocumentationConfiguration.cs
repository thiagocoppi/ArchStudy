using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NSwag;

namespace Infraestrutura
{
    public static class DocumentationConfiguration
    {
        public static IServiceCollection AddSwaggerConfiguration(this IServiceCollection services)
        {
            services.AddSwaggerDocument(config =>
            {
                config.PostProcess = document =>
                {
                    document.Info.Title = "Documentação API";
                    document.Info.Description = "Documentação da API de estudos";
                    document.Info.Version = "v1";
                    document.Info.TermsOfService = "none";
                    document.Info.Contact = new OpenApiContact()
                    {
                        Email = "coppithiago@gmail.com",
                        Name = "Thiago Coppi",
                        Url = "www.github.com/thiagocoppi"
                    };
                };
            });
            return services;
        }

        public static IApplicationBuilder ConfigureSwagger(this IApplicationBuilder app)
        {
            app.UseSwagger();
            app.UseSwaggerUi3();
            return app;
        }

        public static IServiceCollection AddSqlServerContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddEntityFrameworkSqlServer()
            .AddDbContext<ArchContext>(options =>
                options.UseSqlServer(
                    configuration.GetConnectionString("DefaultConnection")));

            services.AddScoped<IArchContext>(provider => provider.GetService<ArchContext>());
            return services;
        }
    }
}