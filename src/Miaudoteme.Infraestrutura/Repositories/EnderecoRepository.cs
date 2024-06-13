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
    public class EnderecoRepository : IEnderecoRepository
    {
        private readonly ApplicationContext _context;
        public EnderecoRepository(ApplicationContext context)
        {
            _context = context;
        }
        public async Task<Endereco> Busca(Expression<Func<Endereco, bool>> expression)
        {
            var endereco = await _context.Enderecos.FindAsync(expression);
            return endereco;
        }

        public async Task<Endereco> BuscaPorId(Guid id)
        {
            var endereco = await _context.Enderecos.FindAsync($"{id}");
            return endereco;
        }

        public async Task<List<Endereco>> BuscaTodos()
        {
            return await _context.Enderecos.ToListAsync();
            
        }

        public async Task<Endereco> Criar(Endereco entidade)
        {
            await _context.Enderecos.AddAsync(entidade);
            var result = _context.SaveChanges();
            return result == 1 ? entidade : throw new Exception("Erro ao criar endereco");
        }

        public async Task Deletar(Guid id)
        {
            var endereco = await Busca(end => end.Id == id);
            _context.Enderecos.Remove(endereco);

        }

        public void Dispose()
        {
            _context?.Dispose();
        }

        public async Task Editar(Endereco entidade)
        {
            _context.Enderecos.Update(entidade);
            await _context.SaveChangesAsync();
        }
    }
}
