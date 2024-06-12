using Miaudoteme.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Miaudoteme.Domain.Interfaces;

public interface IRepositoryGeneric<TEntit> : IDisposable where TEntit : Entidade
{
    Task<List<TEntit>> BuscaTodos();
    Task<TEntit> BuscaPorId(Guid id);
    Task<TEntit> Busca(Expression<Func<TEntit, bool>> expression);
    Task<TEntit> Criar(TEntit entidade);
    Task Editar(TEntit entidade);
    Task Deletar(Guid id);

}