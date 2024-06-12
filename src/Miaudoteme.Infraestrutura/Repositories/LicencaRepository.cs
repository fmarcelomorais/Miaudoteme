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
    public class LicencaRepository : ILicencaRepository
    {
        public Task<Licenca> Busca(Expression<Func<Licenca, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<Licenca> BuscaPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Licenca>> BuscaTodos()
        {
            throw new NotImplementedException();
        }

        public Task<Licenca> Criar(Licenca entidade)
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

        public Task Editar(Licenca entidade)
        {
            throw new NotImplementedException();
        }
    }
}
