using Miaudoteme.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
