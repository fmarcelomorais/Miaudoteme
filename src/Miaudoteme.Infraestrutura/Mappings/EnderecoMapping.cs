using Miaudoteme.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Miaudoteme.Infraestrutura.Mappings
{
    public class EnderecoMapping : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.ToTable("Enderecos");
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Logradouro).HasMaxLength(100).IsRequired();
            builder.Property(e => e.Numero).HasMaxLength(20).IsRequired();
            builder.Property(e => e.Complemento).HasMaxLength(50);
            builder.Property(e => e.Bairro).HasMaxLength(50).IsRequired();
            builder.Property(e => e.Cidade).HasMaxLength(50).IsRequired();
            builder.Property(e => e.Estado).HasColumnType("CHAR(2)").IsRequired();

        }
    }
}
