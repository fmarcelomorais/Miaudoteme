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
    public class AdocaoRepository : IAdocaoRepository
    {
        public Task<Adocao> Busca(Expression<Func<Adocao, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<Adocao> BuscaPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Adocao>> BuscaTodos()
        {
            throw new NotImplementedException();
        }

        public Task<Adocao> Criar(Adocao entidade)
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

        public Task Editar(Adocao entidade)
        {
            throw new NotImplementedException();
        }
    }
}
