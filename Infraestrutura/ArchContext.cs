using Domain.Associados;
using Microsoft.EntityFrameworkCore;

namespace Infraestrutura
{
    public sealed class ArchContext : DbContext
    {
        public ArchContext(DbContextOptions option) : base(option)
        {
        }

        public DbSet<Associado> Associados { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Aplica as configurações por convenções.
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ArchContext).Assembly);
        }
    }
}