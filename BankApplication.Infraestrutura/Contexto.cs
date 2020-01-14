using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;

namespace BankApplication.Infraestrutura
{
    public sealed class Contexto : IDesignTimeDbContextFactory<BankContext>
    {
        public BankContext CreateDbContext(string[] args)
        {
            string connectionString = LerConnectionStringAppSettings();

            var builder = new DbContextOptionsBuilder<BankContext>();
            builder.UseSqlServer(connectionString);
            return new BankContext(builder.Options);
        }

        private string LerConnectionStringAppSettings()
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(AppContext.BaseDirectory)
                .AddJsonFile("appsettings.json")
                .Build();

            return configuration.GetConnectionString("DefaultConnection");
        }
    }
}