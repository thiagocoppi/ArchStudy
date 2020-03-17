using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;

namespace Infraestrutura
{
    public sealed class ArchStudyContextFactory : IDesignTimeDbContextFactory<ArchContext>
    {
        public ArchContext CreateDbContext(string[] args)
        {
            string connectionString = RetrieveConnectionString();

            var optionsBuilder = new DbContextOptionsBuilder<ArchContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new ArchContext(optionsBuilder.Options);
        }

        private string RetrieveConnectionString()
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                            .SetBasePath(Directory.GetCurrentDirectory())
                            .AddJsonFile("appsettings.json")
                            .Build();

            var connectionString = configuration.GetConnectionString("DefaultConnection");
            return connectionString;
        }
    }
}