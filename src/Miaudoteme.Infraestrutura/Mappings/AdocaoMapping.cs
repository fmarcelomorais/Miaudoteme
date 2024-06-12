using Miaudoteme.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Miaudoteme.Infraestrutura.Mappings
{
    public class AdocaoMapping : IEntityTypeConfiguration<Adocao>
    {
        public void Configure(EntityTypeBuilder<Adocao> builder)
        {
            builder.ToTable("Adocoes");
            builder.HasKey(adocao =>adocao.Id);

            builder.Property(adocao => adocao.Codigo).HasMaxLength(10).IsRequired();
            builder.Property(adocao => adocao.DataAdocao).HasDefaultValueSql("GETDATE()").ValueGeneratedOnAdd().IsRequired();
            builder.Property(adocao => adocao.SituacaoDaAdocao).HasConversion<string>().IsRequired();

            builder.HasOne(a => a.Animal).WithOne(a => a.Adocao);
            builder.HasOne(a => a.Abrigo).WithOne(a => a.Adocao);
            builder.HasOne(a => a.Tutor).WithOne(a => a.Adocao);
            builder.HasOne(a => a.Contribuicao).WithOne(a => a.Adocao);
        }
    }
}
