using ArchStudy;
using ArchStudy.Filters;
using Domain;
using Domain.Base;
using Infraestrutura;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Tests.Base
{
    public class FakeStartup : Startup
    {
        public FakeStartup(IConfiguration Configuration) : base(Configuration)
        {
        }

        public override void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
        }

        public override void ConfigureServices(IServiceCollection services)
        {
            // Realiza o registro dos serviços com a interface demarcadora
            services.RegisterAllTypes<IDomainService>();
            services.RegisterAllStores<IStore>();
            services.AddScoped<IArchContext, ArchContext>();

            services.AddMvc(options => options.Filters.Add<NotificationFilter>());
        }
    }
}