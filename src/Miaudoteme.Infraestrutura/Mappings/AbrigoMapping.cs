using Miaudoteme.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Miaudoteme.Infraestrutura.Mappings;

public class AbrigoMapping : IEntityTypeConfiguration<Abrigo>
{
    public void Configure(EntityTypeBuilder<Abrigo> builder)
    {
        builder.ToTable("Abrigos");
        builder.HasKey(abrigo => abrigo.Id);

        builder.Property(abrigo => abrigo.NomeAbrigo).HasMaxLength(200).IsRequired();
        builder.Property(abrigo => abrigo.CNPJ).HasColumnType("Char(14)").IsRequired();
        builder.Property(abrigo => abrigo.Contato).HasColumnType("Char(11)").IsRequired(); 
        builder.Property(abrigo => abrigo.Email).HasMaxLength(100).IsRequired();
        builder.Property(abrigo => abrigo.SituacaoAbrigo).HasConversion<string>().IsRequired();

        builder.HasOne(abrigo => abrigo.Usuario).WithOne(abrigo => abrigo.Abrigo).OnDelete(DeleteBehavior.Restrict);
        builder.HasMany(abrigo => abrigo.Animais).WithOne(abrigo => abrigo.Abrigo).OnDelete(DeleteBehavior.Restrict);


    }
}
