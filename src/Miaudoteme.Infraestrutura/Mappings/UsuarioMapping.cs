using Miaudoteme.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Miaudoteme.Infraestrutura.Mappings
{
    public class UsuarioMapping : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("Usuarios");
            builder.HasKey(usuario => usuario.Id);

            builder.Property(usuario => usuario.NomeCompleto).HasMaxLength(55).IsRequired();
            builder.Property(usuario => usuario.Email).HasMaxLength(100).IsRequired();
            builder.Property(usuario => usuario.Senha).HasMaxLength(100).IsRequired();
            builder.Property(usuario => usuario.TipoUsuario).HasConversion<string>();
        }
    }
}
