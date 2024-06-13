using Miaudoteme.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Miaudoteme.Infraestrutura.Mappings
{
    public class TutorMapping : IEntityTypeConfiguration<Tutor>
    {
        public void Configure(EntityTypeBuilder<Tutor> builder)
        {
            builder.ToTable("Tutores");
            builder.HasKey(t => t.Id);

            builder.Property(t => t.NomeCompleto).HasMaxLength(100).IsRequired();
            builder.Property(t => t.CPF).HasColumnType("CHAR(11)").IsRequired();
            builder.Property(t => t.CPF).HasColumnType("CHAR(11)").IsRequired();

            builder.HasOne(t => t.Usuario).WithOne(t => t.Tutor).OnDelete(DeleteBehavior.NoAction);

        }
    }
}
