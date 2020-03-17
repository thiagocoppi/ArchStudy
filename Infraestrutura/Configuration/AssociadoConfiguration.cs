using Domain.Associado;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestrutura.Configuration
{
    public sealed class AssociadoConfiguration : IEntityTypeConfiguration<Associado>
    {
        public void Configure(EntityTypeBuilder<Associado> builder)
        {
            builder.HasKey(r => r.Id);
            builder.Property(r => r.Nome).IsRequired();
            builder.Property(r => r.CPF).IsRequired();
            builder.OwnsOne(r => r.Endereco).Property(r => r.Logradouro).HasColumnName("Logradouro").IsRequired();
            builder.OwnsOne(r => r.Endereco).Property(r => r.Complemento).HasColumnName("Complemento");
            builder.OwnsOne(r => r.Endereco).Property(r => r.Numero).HasColumnName("Numero").HasDefaultValue(0);
        }
    }
}