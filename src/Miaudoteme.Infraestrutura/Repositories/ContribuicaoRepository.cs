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
    public class ContribuicaoRepository : IContribuicaoRepository
    {
        private readonly ApplicationContext _context;
        public ContribuicaoRepository(ApplicationContext context)
        {
            _context = context;
        }
        public async Task<Contribuicao> Busca(Expression<Func<Contribuicao, bool>> expression)
        {
            var contribuicao = await _context.Contribuicoes.FindAsync(expression);
            return contribuicao;
        }

        public async Task<Contribuicao> BuscaPorId(Guid id)
        {
            var contribuicao = await _context.Contribuicoes.FirstOrDefaultAsync(cont => cont.Equals(id));
            return contribuicao;
        }

        public async Task<List<Contribuicao>> BuscaTodos()
        {
            return await _context.Contribuicoes.ToListAsync();
        }

        public async Task<Contribuicao> Criar(Contribuicao entidade)
        {
            await _context.Contribuicoes.AddAsync(entidade);
            var result = _context.SaveChanges();
            return result == 1 ? entidade : throw new Exception("Erro ao criar contribuição");
        }

        public async Task Deletar(Guid id)
        {
            var contribuicao = await BuscaPorId(id);
            _context.Contribuicoes.Remove(contribuicao);
            await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context?.Dispose();
        }

        public async Task Editar(Contribuicao entidade)
        {
            _context.Contribuicoes.Update(entidade);
            await _context.SaveChangesAsync();
        }
    }
}
