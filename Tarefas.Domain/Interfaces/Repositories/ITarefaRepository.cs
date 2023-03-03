using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;
using Tarefas.Domain.Models;

namespace Tarefas.Domain.Interfaces.Repositories
{
    public interface ITarefaRepository
    {
        Task<IEnumerable<Tarefa>> GetAsync(CancellationToken cancellationToken);
        Task<IEnumerable<Tarefa>> GetAsync(Expression<Func<Tarefa, bool>> condition, CancellationToken cancellationToken);
        Task<bool> ExistsAsync(Expression<Func<Tarefa, bool>> condition, CancellationToken cancellationToken);
        Task InsertAsync(Tarefa tarefa, CancellationToken cancellationToken);
        Task DeleteAsync(Tarefa tarefa);
    }
}
