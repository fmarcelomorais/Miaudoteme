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
    public class LicencaRepository : ILicencaRepository
    {
        private readonly ApplicationContext _context;
        public LicencaRepository(ApplicationContext context)
        {
            _context = context;
        }
        public async Task<Licenca> Busca(Expression<Func<Licenca, bool>> expression)
        {
            var licenca = await _context.Licencas.FindAsync(expression);
            return licenca;
        }

        public async Task<Licenca> BuscaPorId(Guid id)
        {
            return await _context.Licencas.FirstOrDefaultAsync(li => li.Id == id);
        }

        public async Task<List<Licenca>> BuscaTodos()
        {
            return await _context.Licencas.ToListAsync();
        }

        public async Task<Licenca> Criar(Licenca entidade)
        {
            await _context.Licencas.AddAsync(entidade);
            var result = _context.SaveChanges();
            return result == 1 ? entidade : throw new Exception("Erro ao criar licenca");
        }

        public async Task Deletar(Guid id)
        {
            var licenca = await BuscaPorId(id);
            _context.Licencas.Remove(licenca);
            await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context?.Dispose();
        }

        public async Task Editar(Licenca entidade)
        {
            _context.Licencas.Update(entidade);
            await _context.SaveChangesAsync();
        }
    }
}
