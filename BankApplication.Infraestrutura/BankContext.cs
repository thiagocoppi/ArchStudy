using BankApplication.Infraestrutura.Entities;
using Microsoft.EntityFrameworkCore;

namespace BankApplication.Infraestrutura
{
    public class BankContext : DbContext
    {
        public BankContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Associado> Users { get; set; } = null;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(BankContext).Assembly);
        }
    }
}