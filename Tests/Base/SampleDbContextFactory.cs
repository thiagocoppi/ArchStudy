using Infraestrutura;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Data.Common;

namespace Tests.Base
{
    public class SampleDbContextFactory : IDisposable
    {
        private DbConnection _connection;
        private DbContext _context;

        private DbContextOptions<ArchContext> CreateOptions()
        {
            return new DbContextOptionsBuilder<ArchContext>()
                .UseSqlite(_connection).Options;
        }

        public ArchContext CreateContext()
        {
            if (_connection == null)
            {
                _connection = new SqliteConnection("DataSource=:memory:");
                _connection.Open();

                var options = CreateOptions();
                var context = new ArchContext(options);
                _context = context;
                context.Database.EnsureCreated();
                if (context.Database.GetPendingMigrations().Any())
                {
                    context.Database.Migrate();
                }
            }

            return new ArchContext(CreateOptions());
        }

        public void Dispose()
        {
            if (_connection != null)
            {
                _context.Database.EnsureDeleted();
                _connection.Dispose();
                _connection = null;
            }
        }
    }
}