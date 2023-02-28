using System.Threading.Tasks;
using System.Threading;

namespace Tarefas.Domain.Interfaces.Repositories;

public interface IUnitOfWork
{
    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}