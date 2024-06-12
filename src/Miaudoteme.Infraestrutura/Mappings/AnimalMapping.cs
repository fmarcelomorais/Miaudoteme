using Miaudoteme.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Miaudoteme.Infraestrutura.Mappings
{
    public class AnimalMapping : IEntityTypeConfiguration<Animal>
    {
        public void Configure(EntityTypeBuilder<Animal> builder)
        {
            builder.ToTable("Animais");
            builder.HasKey(animal => animal.Id);
            
            builder.Property(animal => animal.Nome).HasMaxLength(100).IsRequired();
            builder.Property(animal => animal.Raca).HasMaxLength(100).IsRequired();
            builder.Property(animal => animal.Genero).HasConversion<string>().IsRequired();
            builder.Property(animal => animal.AnoNascimento).HasConversion<int>().IsRequired();
            builder.Property(animal => animal.Idade).HasConversion<int>().IsRequired();
            builder.Property(animal => animal.Sobre).HasMaxLength(200).IsRequired();

        }
    }
}
