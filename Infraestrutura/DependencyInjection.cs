using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using NSwag;

namespace Infraestrutura
{
    public static class DependencyInjection
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
            //add the Swagger generator and the Swagger UI middlewares
            app.UseSwagger();
            app.UseSwaggerUi3();
            return app;
        }
    }
}