using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Tarefas.Domain.Models;

namespace Tarefas.Domain.Interfaces.Repositories;

public interface IStatusRepository
{
    Task<IEnumerable<Status>> GetAll(CancellationToken token);
}