﻿using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NSwag;
using System;
using System.Linq;

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

        public static IServiceCollection AddSqlServerContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddEntityFrameworkSqlServer()
            .AddDbContext<ArchContext>(options =>
                options.UseSqlServer(
                    configuration.GetConnectionString("DefaultConnection")));

            services.AddScoped<IArchContext>(provider => provider.GetService<ArchContext>());
            return services;
        }

        public static void RegisterAllStores<T>(this IServiceCollection services)
        {
            var typeInterface = typeof(T);

            AppDomain
                .CurrentDomain
                .GetAssemblies()
                .SelectMany(r => r.GetTypes())
                .Where(r => typeInterface.IsAssignableFrom(r))
                .ToList()
                .ForEach(types =>
                {
                    var interfacesServices = types.GetInterfaces().Where(r => r.Name != "IStore").ToList();
                    if (interfacesServices.Count > 0)
                    {
                        foreach (var interfaceEach in interfacesServices)
                        {
                            services.AddScoped(interfaceEach, types);
                        }
                    }
                });
        }
    }
}