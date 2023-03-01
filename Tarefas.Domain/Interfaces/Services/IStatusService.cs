using System.Collections.Generic;
using System.Threading.Tasks;
using System.Threading;
using Tarefas.Domain.Contracts;

namespace Tarefas.Domain.Interfaces.Services;

public interface IStatusService
{
    Task<IEnumerable<StatusDto>> GetAllAsync(CancellationToken token);
}