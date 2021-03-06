﻿using Domain.Associados;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Infraestrutura
{
    public sealed class ArchContext : DbContext, IArchContext
    {
        public ArchContext(DbContextOptions option) : base(option)
        {
        }

        public DbSet<Associado> Associados { get; set; }

        public Task SaveChangesAsync()
        {
            SaveChanges();

            return Task.CompletedTask;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Aplica as configurações por convenções.
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ArchContext).Assembly);
        }
    }
}