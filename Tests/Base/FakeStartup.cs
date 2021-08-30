using ArchStudy;
using ArchStudy.Filters;
using Autofac;
using Domain;
using Infraestrutura;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
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

            services.AddEntityFrameworkSqlite().AddDbContext<ArchContext>(options =>
            {
                options.UseSqlite(new SqliteConnection("Data Source=InMemorySample;Mode=Memory;Cache=Shared"));
            });

            services.AddScoped<IArchContext, ArchContext>(provider => provider.GetService<ArchContext>());

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