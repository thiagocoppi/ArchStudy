using Application;
using ArchStudy.Filters;
using Autofac;
using Domain;
using Infraestrutura;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace ArchStudy
{
    public class ArchStartup : Startup
    {
        public ArchStartup(IConfiguration configuration) : base(configuration)
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
            app.UseMiddleware<GlobalExceptionMiddleware>();
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

            services.AddSqlServerContext(Configuration);

            services.AddMvc(options => options.Filters.Add<NotificationFilter>());
        }

        public void ConfigureContainer(ContainerBuilder Builder)
        {
            Builder.RegisterModule(new InfraestruturaModule());
            Builder.RegisterModule(new DomainModule());
            Builder.RegisterType(typeof(GlobalExceptionMiddleware));
        }
    }
}