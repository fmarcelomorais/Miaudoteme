using Miaudoteme.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miaudoteme.Infraestrutura.Interfaces
{
    public interface IRepositoryGeneric<TEntity> where TEntity : Entidade
    {
        Task<TEntity> Criar(TEntity entity);
        Task Editar(TEntity entity);
        Task Delete(Guid id);
    }
}
