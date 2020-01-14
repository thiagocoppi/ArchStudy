using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BankApplication.Infraestrutura.Entities.Configuration
{
    public class AssociadoConfiguration : IEntityTypeConfiguration<Associado>
    {
        public void Configure(EntityTypeBuilder<Associado> builder)
        {
            builder.ToTable("Associado");
            builder.HasKey(b => b.Id);
            builder.OwnsOne(b => b.Endereco);
            builder.OwnsOne(b => b.DadosPessoais);
        }
    }
}