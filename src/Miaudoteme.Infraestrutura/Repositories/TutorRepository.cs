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
    public class TutorRepository : ITutorRepository
    {
        private readonly ApplicationContext _context;
        public TutorRepository(ApplicationContext context)
        {
            _context = context;
        }
        public async Task<Tutor> Busca(Expression<Func<Tutor, bool>> expression)
        {
            var tutor = await _context.Tutores.FindAsync(expression);
            return tutor;
        }

        public async Task<Tutor> BuscaPorId(Guid id)
        {
            var tutor = await _context.Tutores.FirstOrDefaultAsync(t => t.Id == id);
            return tutor;
        }

        public async Task<List<Tutor>> BuscaTodos()
        {
            return await _context.Tutores.ToListAsync();
        }

        public async Task<Tutor> Criar(Tutor entidade)
        {
            await _context.Tutores.AddAsync(entidade);
            var result = _context.SaveChanges();
            return result == 1 ? entidade : throw new Exception("Erro ao criar tutor");
        }

        public async Task Deletar(Guid id)
        {
            var tutor = await BuscaPorId(id);
            _context.Tutores.Remove(tutor);
            await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context?.Dispose();
        }

        public async Task Editar(Tutor entidade)
        {
            _context.Tutores.Update(entidade);
            await _context.SaveChangesAsync();
        }
    }
}
