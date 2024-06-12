using Miaudoteme.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Miaudoteme.Infraestrutura.Context
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Abrigo> Abrigos { get; set; }
        public DbSet<Adocao> Adocoes { get; set; }
        public DbSet<Animal> Animais { get; set; }
        public DbSet<Contribuicao> Contribuicoes { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Licenca> Licencas { get; set; }
        public DbSet<Tutor> Tutores { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=MiaudotemeDb;Trusted_Connection=True;Encrypt=False;TrustServerCertificate=True;");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}
