using Infraestrutura;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using System;
using System.Data.Common;

namespace Tests.Base
{
    public class SampleDbContextFactory : IDisposable
    {
        private DbConnection _connection;

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
                using (var context = new ArchContext(options))
                {
                    context.Database.EnsureCreated();
                }
            }

            return new ArchContext(CreateOptions());
        }

        public void Dispose()
        {
            if (_connection != null)
            {
                _connection.Dispose();
                _connection = null;
            }
        }
    }
}