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
    public class TutorRepository : ITutorRepository
    {
        public Task<Tutor> Busca(Expression<Func<Tutor, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<Tutor> BuscaPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Tutor>> BuscaTodos()
        {
            throw new NotImplementedException();
        }

        public Task<Tutor> Criar(Tutor entidade)
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

        public Task Editar(Tutor entidade)
        {
            throw new NotImplementedException();
        }
    }
}
