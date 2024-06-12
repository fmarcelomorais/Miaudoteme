using Miaudoteme.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Miaudoteme.Infraestrutura.Mappings
{
    public class LicencaMapping : IEntityTypeConfiguration<Licenca>
    {
        public void Configure(EntityTypeBuilder<Licenca> builder)
        {
            builder.ToTable("Licencas");
            builder.HasKey(l => l.Id);

            builder.Property(l => l.Numero).IsRequired();
        }
    }
}
