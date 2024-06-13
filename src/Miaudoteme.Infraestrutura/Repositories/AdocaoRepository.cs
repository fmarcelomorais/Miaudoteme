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
    public class AdocaoRepository : IAdocaoRepository
    {
        private readonly ApplicationContext _context;
        public AdocaoRepository(ApplicationContext context) 
        { 
            _context = context; 
        }
        public async Task<Adocao> Busca(Expression<Func<Adocao, bool>> expression)
        {
            var adocao = await _context.Adocoes.FindAsync(expression);
            return adocao;
        }

        public async Task<Adocao> BuscaPorId(Guid id)
        {
            var adocao = await _context.Adocoes.FirstOrDefaultAsync(adocao => adocao.Id == id);
            return adocao;
        }

        public async Task<List<Adocao>> BuscaTodos()
        {
            return await _context.Adocoes.ToListAsync();
        }

        public async Task<Adocao> Criar(Adocao entidade)
        {
            await _context.Adocoes.AddAsync(entidade);
            var result = _context.SaveChanges();
            return result == 1 ? entidade : throw new Exception("Erro ao criar abrigo");
        }

        public async Task Deletar(Guid id)
        {
            var adocao = await BuscaPorId(id);
            _context.Adocoes.Remove(adocao);
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context?.Dispose();
        }

        public async Task Editar(Adocao entidade)
        {
            _context.Adocoes.Update(entidade);
            await _context.SaveChangesAsync();
        }
    }
}
