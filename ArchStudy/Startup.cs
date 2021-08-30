using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ArchStudy
{
    public abstract class Startup
    {
        protected Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public abstract void ConfigureServices(IServiceCollection services);

        public abstract void Configure(IApplicationBuilder app, IWebHostEnvironment env);
    }
}