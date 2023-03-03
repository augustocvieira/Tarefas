using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;
using Tarefas.Domain.Models;

namespace Tarefas.Domain.Interfaces.Repositories;

public interface IStatusRepository
{
    Task<IEnumerable<Status>> GetAsync(CancellationToken token);
    Task<IEnumerable<Status>> GetAsync(Expression<Func<Status, bool>> condtion, CancellationToken cancellationToken);
    Task<bool> ExistsAsync(Expression<Func<Status, bool>> condition, CancellationToken cancellationToken);
    Task<Status> GetByIdAsync(int statusId, CancellationToken cancellationToken);
}