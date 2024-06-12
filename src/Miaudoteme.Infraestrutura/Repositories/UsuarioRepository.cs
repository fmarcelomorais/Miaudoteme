using Miaudoteme.Domain.Interfaces;
using Miaudoteme.Domain.Models;
using Miaudoteme.Infraestrutura.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using System.Net.Http.Headers;


namespace Miaudoteme.Infraestrutura.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly ApplicationContext _context;
        public UsuarioRepository(ApplicationContext context)
        {
            _context = context;
        }

        public async Task<Usuario> Busca(Expression<Func<Usuario, bool>> expression)
        {
           var usuarios = await _context.Usuarios.FirstOrDefaultAsync(expression); // uusuario => usuario.Nome == ""
            return usuarios;
           
        }

        public async Task<Usuario> BuscaPorId(Guid id)
        {
            var usuario = await _context.Usuarios.FirstOrDefaultAsync(x => x.Id == id);
            return usuario;
        }

        public async Task<List<Usuario>> BuscaTodos()
        {
            return await _context.Usuarios.ToListAsync();
        }

        public async Task<Usuario> Criar(Usuario entidade)
        {
            await _context.Usuarios.AddAsync(entidade);
            var result = _context.SaveChanges();
            return result > 0 ? entidade : throw new Exception("Erro ao Criar novo usuário");
        }

        public async Task Deletar(Guid id)
        {
            var usuario = await _context.Usuarios.FirstOrDefaultAsync(u => u.Id == id);
            _context.Usuarios.Remove(usuario);
            await _context.SaveChangesAsync();
            
        }

        public void Dispose()
        {
            _context?.Dispose();
        }

        public async Task Editar(Usuario entidade)
        {
            _context.Usuarios.Update(entidade);
            await _context.SaveChangesAsync();
        }
    }
}
