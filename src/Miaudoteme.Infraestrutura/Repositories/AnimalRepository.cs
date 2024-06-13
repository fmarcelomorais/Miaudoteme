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
    public class AnimalRepository : IAnimalRepository
    {
        public Task<Animal> Busca(Expression<Func<Animal, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<Animal> BuscaPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Animal>> BuscaTodos()
        {
            throw new NotImplementedException();
        }

        public Task<Animal> Criar(Animal entidade)
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

        public Task Editar(Animal entidade)
        {
            throw new NotImplementedException();
        }
    }
}
