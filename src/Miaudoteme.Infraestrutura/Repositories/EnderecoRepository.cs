using Miaudoteme.Domain.Interfaces;
using Miaudoteme.Domain.Models;
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
        public Task<Endereco> Busca(Expression<Func<Endereco, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<Endereco> BuscaPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Endereco>> BuscaTodos()
        {
            throw new NotImplementedException();
        }

        public Task<Endereco> Criar(Endereco entidade)
        {
            throw new NotImplementedException();
        }

        public Task Deletar(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Task Editar(Endereco entidade)
        {
            throw new NotImplementedException();
        }
    }
}
