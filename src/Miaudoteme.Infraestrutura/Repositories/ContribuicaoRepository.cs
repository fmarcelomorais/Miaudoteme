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
    public class ContribuicaoRepository : IContribuicaoRepository
    {
        public Task<Contribuicao> Busca(Expression<Func<Contribuicao, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<Contribuicao> BuscaPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Contribuicao>> BuscaTodos()
        {
            throw new NotImplementedException();
        }

        public Task<Contribuicao> Criar(Contribuicao entidade)
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

        public Task Editar(Contribuicao entidade)
        {
            throw new NotImplementedException();
        }
    }
}
