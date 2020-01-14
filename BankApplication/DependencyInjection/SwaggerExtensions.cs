using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Swashbuckle.AspNetCore.Swagger;
using System;
using System.IO;
using System.Reflection;

namespace BankApplication.DependencyInjection
{
    public static class SwaggerExtensions
    {
        public static IServiceCollection AddSwagger(this IServiceCollection services)
        {
            services.AddSwaggerGen(
                    options =>
                    {
                        options.SwaggerDoc("v1", new Info
                        {
                            Title = "Bank API",
                            Version = "v1",
                            Contact = new Contact { Email = "coppithiago@gmail.com", Name = "Thiago Coppi", Url = "https://github.com/thiagocoppi" },
                            Description = "Documentação destinada a API bancária - Estudo apenas",
                            License = new License { Name = "Apache GNU 2.0" }
                        });
                        // Leitura dos XMLs de comentários
                        options.IncludeXmlComments(XmlCommentsFilePath);
                    });

            return services;
        }

        private static string XmlCommentsFilePath
        {
            get
            {
                string basePath = AppContext.BaseDirectory;
                string fileName = typeof(Startup).GetTypeInfo().Assembly.GetName().Name + ".xml";
                return Path.Combine(basePath, fileName);
            }
        }

        public static IApplicationBuilder UseVersionedSwagger(this IApplicationBuilder app)
        {
            app.UseSwagger();
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Bank API");
                c.DocumentTitle = "Documentação das API do Banco";
            });

            return app;
        }
    }
}