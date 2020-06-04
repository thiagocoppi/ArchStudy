using Application;
using ArchStudy.Filters;
using Domain;
using Domain.Base;
using Infraestrutura;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArchStudy
{
    public class ArchStartup : Startup
    {
        public ArchStartup(IConfiguration configuration): base(configuration)
        {
        }

        public override void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.ConfigureSwagger();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }

        public override void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddSwaggerConfiguration();
            services.ConfigureMidiatR();
            services.ConfigureFluentValidatorApplication();
            services.ConfigureFluentValidatorDomain();

            // Realiza o registro dos serviços com a interface demarcadora
            services.RegisterAllTypes<IDomainService>();
            services.RegisterAllStores<IStore>();

            services.AddSqlServerContext(Configuration);

            services.AddMvc(options => options.Filters.Add<NotificationFilter>());
        }
    }
}
