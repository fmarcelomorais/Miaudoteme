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
    public class AbrigoRepository : IAbrigoRepository
    {
        public Task<Abrigo> Busca(Expression<Func<Abrigo, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<Abrigo> BuscaPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Abrigo>> BuscaTodos()
        {
            throw new NotImplementedException();
        }

        public Task<Abrigo> Criar(Abrigo entidade)
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

        public Task Editar(Abrigo entidade)
        {
            throw new NotImplementedException();
        }
    }
}
