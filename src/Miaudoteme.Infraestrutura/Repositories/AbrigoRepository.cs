using Miaudoteme.Domain.Interfaces;
using Miaudoteme.Domain.Models;
using Miaudoteme.Infraestrutura.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Miaudoteme.Infraestrutura.Repositories
{
    public class AbrigoRepository : IAbrigoRepository
    {

        private readonly ApplicationContext _context;
        public AbrigoRepository(ApplicationContext context)
        {
            _context = context;
        }
        public async Task<Abrigo> Busca(Expression<Func<Abrigo, bool>> expression)
        {
            var abrigo = await _context.Abrigos.FindAsync(expression);
            return abrigo;
        }

        public async Task<Abrigo> BuscaPorId(Guid id)
        {
            var abrigo = await _context.Abrigos.FirstOrDefaultAsync(abrigo => abrigo.Id == id);
            return abrigo;
        }

        public async Task<List<Abrigo>> BuscaTodos()
        {
            var abrigos = await _context.Abrigos.ToListAsync();
            return abrigos;
        }

        public async Task<Abrigo> Criar(Abrigo entidade)
        {
            await _context.Abrigos.AddAsync(entidade);
            var result = _context.SaveChanges();
            return result == 1 ? entidade : throw new Exception("Erro ao criar abrigo");
        }

        public async Task Deletar(Guid id)
        {
            var abrigo = await BuscaPorId(id);
            _context.Abrigos.Remove(abrigo);
            _context.SaveChanges();
            
        }

        public void Dispose()
        {
            _context?.Dispose();
        }

        public async Task Editar(Abrigo entidade)
        {
            _context.Abrigos.Update(entidade);
            await _context.SaveChangesAsync();
        }
    }
}
